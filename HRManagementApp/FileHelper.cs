using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp
{
    public class FileHelper <T> where T : new()
    {
        private string _filePath;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }
        public void SerializeToFile(T employes)
        {
            
        }

        public T DeserializeFromFile()
        {
            if(!File.Exists(_filePath)) 
            {
                return new T();
            }

            var jsonText = File.ReadAllText(_filePath);

            return JsonConvert.DeserializeObject<T>(jsonText);
        }
    }
}
