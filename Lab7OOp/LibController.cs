using System;
using System.Collections.Generic;

namespace Lab7OOp
{
    /// <summary>
    /// Контроллер представления
    /// </summary>
    class LibController
    {
        static Repository _repository = new Repository();
        static LibraryService _libraryService = new LibraryService(_repository);
        public LibController()
        {

        }

        /// <summary>
        /// Добавление
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="square"></param>
        /// <param name="avgNumber"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public string add(int type, string name = "",
            string quantity = "", string phone = "",
            string address = "", string square = "",
            string avgNumber = "", string rate = "")
        {
            try
            {
                _libraryService.insertNewLibrary(type, name, quantity, phone, address, square, avgNumber, rate);
                return "Успешно";
            }
            catch (CustInvalidArgumentException e)
            {
                return $"Не добавлено: {e.Message} {e.Place}";
            }

        }

        /// <summary>
        /// Обновление
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <param name="square"></param>
        /// <param name="avgNumber"></param>
        /// <param name="rate"></param>
        /// <returns></returns>
        public string update(string oldName, string name,
            string quantity, string phone,
            string address, string square,
            string avgNumber, string rate)
        {
            try
            {
                _libraryService.update(oldName, name, quantity, phone, address, square, avgNumber, rate);
                return "Успешно";
            }
            catch (CustInvalidArgumentException e)
            {
                return $"Не обновлено: {e.Message} {e.Place}";
            }
        }

        /// <summary>
        /// Получение по имени
        /// </summary>
        /// <param name="libraryName"></param>
        /// <returns></returns>
        public Library GetLibrary(string libraryName)
        {
            return _libraryService.GetLibrary(libraryName);
        }

        /// <summary>
        /// Получение списка имен
        /// </summary>
        /// <returns></returns>
        public List<String> getLibNames()
        {
            return _libraryService.getKeys();
        }
    }


}
