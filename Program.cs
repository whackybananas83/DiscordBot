using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace DiscordBot
{
    class Program
    { 
        static void Main(string[] args) =>
            new BotManager().InitializeBot().GetAwaiter().GetResult();
    }
}
