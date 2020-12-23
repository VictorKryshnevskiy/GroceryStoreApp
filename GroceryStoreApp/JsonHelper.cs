using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace GroceryStoreApp
{
    public static class  JsonHelper
    {
        static JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };
        public static string Serialize<T>(T value)
        {
            return JsonSerializer.Serialize(value, options);
        }
        public static T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}
