using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using fastJSON;
using JsonBenchmark.TestDTOs;
using Newtonsoft.Json;

namespace JsonBenchmark
{
    [ClrJob(isBaseline: true)]
    [RPlotExporter, RankColumn]
    [HtmlExporter]
    public class JsonSerializersBenchmarks : JsonBenchmarkBase
    {
        [Benchmark]
        public string NewtonsoftJson_Serialize()
        {
            return JsonConvert.SerializeObject(SampleRoot);
        }

        [Benchmark]
        public string FastJson_Serialize()
        {
            return JSON.ToJSON(SampleRoot);
        }

        [Benchmark]
        public string NewtonsoftJson_StreamSerialize()
        {
            var stringBuilder = new StringBuilder();

            using (var writer = new StringWriter(stringBuilder))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                var ser = new JsonSerializer();
                ser.Serialize(jsonWriter, SampleRoot);
                jsonWriter.Flush();
            }

            return stringBuilder.ToString();
        }

        [Benchmark]
        public string ManualJson_Serialize()
        {
            return SimpleAccountList.ToJson();
        }
    }

}
