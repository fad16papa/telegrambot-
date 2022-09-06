using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace LambdaBot.Clients
{
    public interface IUpdateService
    {
        Task HandleUpdate(Update update, CancellationToken cancellationToken = default);
    }
}