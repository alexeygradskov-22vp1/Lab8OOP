using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Text;

namespace Lab7OOp
{
    class LibPresenter
    {
        private MainFormView _view;
        private LibraryService _libraryService;
        static Repository repository = new Repository();
        Library _selectedLib = null;
        int numbArgs = 0;
        public LibPresenter(MainFormView view)
        {
           
            _view = view;
            _view.showFields(0);
            _libraryService = new LibraryService(repository);
            _view.withoutArgsChanged += (sender, e) => withoutArgs();
            _view.oneArgsChanged += (sender, e) => oneArg();
            _view.twoArgsChanged += (sender, e) => twoArgs();
            _view.fourArgsChanged += (sender, e) => allArgs();

            _view.AddLibraryClicked += (sender, e) => AddLibrary();
            _view.UpdateLibraryClicked += (sender, e) => UpdateLibrary();
            _view.PrintLibrary += (sender, e) => printData();
            _view.LibCBChanged += (sender, e) => libCBChanged();

        }

        private void libCBChanged()
        {
            _selectedLib = _libraryService.GetLibrary(_view.selLibraryName());
            updateFields();
        }


        private void withoutArgs()
        {
            _view.showFields(0);
            numbArgs = 0;
        }

        private void oneArg()
        {
            _view.showFields(1);
            numbArgs = 1;
        }

        private void twoArgs()
        {
            _view.showFields(2);
            numbArgs = 2;
        }

        private void allArgs()
        {
            _view.showFields(4);
            numbArgs = 4;
        }

        public void updateFields()
        {
            _view.setUpdName(_selectedLib.Name);
           _view.SetUpdQuantity(_selectedLib.QuantityOfBooks.ToString());
            _view.SetUpdPhone(_selectedLib.Phone);
            _view.SetUpdAddress(_selectedLib.Address);
            _view.SetUpdSquare(_selectedLib.Square.ToString());
            _view.SetUpdAvgNumber(_selectedLib.AvgNumberOfVisitors.ToString());
            _view.SetUpdRate(_selectedLib.Rate.ToString());

        }

        private void AddLibrary()
        {
            try
            {
                if (_libraryService.getKeys().Contains(_view.GetName()))
                {
                    MessageBox.Show("Библиотека с таким именем уже существует");
                    return;
                }
                string message = "Успешно";
                switch (numbArgs)
                {
                    case 0:
                        _libraryService.insertNewLibrary(numbArgs);
                        break;
                    case 1:
                        _libraryService.insertNewLibrary(numbArgs,_view.GetName());
                        break;
                    case 2:
                        _libraryService.insertNewLibrary(numbArgs, _view.GetName(), _view.GetQuantity());
                        break;
                    case 4:
                        _libraryService.insertNewLibrary(numbArgs, _view.GetName(), _view.GetQuantity(),
                            _view.GetPhone(), _view.GetAddress(), _view.GetSquare(),
                            _view.GetAvgNumber(), _view.GetRate());
                        break;
                }
                updateList();
                MessageBox.Show(message);
            }
            catch(CustInvalidArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void UpdateLibrary()
        {
            try
            {
                if (_selectedLib == null) { MessageBox.Show("Объект не выбран"); return; }
                _libraryService.update(_view.selLibraryName(),
                    _view.GetUpdName(), _view.GetUpdQuantity(),
                                _view.GetUpdPhone(), _view.GetUpdAddress(), _view.GetUpdSquare(),
                                _view.GetUpdAvgNumber(), _view.GetUpdRate());


                updateList();
                _selectedLib = _libraryService.GetLibrary(_view.GetUpdName());
                updateFields();
                _view.setSelLibrary(_view.GetUpdName());
                MessageBox.Show("Успешно");
            }catch(CustInvalidArgumentException e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void printData() {
            if (_selectedLib == null) { MessageBox.Show("Объект не выбран"); return; }

            string result = fetchData();
            MessageBox.Show(result.Equals("") ? "Выберите поля для вывода" : result);
        }
        private void updateList()
        {
            _view.setCBItems( _libraryService.getKeys());
           
        }

        private string fetchData()
        {
            StringBuilder result = new StringBuilder("");
            bool name, quantity, phone, address, square, avgNumber, rate;
            (name,quantity,phone, address, square, avgNumber, rate)= _view.checkedFields();

            if (name)
            {
                result.AppendLine($"Название: {_selectedLib.Name}");
            }
            if (quantity)
            {
                result.AppendLine($"Библиотечный фонд: {_selectedLib.QuantityOfBooks.ToString()}");

            }
            if (phone)
            {
                result.AppendLine($"Номер телефона: {_selectedLib.Phone}");
            }
            if (address)
            {
                result.AppendLine($"Адрес: {_selectedLib.Address}");
            }
            if (square)
            {
                result.AppendLine($"Площадь: {_selectedLib.Square.ToString()}");
            }
            if (avgNumber)
            {
                result.AppendLine($"Среднее число посетителей: {_selectedLib.AvgNumberOfVisitors.ToString()}");
            }
            if (rate)
            {
                result.AppendLine($"Рейтинг: {_selectedLib.Rate.ToString()}");
            }
            return result.ToString();

        }


    }
}
