namespace MyFactoryMethodTraining
{

    /// <summary>
    /// Класс содержит нееобходимую инфу для работы
    /// </summary>
    internal class TestMessage
    {
        /// <summary>
        /// Содержание соообщения
        /// </summary>
        public string Message { get; }
        /// <summary>
        /// Получатель
        /// </summary>
        public string Target { get; }
        /// <summary>
        /// Отправитель
        /// </summary>
        public string Source { get; }
        /// <summary>
        /// Создаём новое соообщение
        /// </summary>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public TestMessage(string message, string source, string target)
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
            // Ограничение размера Письма

            if (message.Length < 140)
            {
                Message = message;
            }
            else 
            {
                throw new ArgumentException("Сообщение не может быть длинне 140 символов", nameof(message));
            }
            Source = source;
            Target = target;
        }
    }
}