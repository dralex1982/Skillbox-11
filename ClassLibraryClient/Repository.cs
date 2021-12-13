using Newtonsoft.Json;
using Skillbox_11.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_11.Model
{
    /// <summary>Репозиторий клиентов</summary>
    public class Repository
    {
        #region Поля
        /// <summary>Список клиентов</summary>
        private protected ObservableCollection<Client> clients;

        /// <summary>Путь к файлу с клиентами</summary>
        private protected string path;

        /// <summary>Индекс клиента</summary>
        private protected int index;

        #endregion

        /// <summary>Список клиентов</summary>
        public ObservableCollection<Client> Clients
        { get { return clients; } }

        /// <summary>Индексатор</summary>
        /// <param name="index">номер Id</param>
        /// <returns>Клиент</returns>
        public Client this[int index]
        {
            get { return clients[index]; }
            set { clients[index] = value; }
        }

        /// <summary>Конструтор</summary>
        /// <param name="path">Путь к списку клиентов</param>
        public Repository(string path)
        {
            if (File.Exists(path) && new FileInfo(path).Length != 0)
            {
                this.path = path;
                this.Load();
            }
            else
            {
                File.Create(path);

                this.index = 0;
                this.clients = new ObservableCollection<Client>();
            }
           
        }

        #region Методы сериализации-десериализации
        /// <summary>Метод сериализации списка клиентов</summary>
        public void Save(string path)
        {
            string json = JsonConvert.SerializeObject(this.clients);
            File.WriteAllText(path, json);
        }
        /// <summary>Метод сериализации списка клиентов</summary>
        public void Save() => Save(this.path);

        /// <summary>Метод десериализации списка клиентов</summary>
        private void Load(string path)
        {
                string json = File.ReadAllText(path);
                clients = JsonConvert.DeserializeObject<ObservableCollection<Client>>(json);
        }

        public void Load() => Load(this.path);
        #endregion

    }
}

