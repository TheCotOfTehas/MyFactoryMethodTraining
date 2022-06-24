namespace MyFactoryMethodTraining
{
    /// <summary>
    /// Вспомогательный класс. Чтоб код не дублировть
    /// </summary>
    public abstract class MessangerBase : IMessanger
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName { get;}

        /// <summary>
        /// Пароль для авторизации
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Успешность подключения
        /// </summary>
        public bool Conntectd { get; }

        /// <summary>
        /// Создание экземпляра месенджера и авторизация
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <param name="password"></param>
        public MessangerBase(string name, string password)
        {
            if (!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(password))
            {
                UserName = name;
                Password = password;
                Conntectd = Authorize();
            }
            else
            {
                Conntectd = false;
            }
        }
        /// <summary>
        /// Выполнить авторизацию
        /// </summary>
        /// <returns>Успешность авторизации</returns>
        public abstract bool Authorize();

        /// <summary>
        /// Создать пакет сообщения готового для отправки
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        /// <param name="source"> Отправитель соообщения</param>
        /// <param name="target"> Принематель соообщеня</param>
        /// <returns> Само сообщение</returns>
        /// <exception cref="NotImplementedException"></exception>
        public abstract IMessage CreateMassanger(string message, string source, string target);
    }
}
