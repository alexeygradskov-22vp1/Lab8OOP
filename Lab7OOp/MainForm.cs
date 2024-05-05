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

    public interface MainFormView {
         event EventHandler AddLibraryClicked;
         event EventHandler UpdateLibraryClicked;
        event EventHandler PrintLibrary;
         event EventHandler LibCBChanged;
         event EventHandler withoutArgsChanged;
         event EventHandler oneArgsChanged;
         event EventHandler twoArgsChanged;
         event EventHandler fourArgsChanged;
        string GetName();
        string GetQuantity();
        string GetPhone();
        string GetAddress();
        string GetSquare();
        string GetAvgNumber();
        string GetRate();
        void setName(string name);
        void SetQuantity(string quantity);
        void SetPhone(string phone);
        void SetAddress(string address);
        void SetSquare(string square);
        void SetAvgNumber(string avgNumber);
        void SetRate(string rate);
        string GetUpdName();
        string GetUpdQuantity();
        string GetUpdPhone();
        string GetUpdAddress();
        string GetUpdSquare();
        string GetUpdAvgNumber();
        string GetUpdRate();
        void setUpdName(string name);
        void SetUpdQuantity(string quantity);
        void SetUpdPhone(string phone);
        void SetUpdAddress(string address);
        void SetUpdSquare(string square);
        void SetUpdAvgNumber(string avgNumber);
        void SetUpdRate(string rate);

        void setCBItems(List<string> items);

        string selLibraryName();

        void setSelLibrary(string item);
        void showFields(int numberArgs);

        
        

        (bool, bool, bool, bool, bool, bool, bool) checkedFields();
    }

    /// <summary>
    /// Главный класс форма
    /// </summary>
    public partial class MainForm : Form, MainFormView
    {

       
        
        /// <summary>
        /// Число аргументов для создания библиотеки
        /// </summary>


        public event EventHandler AddLibraryClicked;
        public event EventHandler UpdateLibraryClicked;
        public event EventHandler PrintLibrary;
        public event EventHandler LibCBChanged;
        public event EventHandler withoutArgsChanged;
        public event EventHandler oneArgsChanged;
        public event EventHandler twoArgsChanged;
        public event EventHandler fourArgsChanged;
        private readonly LibPresenter _presenter;

        /// <summary>
        /// Конструктор
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
           
            withoutArgsRB.Select();
            selectLibCB.SelectedItem = "Не выбрано";
            AddLibBtn.Click += (sender, e) => AddLibraryClicked?.Invoke(sender, e);
            saveLibBtn.Click += (sender, e) => UpdateLibraryClicked?.Invoke(sender, e);
            printDataBtn.Click += (sender, e) => PrintLibrary?.Invoke(sender, e);
            selectLibCB.TextChanged += (sender, e) => LibCBChanged?.Invoke(sender, e);
            withoutArgsRB.CheckedChanged += (sender, e) => withoutArgsChanged?.Invoke(sender, e);
            oneArgRB.CheckedChanged += (sender, e) => oneArgsChanged?.Invoke(sender, e);
            twoArgsRb.CheckedChanged += (sender, e) => twoArgsChanged?.Invoke(sender, e);
            allArgsRB.CheckedChanged += (sender, e) => fourArgsChanged?.Invoke(sender, e);
            _presenter = new LibPresenter(this);

        }



        public void showFields(int numberArgs)
        {
            switch (numberArgs)
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


        /// <summary>
        /// Метод для обработки нажатия кнопки создания библиотеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /// <summary>
        /// Метод для обработки события обновления библиотеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        /// <summary>
        /// Метод для обработки события отображения полей библиотеки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        public string GetName()
        {
            return NameTb.Text;
        }

        public string GetQuantity()
        {
            return quantityTb.Text;
        }

        public string GetPhone()
        {
            return phoneTB.Text;
        }

        public string GetAddress()
        {
            return addressTB.Text;
        }

        public string GetSquare()
        {
            return squareTB.Text;
        }

        public string GetAvgNumber()
        {
            return avgNumberTb.Text;
        }

        public string GetRate()
        {
            return rateTB.Text;
        }

        public void setName(string name)
        {
            nameUpdTb.Text = name;
        }

        public void SetQuantity(string quantity)
        {
            quantityUpdTb.Text = quantity;
        }

        public void SetPhone(string phone)
        {
            phoneUpdTB.Text = phone;
        }

        public void SetAddress(string address)
        {
            addressUpdTB.Text = address;
        }

        public void SetSquare(string square)
        {
            squareUpdTb.Text = square;
        }

        public void SetAvgNumber(string avgNumber)
        {
            avgNumberUpdTb.Text = avgNumber;
        }

        public void SetRate(string rate)
        {
            rateUpdTB.Text = rate;
        }

        public void setCBItems(List<string> items)
        {
            selectLibCB.Items.Clear();
            foreach (string item in items)
            {
                selectLibCB.Items.Add(item);
            }
            
        }

        public string selLibraryName()
        {
            return selectLibCB.SelectedItem.ToString();
        }

        public string GetUpdName()
        {
            return nameUpdTb.Text;
        }

        public string GetUpdQuantity()
        {
            return quantityUpdTb.Text;
        }

        public string GetUpdPhone()
        {
            return phoneUpdTB.Text;
        }

        public string GetUpdAddress()
        {
            return addressUpdTB.Text;
        }

        public string GetUpdSquare()
        {
            return squareUpdTb.Text;
        }

        public string GetUpdAvgNumber()
        {
            return avgNumberUpdTb.Text;
        }

        public string GetUpdRate()
        {
            return rateUpdTB.Text;
        }

        public void setUpdName(string name)
        {
            nameUpdTb.Text = name;
        }

        public void SetUpdQuantity(string quantity)
        {
            quantityUpdTb.Text=quantity;
        }

        public void SetUpdPhone(string phone)
        {
            phoneUpdTB.Text = phone;
        }

        public void SetUpdAddress(string address)
        {
            addressUpdTB.Text=address;
        }

        public void SetUpdSquare(string square)
        {
            squareUpdTb.Text=square;
        }

        public void SetUpdAvgNumber(string avgNumber)
        {
            avgNumberUpdTb.Text=avgNumber;
        }

        public void SetUpdRate(string rate)
        {
            rateUpdTB.Text = rate;
        }

        public void setSelLibrary(string item)
        {
            selectLibCB.SelectedItem = item;
        }

        public (bool, bool, bool, bool, bool, bool, bool) checkedFields()
        {
            return (nameOutCB.Checked, quantityOutCB.Checked, 
                phoneOutCB.Checked, addressOutCB.Checked, 
                squareOutCB.Checked, avgNumberOutCB.Checked,
                rateOutCB.Checked);
        }
    }
}
