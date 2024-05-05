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
    /// Главный класс форма
    /// </summary>
    public partial class MainForm : Form
    {

        /// <summary>
        /// Контроллер
        /// </summary>
        LibController controller;

        /// <summary>
        /// Выбранная библиотека
        /// </summary>
        private Library _selectedLib=null;
        
        /// <summary>
        /// Число аргументов для создания библиотеки
        /// </summary>
        private int numbArgs = 0;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            controller = new LibController();
            withoutArgsRB.Select();
            selectLibCB.SelectedItem = "Не выбрано";
            
        }

   

        private void withoutArgsRB_CheckedChanged(object sender, EventArgs e)
        {
            showFields(0);
            numbArgs = 0;
        }
       
        /// <summary>
        /// Метод для отображения полей
        /// </summary>
        /// <param name="numberArgs">Число аргументов</param> 
        private void showFields(int numberArgs)
        {
            switch(numberArgs)
            {
                case 0:
                    NameTb.Visible = false;
                    quantityTb.Visible = false;
                    phoneTB.Visible = false;
                    addressTB.Visible = false;
                    squareTB.Visible = false;
                    avgNumberTb.Visible = false;
                    rateTB.Visible = false;
                     nameLb.Visible = false;
                     QuantLb.Visible = false;
                     phoneLb.Visible = false;
                     addressLb.Visible = false;
                     squareLb.Visible = false;
                     avgNumbLb.Visible = false;
                    rateLb.Visible = false;
                    break;
                case 1:
                    NameTb.Visible = true;
                    quantityTb.Visible = false;
                    phoneTB.Visible = false;
                    addressTB.Visible = false;
                    squareTB.Visible = false;
                    avgNumberTb.Visible = false;
                    rateTB.Visible = false;
                    nameLb.Visible = true;
                    QuantLb.Visible = false;
                    phoneLb.Visible = false;
                    addressLb.Visible = false;
                    squareLb.Visible = false;
                    avgNumbLb.Visible = false;
                    rateLb.Visible = false;
                    break;
                case 2:
                    NameTb.Visible = true;
                    quantityTb.Visible = true;
                    phoneTB.Visible = false;
                    addressTB.Visible = false;
                    squareTB.Visible = false;
                    avgNumberTb.Visible = false;
                    rateTB.Visible = false;
                    nameLb.Visible = true;
                    QuantLb.Visible = true;
                    phoneLb.Visible = false;
                    addressLb.Visible = false;
                    squareLb.Visible = false;
                    avgNumbLb.Visible = false;
                    rateLb.Visible = false;
                    break;
                case 4:
                    NameTb.Visible = true;
                    quantityTb.Visible = true;
                    phoneTB.Visible = true;
                    addressTB.Visible = true;
                    squareTB.Visible = true;
                    avgNumberTb.Visible = true;
                    rateTB.Visible = true;
                    nameLb.Visible = true;
                    QuantLb.Visible = true;
                    phoneLb.Visible = true;
                    addressLb.Visible = true;
                    squareLb.Visible = true;
                    avgNumbLb.Visible = true;
                    rateLb.Visible = true;
                    break;
            }
        }

        private void oneArgRB_CheckedChanged(object sender, EventArgs e)
        {
            showFields(1);
            numbArgs = 1;
        }

        private void twoArgsRb_CheckedChanged(object sender, EventArgs e)
        {
            showFields(2);
            numbArgs = 2;
        }

        private void allArgsRB_CheckedChanged(object sender, EventArgs e)
        {
            showFields(4);
            numbArgs = 4;
        }

        /// <summary>
        /// Обновление полей при выборе библиотеки
        /// </summary>
        private void updateFields()
        {
            nameUpdTb.Text = _selectedLib.Name;
            quantityUpdTb.Text = _selectedLib.QuantityOfBooks.ToString();
            phoneUpdTB.Text = _selectedLib.Phone;
            addressUpdTB.Text = _selectedLib.Address;
            squareUpdTb.Text = _selectedLib.Square.ToString();
            avgNumberUpdTb.Text= _selectedLib.AvgNumberOfVisitors.ToString();
            rateUpdTB.Text = _selectedLib.Rate.ToString();

        }

        /// <summary>
        /// Обновление списка в комбо боксе
        /// </summary>
        private void updateList()
        {
            selectLibCB.Items.Clear();
            List<String> libNames = controller.getLibNames();
            foreach (String libName in libNames)
            {
                selectLibCB.Items.Add(libName);
            }
        }

        private void selectLibCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedLib = controller.GetLibrary(selectLibCB.SelectedItem.ToString());
            updateFields();
        }

        /// <summary>
        /// Метод для обработки нажатия кнопки создания библиотеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLibBtn_Click(object sender, EventArgs e)
        {
            if (controller.getLibNames().Contains(NameTb.Text))
            {
                MessageBox.Show("Библиотека с таким именем уже существует");
                return;
            }
            string message="";
            switch (numbArgs)
            {
                case 0:
                    message = controller.add(numbArgs);
                    break;
                case 1:
                    message = controller.add(numbArgs, NameTb.Text);
                    break;
                case 2:
                    message = controller.add(numbArgs, NameTb.Text, quantityTb.Text);
                    break;
                case 4:
                    message = controller.add(numbArgs, NameTb.Text, quantityTb.Text,
                        phoneTB.Text, addressTB.Text, squareTB.Text,
                        avgNumberTb.Text, rateTB.Text);
                    break;
            }
            updateList();
            MessageBox.Show(message);
        }

        /// <summary>
        /// Метод для обработки события обновления библиотеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveLibBtn_Click(object sender, EventArgs e)
        {
            if (_selectedLib == null) { MessageBox.Show("Объект не выбран"); return; }
            string updStatus = controller.update(selectLibCB.SelectedItem.ToString(),
                nameUpdTb.Text, quantityUpdTb.Text,
                        phoneUpdTB.Text, addressUpdTB.Text, squareUpdTb.Text,
                        avgNumberUpdTb.Text, rateUpdTB.Text);
            MessageBox.Show(updStatus);
            if (updStatus.Equals("Успешно"))
            {
                updateList();
                _selectedLib = controller.GetLibrary(nameUpdTb.Text);
                updateFields();
                selectLibCB.SelectedItem = _selectedLib.Name;
            }
        }

        /// <summary>
        /// Метод для обработки события отображения полей библиотеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDataBtn_Click(object sender, EventArgs e)
        {
            if (_selectedLib == null) { MessageBox.Show("Объект не выбран"); return; }

            string result  = fetchData();
            MessageBox.Show(result.Equals("")?"Выберите поля для вывода":result);
        }

        /// <summary>
        /// Метод для создания строки вывода полей
        /// </summary>
        /// <returns></returns>
        private string fetchData()
        {
            StringBuilder result = new StringBuilder("");
         
            if (nameOutCB.Checked)
            {
                result.AppendLine($"Название: {_selectedLib.Name}");
            }
            if (quantityOutCB.Checked)
            {
                result.AppendLine($"Библиотечный фонд: {_selectedLib.QuantityOfBooks.ToString()}");
                
            }
            if (phoneOutCB.Checked)
            {
                result.AppendLine($"Номер телефона: {_selectedLib.Phone}");
            }
            if (addressOutCB.Checked)
            {
                result.AppendLine($"Адрес: {_selectedLib.Address}");
            }
            if (squareOutCB.Checked)
            {
                result.AppendLine($"Площадь: {_selectedLib.Square.ToString()}");
            }
            if (avgNumberOutCB.Checked)
            {
                result.AppendLine($"Среднее число посетителей: {_selectedLib.AvgNumberOfVisitors.ToString()}");
            }
            if (rateOutCB.Checked)
            {
                result.AppendLine($"Рейтинг: {_selectedLib.Rate.ToString()}");
            }
            return result.ToString();

        }

        /// <summary>
        /// Метод для обработки события отображения формы замера результатов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculate_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.ShowDialog();
        }
    }
}
