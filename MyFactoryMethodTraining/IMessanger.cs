namespace MyFactoryMethodTraining
{
    /// <summary>
    /// Базовый интерфей сдля всех месенджеров
    /// </summary>
    public interface IMessanger
    {
        public string UserName { get; }
        public string Password { get; }
        public bool Conntectd { get; }

        IMessage CreateMassanger(string message, string source, string target);
        bool Authorize();
    }
}
