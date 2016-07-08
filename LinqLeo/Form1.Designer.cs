namespace LinqLeo
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tbInput = new System.Windows.Forms.TextBox();
			this.bTranslate = new System.Windows.Forms.Button();
			this.niNoti = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbInput
			// 
			this.tbInput.Location = new System.Drawing.Point(12, 12);
			this.tbInput.Multiline = true;
			this.tbInput.Name = "tbInput";
			this.tbInput.Size = new System.Drawing.Size(329, 333);
			this.tbInput.TabIndex = 0;
			// 
			// bTranslate
			// 
			this.bTranslate.Location = new System.Drawing.Point(347, 322);
			this.bTranslate.Name = "bTranslate";
			this.bTranslate.Size = new System.Drawing.Size(75, 23);
			this.bTranslate.TabIndex = 1;
			this.bTranslate.Text = "Translate";
			this.bTranslate.UseVisualStyleBackColor = true;
			this.bTranslate.Click += new System.EventHandler(this.bTranslate_Click);
			// 
			// niNoti
			// 
			this.niNoti.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.niNoti.ContextMenuStrip = this.contextMenuStrip1;
			this.niNoti.Icon = ((System.Drawing.Icon)(resources.GetObject("niNoti.Icon")));
			this.niNoti.Text = "LinqLeo";
			this.niNoti.Visible = true;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 357);
			this.Controls.Add(this.bTranslate);
			this.Controls.Add(this.tbInput);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbInput;
		private System.Windows.Forms.Button bTranslate;
		private System.Windows.Forms.NotifyIcon niNoti;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

