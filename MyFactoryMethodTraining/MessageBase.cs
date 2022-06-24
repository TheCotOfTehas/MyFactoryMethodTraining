namespace MyFactoryMethodTraining
{
    /// <summary>
    /// Сократит дублирование кода
    /// </summary>
    public abstract class MessageBase : IMessage
    {
        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string Message { get; protected set; }
        /// <summary>
        /// Кому сообщение
        /// </summary>

        public string Target { get;}
        /// <summary>
        /// От кого сообщенийе
        /// </summary>

        public string Source { get; }
        /// <summary>
        /// создание экземпляра соообщения
        /// </summary>
        /// <param name="message"> Текст сообщения</param>
        /// <param name="target"> Кому сообщение </param>
        /// <param name="source"> От кого сообщенийе </param>
        public MessageBase(string message, string target, string source)
        {
            Message = message;
            Target = target;
            Source = source;
        }
        /// <summary>
        /// Отправить сообщение
        /// </summary>
        public abstract void Send();
    }
}
