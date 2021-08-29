using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace Project0.StoreApplication.Storage.Adapters
{

  public class FileAdapter
  {

    public List<T> ReadFile<T>(string path) where T : class
    {


      if (!File.Exists(path))
      {
        return null;
      }

      var file = new StreamReader(path);
      var xml = new XmlSerializer(typeof(List<T>));
      var data = xml.Deserialize(file) as List<T>;

      return data;

    }
    public void WriteFile<T>(string path, List<T> data) where T : class
    {

      var file = new StreamWriter(path);
      var xml = new XmlSerializer(typeof(List<T>));

      xml.Serialize(file, data);

      file.Close();

    }
  }
}