﻿using System;
using Telegram.Bot;
using Telegram.Bot.Types;

class Program
{
    private static void Main()
    {
        Host @informationrandom_bot = new Host("7702174557:AAHYyhe1O6q9JcflnnPswgZxdnDrC__D4mE");
        informationrandom_bot.Start();
        informationrandom_bot.OnMessage += OnMessage;
        Console.ReadLine();
    }

    private static async void OnMessage(ITelegramBotClient client, Update update)
    {
        string url = "https://t.me/codingprogramm";

        string Git = "https://github.com/SenejuDev/Telegram-bot";

        Random random = new Random();

        int val = random.Next(0, 10);

        if (update.Message?.Text == "/start")
        {
            await client.SendTextMessageAsync(update.Message?.Chat.Id ?? 1639360124, "Добро пожаловать\fнапишите команду чтобы узнать все команды\f .команды", replyToMessageId: update.Message?.MessageThreadId);
        }
        else if (update.Message?.Text == ".команды")
        {
            await client.SendTextMessageAsync(update.Message?.Chat.Id ?? 1639360124, $"Ник:\f{update.Message.Chat.FirstName}\nкоманды:\f .канал\f .ник\f .айди\f .профиль\f .рандом\f .гит", replyToMessageId: update.Message?.MessageThreadId);
        }
        else if (update.Message?.Text == ".канал")
        {
            await client.SendTextMessageAsync(update.Message?.Chat.Id ?? 1639360124, $"ссылка на канал:\v {url}", replyToMessageId: update.Message?.MessageThreadId);
        }
        else if (update.Message?.Text == ".ник")
        {
            await client.SendTextMessageAsync(update.Message?.Chat.Id ?? 1639360124, $"Ваш ник:\v {update.Message.Chat.FirstName}", replyToMessageId: update.Message?.MessageThreadId);
        }
        else if (update.Message?.Text == ".айди")
        {
            await client.SendTextMessageAsync(update.Message?.Chat.Id ?? 1639360124, $"Ваш айди:\v {update.Message.Chat.Id}", replyToMessageId: update.Message?.MessageThreadId);
        }
        else if (update.Message?.Text == ".профиль")
        {
            await client.SendTextMessageAsync(update.Message?.Chat.Id ?? 1639360124, $"Ваш ник:\v {update.Message.Chat.FirstName}\nВаш айди:\v {update.Message.Chat.Id}", replyToMessageId: update.Message?.MessageThreadId);
        }
        else if (update.Message.Text == ".рандом")
        {
            await client.SendTextMessageAsync(update.Message?.Chat.Id ?? 1639360124, $"Рандомное число\f{val}", replyToMessageId: update.Message?.MessageThreadId);
        }
        else if (update.Message.Text == ".гит")
        {
            await client.SendTextMessageAsync(update.Message?.Chat.Id ?? 1639360124, $"ссылка на гит:\v {Git}", replyToMessageId: update.Message?.MessageThreadId);
        }
        Console.ReadLine();
    }
}
