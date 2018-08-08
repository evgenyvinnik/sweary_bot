using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SwearyBot
{
    public enum SwearType
    {
        Phrase,
    }

    public class Swear
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public SwearType Type { get; set; }

        [JsonProperty]
        public string SwearPhrase { get; set; }
    }
}
