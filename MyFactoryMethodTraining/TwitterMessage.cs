namespace MyFactoryMethodTraining
{
    public class TwitterMessage : MessageBase
    {
        public TwitterMessage(string message, string source, string target) : base(message, source, target)
        {

            if (message.Length < 140)
            {
                Message = message;
            }
            else
            {
                Message = message.Substring(0, 140);
            }
        }
        public override void Send()
        {
            Console.WriteLine($"Твитер : сообщение от {Source} для {Target} : {Message}");
        }
    }
}
