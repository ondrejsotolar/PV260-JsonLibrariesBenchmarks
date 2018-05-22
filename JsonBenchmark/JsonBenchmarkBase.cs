using System;
using System.IO;
using JsonBenchmark.TestDTOs;
using Newtonsoft.Json;

namespace JsonBenchmark
{
    public abstract class JsonBenchmarkBase
    {
        private const string TestFilesFolder = "TestFiles";
        protected string FilePath;
        protected string JsonSampleString;
        protected Root SampleRoot;
        protected SimpleAccountList SimpleAccountList;

        protected JsonBenchmarkBase()
        {
            FilePath = Path.Combine(AppContext.BaseDirectory, TestFilesFolder, "chucknorris.json");
            JsonSampleString = File.ReadAllText(FilePath);
            SampleRoot = JsonConvert.DeserializeObject<Root>(JsonSampleString);

            FilePath = Path.Combine(AppContext.BaseDirectory, TestFilesFolder, "simple-accounts.json");
            JsonSampleString = File.ReadAllText(FilePath);
            SimpleAccountList = JsonConvert.DeserializeObject<SimpleAccountList>(JsonSampleString);
        }
    }
}
