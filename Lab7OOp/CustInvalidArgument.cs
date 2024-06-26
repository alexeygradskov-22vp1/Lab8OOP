﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7OOp
{
    class CustInvalidArgumentException : Exception
    {
        /// <summary>
        /// Свойство для вывода информации об ошибке
        /// </summary>
        public string Place { get; }
        public string Message { get; }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="place">Место</param>
        public CustInvalidArgumentException(string message, string place) : base(message)
        {
            Place = place;
            Message = message;
        }

       



    }
}
