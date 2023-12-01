using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning3Grafik
{
    public class JsonFileManager
    {
        private string path;

        public JsonFileManager(string filePath)
        {
            path = filePath;
        }

        public void SaveToJson<T>(List<T> dataList)
        {
            string json = JsonConvert.SerializeObject(dataList);
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(json);
            }
        }

        public List<T> LoadAll<T>()
        {
            List<T> dataList = new List<T>();
            if (File.Exists(path))
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    string json = streamReader.ReadLine();
                    dataList = JsonConvert.DeserializeObject<List<T>>(json);
                }
            }
            return dataList;
        }
    }
}
