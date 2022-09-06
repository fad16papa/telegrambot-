using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaBot.Configuration
{
    public class BotConfiguration
    {
        public Uri PirateApiBaseUri { get; set; }
        public string BotToken { get; init; }
    }
}