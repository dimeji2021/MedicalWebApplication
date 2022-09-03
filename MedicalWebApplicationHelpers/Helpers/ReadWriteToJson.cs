using MedicalWebApplicationHelpers.IHelpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace MedicalWebApplicationHelpers.Helpers
{
    public class ReadWriteToJson : IReadWriteToJson
    {
        private readonly string db = Path.Combine(Environment.CurrentDirectory, @".\DB\");
        public async Task<bool> WriteJsonAsync<T>(string location, T content)
        {
            if (!File.Exists(db + location))
            {
                File.CreateText(db + location).Close();
                var contents = new List<T>() { content };
                var convertedJson = JsonConvert.SerializeObject(contents, Formatting.Indented);
                File.WriteAllText(db + location, convertedJson);
            }
            else
            {
                var fileContent = await File.ReadAllTextAsync(db + location); // Read the json file in the given location
                var list = JsonConvert.DeserializeObject<List<T>>(fileContent);// Convert it to a C# object list
                list.Add(content);                                             // Add to the list
                var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);// Convert back to json file
                File.WriteAllText(db + location, convertedJson); // Overwrite the initial json file
            }
            return true;
        }

        public async Task<List<T>> ReadJsonAsync<T>(string location)
        {
            var fileContent = await File.ReadAllTextAsync(db + location); // Read the json file in the given location
            var resultObject = JsonConvert.DeserializeObject<List<T>>(fileContent); // Convert it to a C# object list
            return resultObject;                                           // Return  C# object list 
        }
    }
}
