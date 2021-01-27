using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Local_Crypto_Bot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var charId = message.Chat.Id;
            var messageId = message.MessageId;


            await client.SendTextMessageAsync(charId, "Hello", replyToMessageId: messageId);
        }
    }
}
