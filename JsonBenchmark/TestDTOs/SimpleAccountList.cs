using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonBenchmark.TestDTOs
{
    public class SimpleAccountList
    {
        public SimpleAccount[] accounts { get; set; }

        public string ToJson()
        {
            var sw = new StringWriter();
            var writer = new JsonTextWriter(sw);

            writer.WriteStartObject();
            writer.WritePropertyName("accounts");
            writer.WriteStartArray();

            foreach (var account in accounts)
            {
                writer.WriteValue(account.ToJson());
            }

            writer.WriteEndArray();
            writer.WriteEndObject();
            return sw.ToString();
        }
    }
}
