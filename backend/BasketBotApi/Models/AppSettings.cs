namespace BasketBotApi.Models;

public abstract class AppSettings
{
    public static string Url { get; set; } = "https://5d29-188-234-148-249.ngrok-free.app";
    
    public static string Key { get; set; } = "BotKey";

    /// <summary>
    /// -654532921 - тестовая группа с ботом
    /// </summary>
    public static long[] GuildChatIds { get; set; } = new long[] { -654532921 };
}