using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Exam.Engine
{
    public static class SaveLoad<T>
    {
        private const string PATH_SAVE = @".\save.json";

        public static void SaveJSON(T data) {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            using (StreamWriter file = File.CreateText(PATH_SAVE))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, json);
            }
        }

        public static T LoadObject() {
            using (StreamReader file = File.OpenText(PATH_SAVE))
            {
                JsonSerializer serializer = new JsonSerializer();
                string json = (string)serializer.Deserialize(file, typeof(string));
                T obj = JsonConvert.DeserializeObject<T>(json);
                return obj;
            }
        }
    }
}
