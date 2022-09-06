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

            public TranslateRequest()
            {
                Text = string.Empty;
            }
        }

        public class TranslateContent
        {
            public string Translated { get; init; }

            public TranslateContent()
            {
                Translated = string.Empty;
            }
        }

        public class TranslateResponse
        {
            public TranslateContent Contents { get; init; }

            public TranslateResponse()
            {
                TranslateContent translateContent = new TranslateContent();
                Contents = translateContent;
            }
        }
    }
}