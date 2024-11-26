using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

public class Host
{
   TelegramBotClient _bot;

    public Action<ITelegramBotClient, Update>? OnMessage;

    public Host(string token)
    {
        _bot = new TelegramBotClient(token);
    }

    public void Start()
    {
        _bot.StartReceiving(UpdateHandler, ErrorHandler);
        Console.WriteLine("Бот запущен");
    }

    private async Task ErrorHandler(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
        Console.WriteLine("Ошибка: " + exception?.Message);
        await Task.CompletedTask;
    }

    private async Task UpdateHandler(ITelegramBotClient client, Update update, CancellationToken token)
    {
        Console.WriteLine($"Пришло сообщение:\f{update.Message?.Chat.Id}\f{update.Message?.Text ?? "не работает"}");
        OnMessage?.Invoke(client, update);
        await Task.CompletedTask;
    }
}
