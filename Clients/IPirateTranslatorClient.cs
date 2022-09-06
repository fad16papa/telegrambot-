using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LambdaBot.Models.RespnoseModel;

namespace LambdaBot.Clients
{
    public interface IPirateTranslatorClient
    {
        Task<TranslateResponse> Translate(string text, CancellationToken cancellationToken = default);
    }
}