using Newtonsoft.Json;

namespace BooleanSerialization
{
    public class MainProgram
    {
        public static void Main()
        {
            Employee employee = new Employee { Name = "John Doe", Salary = 2000, IsBranchManager = false };
            var jsonString = JsonConvert.SerializeObject(employee, Formatting.None,
                                                                   new JsonSerializerSettings
                                                                   {
                                                                       Converters = new List<JsonConverter>
                                                                    {
                                                                        new CustomJsonConverter()
                                                                    }
                                                                   });
            Console.WriteLine("Serialized object: " + jsonString);

            var string1 = "{\"Name\":\"John Doe\",\"Salary\":2000,\"IsBranchManager\":0}";
            var obj1 = JsonConvert.DeserializeObject<Employee>(string1,
                                                                   new JsonSerializerSettings
                                                                   {
                                                                       Converters = new List<JsonConverter>
                                                                    {
                                                                        new CustomJsonConverter()
                                                                    }
                                                                   });
            Console.WriteLine("Deserialized object: " + obj1);
            var string2 = "{\"Name\":\"John Doe\",\"Salary\":2000,\"IsBranchManager\":\"yes\"}";
            var obj2 = JsonConvert.DeserializeObject<Employee>(string2,
                                                                   new JsonSerializerSettings
                                                                   {
                                                                       Converters = new List<JsonConverter>
                                                                    {
                                                                        new CustomJsonConverter()
                                                                    }
                                                                   });
            Console.WriteLine("Deserialized object: " + obj2);
        }
    }
}
