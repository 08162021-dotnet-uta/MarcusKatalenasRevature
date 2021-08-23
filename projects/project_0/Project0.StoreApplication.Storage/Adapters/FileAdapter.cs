using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Storage.Adapters
{

  public class FileAdapter
  {

    public List<T> ReadFile<T>(string path) where T : class
    {


      var file = new StreamReader(path);

      var xml = new XmlSerializer(typeof(List<T>));

      //Deseiral
      var data = xml.Deserialize(file) as List<T>;

      return data;

    }
    public void WriteFile<T>(List<T> data, string path) where T : class
    {

      var file = new StreamWriter(path);

      var xml = new XmlSerializer(typeof(List<T>));

      xml.Serialize(file, data);

      file.Close();

    }
    public void UseReadFile()
    {
      ReadFile<Store>("path");
    }
  }
}