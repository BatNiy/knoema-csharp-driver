using Newtonsoft.Json;

namespace Knoema.Upload
{
	public Enum FileBucket
	{
		Temp,
		Uploads
	}
	
	public class FileProperties
	{
		public int Size { get; set; }
		public string Name { get; set; }
		public string Location { get; set; }
		public string Type { get; set; }
		public FileBucket? FileBucket { get; set; }
	}
}
