namespace LinqLeo
{
	public class Translate
	{
		public string error_msg { get; set; }
		public string translate_source { get; set; }
		public string @base { get; set; }
		public string is_user { get; set; }
		public string pic_url { get; set; }
		public TranslateStruct[] translate { get; set; }
		public string transcription { get; set; }
		public string word_id { get; set; }
		public string word_top { get; set; }
		public string sound_url { get; set; }

		public class TranslateStruct
		{
			public string id { get; set; }
			public string value { get; set; }
			public string votes { get; set; }
			public string is_user { get; set; }
			public string pic_url { get; set; }
		}
	}
}