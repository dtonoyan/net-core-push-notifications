using System.Text.Json;

namespace CorePush.Utils
{
    public static class JsonHelper
    {
        //private static readonly JsonSerializerSettings settings = new JsonSerializerSettings
        //{
        //    ContractResolver = new CamelCasePropertyNamesContractResolver(),
        //    NullValueHandling = NullValueHandling.Ignore,
        //};

        public static string Serialize(object obj)
        {
            return JsonSerializer.Serialize(obj);//, settings);
        }

        public static TObject Deserialize<TObject>(string json)
        {
            return JsonSerializer.Deserialize<TObject>(json);
        }
    }
}
