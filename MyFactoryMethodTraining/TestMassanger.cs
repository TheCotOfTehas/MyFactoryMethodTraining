namespace MyFactoryMethodTraining
{
    /// <summary>
    /// Класс представляющий работу с твитером
    /// регистрация и отправка писем
    /// </summary>
    public class TestMassanger
    {
        /// <summary>
        /// Имя пользователя     
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Успешность подключения
        /// </summary>
        public bool Conntectd { get; set; }
        /// <summary>
        /// Создание обьекта письма или сообщения для отправки
        /// </summary>
        /// <param name="userName"> Имя пользователя</param>
        /// <param name="password"> Пароль пользователя</param>
        public TestMassanger(string userName, string password)
        {
            if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password))
            {
                UserName = userName;
                Password = password;
                Conntectd = ConntectToTwitter();
            }
            else
            {
                Conntectd=false;
            }
        }
        /// <summary>
        /// Отправляет сообщенеи пользователя
        /// </summary>
        /// <param name="message"> Сообщение </param>
        /// <param name="source"> Кто </param>
        /// <param name="target"> Кому </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public void SendMessage(string message, string source, string target)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentNullException(nameof(message), "Сообщение не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(source))
            {
                throw new ArgumentNullException(nameof(message), "Имя отпровителя не может быть пустым.");
            }

            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException(nameof(message), "Имя получаеля не может быть пустым.");
            }

            if (message.Length > 140)
            {
                throw new ArgumentException("Сообщение не может быть длинне 140 символов", nameof(message));
            }

            var messageText = new TestMessage(message, source, target);
            SendMessageToTwiter(message);
        }

        private void SendMessageToTwiter(string message)
        {
            //Тут должно быть обращение  к API для отправки сообщения 
            Console.WriteLine($"Твитер отправил {message}");
            Console.ReadKey();
        }

        private bool ConntectToTwitter()
        {
            //Тут должно быть подключение к API 
            Console.WriteLine($"Подключение пользователя {UserName}");
            return true;
        }
    }
}
