using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewJson = System.Text.Json;
using System.Text.Json.Serialization;   //[JsonInclude]
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using System;

namespace ProgramKadrowy
{
    internal class JSONSerializers<T>where T : new()
    {
        private string _filePathNewtonSoft = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\SerializacjaNewtonSoft.json";
        private string _filePathNewJson = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\SerializacjaNewJson.json";
         
        public JSONSerializers() 
        {
        }

        public void SerializeToFile_NewtonSoft(T employees)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter writerSW = new StreamWriter(_filePathNewtonSoft))
            using (JsonWriter writerJson = new JsonTextWriter(writerSW))
            {
                serializer.Serialize(writerJson, employees);
                writerJson.Close();
                writerSW.Close();
            }
        }

        public void SerializeToFile_NewJson(T employees)
        {
            NewJson.JsonSerializerOptions options = new NewJson.JsonSerializerOptions();
            //{
            //    IncludeFields = true,
            //    PropertyNameCaseInsensitive = true,
            //    WriteIndented = true,
            //    PropertyNamingPolicy = NewJson.JsonNamingPolicy.CamelCase,
            //};

            using (Stream stream = File.Create(_filePathNewJson))
            {
                NewJson.JsonSerializer.Serialize(utf8Json: stream, value: employees, options = default);
            }
        }

        public T DeserializeFromFile_NewJson()
        {
            if (!File.Exists(_filePathNewJson))
                return new T { };

            FileStream readerJson = File.Open(_filePathNewJson, FileMode.Open);
            using (readerJson)
            {
                T employyes = (T)NewJson.JsonSerializer.Deserialize(readerJson, typeof(T));
                readerJson.Close();
                return employyes;
            }
        }

        public T DeserializeFromFile_NewtonSoft()
        {
            if (!File.Exists(_filePathNewtonSoft))
                return new T { };

            T employees = JsonConvert.DeserializeObject<T>(_filePathNewtonSoft);
            return employees;
        }
    }
}
