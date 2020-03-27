using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot
{
    class BotManager
    {
        private DiscordSocketClient discordClient;
        private DiscordToken token;

        public BotManager()
        {
            token = new DiscordToken();
            discordClient = new DiscordSocketClient();
        }

        public async Task InitializeBot()
        {
            discordClient.Log += Log;

        }
        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
