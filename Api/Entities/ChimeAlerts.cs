﻿using Newtonsoft.Json;

namespace KoenZomers.Ring.Api.Entities
{
    public class ChimeAlerts
    {
        [JsonProperty(PropertyName = "connection")]
        public string Connection { get; set; }
    }
}
