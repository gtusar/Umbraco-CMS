﻿using Newtonsoft.Json;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;

namespace Umbraco.Web.Models
{
    public abstract class RelatedLinkBase
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("newWindow")]
        public bool NewWindow { get; set; }
        [JsonProperty("isInternal")]
        public bool IsInternal { get; set; }
        [JsonProperty("type")]
        public RelatedLinkType Type { get; set; }
        [JsonIgnore]
        public IPublishedContent Content { get; set; }
    }
}