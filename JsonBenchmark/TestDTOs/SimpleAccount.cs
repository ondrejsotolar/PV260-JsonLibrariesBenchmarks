using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonBenchmark.TestDTOs
{
    public class SimpleAccount
    {
        public string id { get; set; }

        public string ToJson()
        {
            var sw = new StringWriter();
            var writer = new JsonTextWriter(sw);

            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStartArray();
            writer.WriteValue(id);
            writer.WriteEndArray();
            writer.WriteEndObject();

            return sw.ToString();
        }
    }
}
