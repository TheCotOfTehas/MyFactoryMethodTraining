namespace MyFactoryMethodTraining
{
    /// <summary>
    /// Базовый интерфес для всех сообщений
    /// </summary>
    public interface IMessage
    {
        public string Message { get; }
        public string Target { get; }
        public string Source { get; }

        void Send();
    }
}
