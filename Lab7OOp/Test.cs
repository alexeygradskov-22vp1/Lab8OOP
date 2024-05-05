using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7OOp
{
    /// <summary>
    /// Форма замера работы коллекций
    /// </summary>
    public partial class Test : Form
    {
        
        Repository repository;
        List<Library> libraries;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Test()
        {
            InitializeComponent();
            libraries = new List<Library>();
            repository = new Repository();
            show();
        }

        /// <summary>
        /// Заполнение списков для замера
        /// </summary>
        /// <returns></returns>
        private (int, int) fillLists()
        {
            int timeRepo = 0, timeList = 0;
            int start = Environment.TickCount;

            int n = 100000;
            for (int i = 0; i < n; i++)
            {

                repository.add(i.ToString(), new Library( $"Библиотека {i + 1}")); ;
            }
            timeRepo = Environment.TickCount - start;
            for (int i = 0; i < n; i++)
            {
                libraries.Add(new Library( $"Библиотека {i + 1}")); ;
            }
            timeList = Environment.TickCount - start;
            return (timeRepo, timeList);
        }

        /// <summary>
        /// Замер случайной выборки из списка
        /// </summary>
        /// <returns></returns>
        private (int, int) randomSelect()
        {
            int timeRepo = 0, timeList = 0;
            int start = Environment.TickCount;
            Random rnd = new Random();
            int value = 0;
            int n = 100000;
            Library lib;
            for (int i = 0; i < n; i++)
            {
                value = rnd.Next(0, n);
                repository.getEl(value.ToString());

            }
            timeRepo = Environment.TickCount - start;
            for (int i = 0; i < n; i++)
            {
                value = rnd.Next(0, n);
                lib = libraries[value];


            }
            timeList = Environment.TickCount - start;
            return (timeRepo, timeList);
        }

        /// <summary>
        /// Замер последовательной выборки
        /// </summary>
        /// <returns></returns>
        private (int, int) seqSelect()
        {
            int timeRepo = 0, timeList = 0;
            int start = Environment.TickCount;
            Random rnd = new Random();
            int n = 100000;
            Library lib;
            for (int i = 0; i < n; i++)
            {
                repository.getEl(i.ToString());

            }
            timeRepo = Environment.TickCount - start;
            for (int i = 0; i < n; i++)
            {
                lib = libraries[i];
            }
            timeList = Environment.TickCount - start;
            return (timeRepo, timeList);
        }

        /// <summary>
        /// Отображение результатов
        /// </summary>
        private void show()
        {
            listViewTests.View = View.Details;
            var (timeRepo, timeList) = fillLists();
            var (timeSeqRepo, timeSeqList) = seqSelect();
            var (timeRndRepo, timeRndList) = randomSelect();
            listViewTests.Columns.Add("Вид коллекции", -2, HorizontalAlignment.Left);
            listViewTests.Columns.Add("Заполнение", -2, HorizontalAlignment.Left);
            listViewTests.Columns.Add("Случайная выборка", -2, HorizontalAlignment.Left);
            listViewTests.Columns.Add("Последовательная выборка", -2, HorizontalAlignment.Left);
            var listViewItem = new ListViewItem(new[] { "Словарь(Dictionary)", timeRepo.ToString(), timeRndRepo.ToString(), timeSeqRepo.ToString() });
            listViewTests.Items.Add(listViewItem);
            listViewItem = new ListViewItem(new[] { "Список(List)", timeList.ToString(), timeRndList.ToString(), timeSeqList.ToString() });
            listViewTests.Items.Add(listViewItem);
            this.Controls.Add(listViewTests);
        }
    }
}
