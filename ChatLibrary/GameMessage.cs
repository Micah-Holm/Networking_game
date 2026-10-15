namespace ChatLibrary;

public class GameMessage
{
    public string Sender { get; set; }
    public string Message { get; set; }
    
    public GameMessage(string sender, string message)
    {
        Sender = sender;
        Message = message;
    }
}