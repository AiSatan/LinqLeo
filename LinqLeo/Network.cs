using System;
using System.IO;
using System.Text;

namespace LinqLeo
{
	public class Network
	{
		public static string Post(string url, string data)
		{
			var req = System.Net.WebRequest.Create(url);
			req.Method = "POST";
			req.Timeout = 100000;
			req.ContentType = "application/x-www-form-urlencoded";
			var sentData = Encoding.GetEncoding(1251).GetBytes(data);
			req.ContentLength = sentData.Length;
			var sendStream = req.GetRequestStream();
			sendStream.Write(sentData, 0, sentData.Length);
			sendStream.Close();
			var res = req.GetResponse();
			var receiveStream = res.GetResponseStream();
			var sr = new StreamReader(receiveStream, Encoding.UTF8);
			//Кодировка указывается в зависимости от кодировки ответа сервера
			var read = new char[256];
			var count = sr.Read(read, 0, 256);
			var Out = string.Empty;
			while (count > 0)
			{
				var str = new string(read, 0, count);
				Out += str;
				count = sr.Read(read, 0, 256);
			}
			return Out;
		} 
	}
}