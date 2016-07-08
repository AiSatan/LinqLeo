using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LinqLeo
{
	public partial class Form1 : Form
	{
		private bool _isRun;
		private string _lastText;

		public Form1()
		{
			InitializeComponent();
			_isRun = true;
			_lastText = Clipboard.GetText();
		}

		private void bTranslate_Click(object sender, EventArgs e)
		{
			var data = Network.Post("http://api.lingualeo.com/gettranslates?port=1001", "word=" + tbInput.Text);
			var result = JsonConvert.DeserializeObject<Translate>(data);
			tbInput.Text = result.translate.Select(s => s.value).Aggregate((s, s1) => s + "\r\n" + s1);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var th = new Thread(() =>
				{
					while (_isRun)
					{
						try
						{
							var text = Clipboard.GetText();
							if (text == _lastText ||
							    text == "")
							{
								continue;
							}
							_lastText = text;

							var data = Network.Post("http://api.lingualeo.com/gettranslates?port=1001", "word=" + text);
							var result = JsonConvert.DeserializeObject<Translate>(data);
							var resultString = result.translate.Select(s => s.value).Aggregate((s, s1) => s + "\r\n" + s1);

							ShowNoti(text, resultString);
						}
						catch
						{
							
						}
					}
				});
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}

		private void ShowNoti(string originalText, string resultString)
		{
			niNoti.ShowBalloonTip(0, originalText, resultString, ToolTipIcon.Info);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_isRun = false;
			Application.Exit();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
