namespace ChatCommon
{
    public class Message
    {
        public string Sender { get; set; }     // Who is sending the message
        public string Recipient { get; set; } // Who the message is for
        public string Content { get; set; }   // The message text

        public override string ToString()
        {
            return $"{Sender} -> {Recipient}: {Content}";
        }
    }

    public static class ChatConstants
    {
        public const string ServerIp = "127.0.0.1"; // Server's IP
        public const int ServerPort = 8080;         // Server's Port
    }
}
