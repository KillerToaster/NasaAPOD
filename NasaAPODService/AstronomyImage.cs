using System;
using Newtonsoft.Json;

namespace NasaAPODService
{
    public class AstronomyImage
    {
        public class root
        {
            [JsonProperty("title")]
            public string title { get; set; }

            [JsonProperty("copyright")]
            public string copyright { get; set; }

            [JsonProperty("date")]
            public string date { get; set; }

            [JsonProperty("explanation")]
            public string explanation { get; set; }

            [JsonProperty("hdurl")]
            public string hdurl { get; set; }

            [JsonProperty("media_type")]
            public string media_type { get; set; }

            [JsonProperty("url")]
            public string url { get; set; }

            [JsonProperty("service_version")]
            public string service_version { get; set; }
        }
    }
}
