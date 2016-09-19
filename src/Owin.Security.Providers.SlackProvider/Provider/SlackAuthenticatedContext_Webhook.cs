﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owin.Security.Providers.Slack.Provider
{
    public class SlackAuthenticatedContext_Webhook
    {
        public SlackAuthenticatedContext_Webhook()
        {

        }
        public SlackAuthenticatedContext_Webhook(JObject botnode)
        {
            this.url  = SlackAuthenticatedContext.TryGetValue(botnode, "url");
            this.channel = SlackAuthenticatedContext.TryGetValue(botnode, "channel");
            this.configuration_url = SlackAuthenticatedContext.TryGetValue(botnode, "configuration_url");
        }
        public string url { get; set; }
        public string channel { get; set; }
        public string configuration_url { get; set; }

    }
}
