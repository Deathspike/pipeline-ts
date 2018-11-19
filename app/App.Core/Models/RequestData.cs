﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace App.Core.Models
{
    public sealed class RequestData
    {
        [JsonProperty]
        public string CallbackName { get; set; }

        [JsonProperty]
        public string EventName { get; set; }

        [JsonProperty]
        public JToken Value { get; set; }
    }
}