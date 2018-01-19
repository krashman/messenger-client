﻿using System;
using Messenger.Client.Objects.Enums;
using Newtonsoft.Json;

namespace Messenger.Client.Objects
{
    [Obsolete]
    public class MessengerCallToAction
    {
        public string Type { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public string Payload { get; set; }

        [JsonProperty("webview_height_ratio")]
        public MessengerWebViewHeightRatio WebviewHeightRatio { get; set; }

        [JsonProperty("messenger_extensions")]
        public bool? MessengerExtensions { get; set; }

    }
}
