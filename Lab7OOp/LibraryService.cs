using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7OOp
{
    /// <summary>
    /// Сервис для работы с репозиторием
    /// </summary>
    class LibraryService
    {
        private  Repository _repository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="repository">Репозиторий</param>
        public LibraryService(Repository repository) { 
            _repository = repository;
        }

        /// <summary>
        /// Добавление новой библиотеки
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="square"></param>
        /// <param name="avgNumber"></param>
        /// <param name="rate"></param>
        /// <exception cref="CustInvalidArgumentException"></exception>
        public void insertNewLibrary(int type, string name="", 
            string quantity="", string phone="",
            string address = "", string square="",
            string avgNumber="", string rate="")
        {
            try
            {
                Library library = null;
                switch (type)
                {
                    case 0:
                        library = new Library(name: $"Библиотека {_repository.Size()}");
                        break;
                    case 1:
                        validData(name: name);
                        library = new Library(name);
                        break;
                    case 2:
                        validData(name: name, quantityOfBooks: quantity);
                        library = new Library(name, int.Parse(quantity));
                        break;
                    case 4:
                        validData(name,
                        quantity,
                        phone,
                        address,
                        square,
                        avgNumber,
                        rate);
                        library = new Library(name,
                            int.Parse(quantity),
                            phone, address,
                            float.Parse(square),
                            int.Parse(avgNumber),
                            float.Parse(rate));
                        break;

                }
                _repository.add(library.Name, library);
            }catch(CustInvalidArgumentException ex)
            {
                throw new CustInvalidArgumentException(ex.Message, ex.Place);
            }
          
            
        }

        /// <summary>
        /// Обновление существующей билиотеки по имени
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="square"></param>
        /// <param name="avgNumber"></param>
        /// <param name="rate"></param>
        /// <exception cref="CustInvalidArgumentException"></exception>
        public void update(string oldName, string name,
            string quantity, string phone,
            string address, string square,
            string avgNumber, string rate)
        {
            try
            {
                validData(name, quantity, phone, address, square, avgNumber, rate);

                Library library = new Library(name, int.Parse(quantity),
                    phone, address,float.Parse( square),
                    int.Parse( avgNumber), float.Parse(rate));
                _repository.add(name, library);
                _repository.remove(oldName);

            }
            catch (CustInvalidArgumentException exc)
            {
                throw new CustInvalidArgumentException(exc.Message, exc.Place);
            }
        }

        /// <summary>
        /// Получение библиотеки по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Library GetLibrary(string name)
        {
            return _repository.getEl(name);
        }

        /// <summary>
        /// Проверка данных на корректность
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quantityOfBooks"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="square"></param>
        /// <param name="numberOfVisitors"></param>
        /// <param name="rate"></param>
        /// <exception cref="CustInvalidArgumentException"></exception>
        private void validData(string name,
            string quantityOfBooks = "0",
            string phone = "+79012310002",
            string address = "ул.Пушкина,д.12",
            string square = "0",
            string numberOfVisitors = "0",
            string rate = "0")
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new CustInvalidArgumentException("Значение не может быть пустым", "Название");
            }
            if (!int.TryParse(quantityOfBooks, out int quantityParsed) || quantityParsed < 0)
            {

                throw new CustInvalidArgumentException("Неверное значение. Значение должно быть положительным числом", "Библиотечный фонд");
            }
            if (!Regex.IsMatch(phone, "^(\\+7|8)\\d{10}$", RegexOptions.IgnoreCase))
            {
                throw new CustInvalidArgumentException("Значение номера телефона должно соответствовать шаблону: (+7/8)1111111111",
                    "Номер телефона");
            }
            if (!float.TryParse(square, out float squareParsed) || squareParsed < 0)
            {
                throw new CustInvalidArgumentException("Значение не может быть отрицательным", "Площадь");
            }
            if (!Regex.IsMatch(address, "^ул.\\w+,д.\\d{1,3}$", RegexOptions.IgnoreCase))
            {
                throw new CustInvalidArgumentException("Адрес должен соответствовать формату: ул.(Название улицы),д.(номер дома)", "Адрес");
            }
            if (!int.TryParse(numberOfVisitors, out int numberParsed) || numberParsed < 0)
            {
                throw new CustInvalidArgumentException("Неверное значение.Значение должно быть положительным числом", "Среднее число посетителей");
            }
            if (!float.TryParse(rate, out float rateParsed) || rateParsed < 0 || rateParsed > 5)

            {
                throw new CustInvalidArgumentException("Неверное значение." +
                    "Значение - вещественное число должно находится в диапазоне от 0 до 5 включительно", "Рейтинг");
            }
        }

        /// <summary>
        /// Получение списка ключей
        /// </summary>
        /// <returns></returns>
        public List<String> getKeys()
        {
            return _repository.getKeys();
        }
    }
}
