using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Abstracts;

namespace Project0.StoreApplication.Storage.Adapters
{

  public class FileAdapter
  {
    private object stores;

    public List<Store> ReadFile()
    {
      string path = @"/home/marcus/revature/marcus_code/data/project_0.xml";

      var file = new StreamReader(path);

      var xml = new XmlSerializer(typeof(List<Store>));

      //Deseiral
      var stores = xml.Deserialize(file) as List<Store>;

      return stores;

    }
    public void WriteFile(List<Store> stores)
    {
      string path = @"/home/marcus/revature/marcus_code/data/project_0.xml";

      var file = new StreamWriter(path);

      var xml = new XmlSerializer(typeof(List<Store>));

      xml.Serialize(file, stores);

      file.Close();

    }
  }
}