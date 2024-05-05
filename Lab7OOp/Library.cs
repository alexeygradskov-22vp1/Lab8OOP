using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7OOp
{
    class Library
    {
        private static int _increment = 0;

        private string _id;

        private string _name = "Не определено";

        private int _quantityOfBooks = 0;

        private string _phone = "Не определено";

        private string _address = "Не определено";

        private float _square = 0;

        private int _avgNumberOfVisitors = 0;

        private float _rate = 0;

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Library()
        {

        }

        /// <summary>
        /// Конструктор, устанавливающий название библиотеки
        /// </summary>
        /// <param name="name">Название библотеки</param>
        public Library(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Конструктор, устанавливающий название библиотеки и библиотечный фонд
        /// </summary>
        /// <param name="name">Название библиотеки</param>
        /// <param name="quantityOfBooks">Библиотечный фонд</param>
        public Library(string name, int quantityOfBooks) : this(name)
        {
            _quantityOfBooks = quantityOfBooks;
        }

        /// <summary>
        /// Конструктор, устанавливающий название библиотеки, библиотечный фонд, номер телефона, адрес, площадь, среднее число
        /// посетителей, рейтинг
        /// </summary>
        /// <param name="name">Название библиотеки</param>
        /// <param name="quantityOfBooks">Библиотечный фонд</param>
        /// <param name="phone">Номер телефона</param>
        /// <param name="address">Адрес</param>
        /// <param name="square">Площадь</param>
        /// <param name="avgNumberOfVisitors">Среднее число посетителей</param>
        /// <param name="profit">Рейтинг</param>

        public Library(string name, int quantityOfBooks, string phone, string address,
            float square, int avgNumberOfVisitors, float profit) : this(name, quantityOfBooks)
        {
            _avgNumberOfVisitors = avgNumberOfVisitors;
            _phone = phone;
            _address = address;
            _square = square;
            _rate = profit;
        }

        public string ID
        {
            get => _id;
            set => _id = value;
        }

        /// <summary>
        /// свойство для получения и изменения поля _name
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        /// <summary>
        /// свойство для получения и изменения поля _quantityOfBooks
        /// </summary>

        public int QuantityOfBooks
        {
            get => _quantityOfBooks;
            set => _quantityOfBooks = value;
        }



        /// <summary>
        /// свойство для получения и изменения поля _phone
        /// </summary>
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }
        /// <summary>
        /// свойство для получения и изменения поля _address
        /// </summary>

        public string Address
        {
            get => _address;
            set => _address = value;
        }
        /// <summary>
        /// свойство для получения и изменения поля _square
        /// </summary>

        public float Square
        {
            get => _square;
            set => _square = value;
        }

        /// <summary>
        /// свойство для получения и изменения поля _avgNumberOfVisitors
        /// </summary>
        public int AvgNumberOfVisitors
        {
            get => _avgNumberOfVisitors;
            set => _avgNumberOfVisitors = value;
        }

        /// <summary>
        /// свойство для получения и изменения поля _rate
        /// </summary>
        public float Rate
        {
            get => _rate;
            set => _rate = value;
        }


 
    }
}
    
