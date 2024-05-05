using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7OOp
{
    public delegate void CollectionChangedHandler(string action, string key);
    /// <summary>
    /// Репозиторий
    /// </summary>
    class Repository
        {
        private int _size;
            private Dictionary<string, Library> _collection;

            public event CollectionChangedHandler CollectionChanged;
            public Repository()
            {
                _collection = new Dictionary<string, Library>();
            _size = 0;
            }

        /// <summary>
        /// Добавление
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
            public void add(string key, Library value)
            {
                _collection.Add(key, value);
                OnCollectionChanged("Added", key);
            _size++;
            }

        /// <summary>
        /// Получение одного элемента по ключу
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
            public Library getEl(string key)
            {
                return _collection[key];
            }
        
        /// <summary>
        /// Удаление по ключу
        /// </summary>
        /// <param name="key"></param>
            public void remove(string key)
            {
                if (_collection.ContainsKey(key))
                {
                    _collection.Remove(key);
                    OnCollectionChanged("Removed", key);
                _size--;
                }


            }

        /// <summary>
        /// Получение всех библиотек
        /// </summary>
        /// <returns></returns>
            public Dictionary<string, Library> getAll()
            {
                return _collection;
            }

        /// <summary>
        /// Обновление
        /// </summary>
        /// <param name="key"></param>
        /// <param name="changed"></param>
            public void changeEl(string key, Library changed)
            {
                _collection[key] = changed;
            }

            protected virtual void OnCollectionChanged(string action, string key)
            {
                CollectionChanged?.Invoke(action, key);
            }

        /// <summary>
        /// Получение списка ключей
        /// </summary>
        /// <returns></returns>
        public List<String> getKeys()
        {
            return new List<string>(_collection.Keys); ;
        }

        /// <summary>
        /// Получение размера
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return _size;
        }
        }
    }



