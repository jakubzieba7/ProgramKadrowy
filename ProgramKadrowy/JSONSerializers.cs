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
    internal class JSONSerializers
    {
        string _filePathNewtonSoft = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\..\..\..\SerializacjaNewtonSoft.json";
        string _filePathNewJson = $@"{Path.GetDirectoryName(Application.ExecutablePath)}\..\..\..\SerializacjaNewJson.json";
        public JSONSerializers() { }

        public void SerializeToFile_NewtonSoft(List<Employee> employees)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter writerSW = new StreamWriter(_filePathNewtonSoft))
            using (JsonWriter writerJson = new JsonTextWriter(writerSW))
            {
                serializer.Serialize(writerJson, employees);
                writerSW.Close();
                writerJson.Close();
            }
        }

        public void SerializeToFile_NewJson(List<Employee> employees)
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

        public List<Employee> DeserializeFromFile_NewJson()
        {
            if (!File.Exists(_filePathNewJson))
                return new List<Employee> { new Employee() };

            FileStream readerJson = File.Open(_filePathNewJson, FileMode.Open);
            using (readerJson)
            {
                List<Employee> employyes = NewJson.JsonSerializer.Deserialize(readerJson, typeof(List<Employee>))as List<Employee>;
                readerJson.Close();
                return employyes;
            }
        }

        public List<Employee> DeserializeFromFile_NewtonSoft()
        {
            if (!File.Exists(_filePathNewtonSoft))
                return new List<Employee> { new Employee() };

            List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(_filePathNewtonSoft);
            return employees;
        }
    }
}
