using Newtonsoft.Json;

namespace DownloadAndParseXmlToJson
{
    public class Link
    {
        [JsonProperty("@rel")]
        public string Rel { get; set; }

        [JsonProperty("@href")]
        public string Href { get; set; }
    }
}