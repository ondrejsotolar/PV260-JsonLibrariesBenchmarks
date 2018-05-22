# Json libraries benchmark
Your task is to write benchmarks for JSON serializers/deserializers.

## Steps:
1. Try to run test and get familiar with benchmark framework.
2. Implement serialization benchmark for Newtonsoft.Json.
    * implemented in JsonSerializersBenchmarks.cs
3. Prepare another test JSON data and use them in benchmarks.
    * sample-accounts.json, models": Account.cs, AccountList.cs
4. Find out, how to do some performance optimalizations for Newtonsoft.Json and try it.
    * stream serialization (see 6.2.), manual serialization implemented in SimpleAccountList.ToJson()
5. Implement serialization/deseralization benchmarks for another library and compare it with Newtonsoft.Json.
    * implemented in JsonDeserializersBenchmarks.FastJson_Deserialize(), JsonSerializersBenchmarks.FastJson_Serialize() using the FastJson library.

6. Choose one task:
    1. Configure benchmarks to run on different platforms (.net framework, .net core).
    2. Refactor benchmarks for stream deserialization (not whole string JSON will be in memory, but will be read as stream and deserialized in stream fashion).
        * implemented in JsonDeserializersBenchmarks.NewtonsoftJson_StreamDeserialize(), JsonSerializersBenchmarks.NewtonsoftJson_StreamSerialize();
    3. Pick another two JSON serializers/deserializers.
    4. Write powershell and FAKE or CAKE build script, copy HTML reports from build folder to artifact folder.
