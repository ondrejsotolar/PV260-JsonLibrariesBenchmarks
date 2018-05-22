using System.IO;
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
    public class JsonDeserializersBenchmarks : JsonBenchmarkBase
    {
        [Benchmark]
        public Root NewtonsoftJson_Deserialize()
        {
            return JsonConvert.DeserializeObject<Root>(JsonSampleString);
        }

        [Benchmark]
        public Root FastJson_Deserialize()
        {
            return JSON.ToObject<Root>(JsonSampleString);
        }

        [Benchmark]
        public Root NewtonsoftJson_StreamDeserialize()
        {
            using (var fileStream = File.Open(FilePath, FileMode.Open))
            using (var sr = new StreamReader(fileStream))
            using (var reader = new JsonTextReader(sr))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize<Root>(reader);
            }
        }
    }
}
