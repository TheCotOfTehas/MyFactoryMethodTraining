namespace MyFactoryMethodTraining
{
    /// <summary>
    /// Реализация мессенджера  твитера
    /// </summary>
    public class TwitterMessager : MessangerBase
    {
        /// <summary>
        /// Создаёт экземпляр мессенджера
        /// </summary>
        /// <param name="name">Логин</param>
        /// <param name="password">Пароль</param>
        public TwitterMessager(string name, string password) : base(name, password)
        {
        }

        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        /// <returns>Успешна или нет</returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool Authorize()
        {
            Console.WriteLine($"Тут прошла авторизация {UserName} и паролем {Password}");
            return true;
        }

        /// <summary>
        /// Создание сообщения для отправки в твитер
        /// </summary>
        /// <param name="message">Текс сообщения</param>
        /// <param name="source">От кого</param>
        /// <param name="target">Кому</param>
        /// <returns>Сообщение готовое к отправке</returns>
        /// <exception cref="NotImplementedException"></exception>
        public override IMessage CreateMassanger(string message, string source, string target)
        {
            var messageText = new TwitterMessage(message, source, target);
            return messageText;
        }
    }
}
