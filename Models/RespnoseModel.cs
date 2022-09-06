using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaBot.Models
{
    public class RespnoseModel
    {
        internal class TranslateRequest
        {
            public string Text { get; init; }
        }

        public class TranslateContent
        {
            public string Translated { get; init; }
        }

        public class TranslateResponse
        {
            public TranslateContent Contents { get; init; }
        }
    }
}