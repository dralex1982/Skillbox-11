using Skillbox_11.Model;
using Skillbox_11.Models;
using Skillbox_11.ViewModels.Base;
using Skillbox_11.ViewModels.Commands;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Skillbox_11.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        private string _title = "Банк А";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
        #endregion

        #region Команды

        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion

        #region AddClientCommand
        public ICommand AddClientCommand { get; }

        private bool CanAddClientCommand(object p)
        {
            if (User == UserType.Consultant)
            {
                return false;
            }
            return true;
        }
        private void OnAddClientCommand(object p)
        {
            Client client = new Client();
            Repository.Clients.Add(client);
            SelectedClient = client;
        }
        #endregion

        #region SaveDateClient
        public ICommand SaveDateClient { get; }
        private bool CanSaveDateClient(object p)
        {
            if (SelectedClient != null)
            {
                return true;
            }
            return false;
        }
        private void OnSaveDateClient(object p)
        {
            Client client = Repository.Clients[SelectedClient.Id];
            client.Surname = _selectedClient.Surname;
            client.Name = SelectedClient.Name;
            client.Patronymic = SelectedClient.Patronymic;
            client.Phone = SelectedClient.Phone;
            client.Passport = SelectedClient.Passport;
        }

        #endregion  

        #endregion

        #region Enum UserType - тип пользователя
        /// <summary>Перечисление типов пользователей</summary>
        public enum UserType
        {
            [Description("Консультант")]
            Consultant,
            [Description("Менеджер")]
            Manager,
        }

        /// <summary>Список-перечисление пользователей</summary>
        readonly EnumListItemCollection<UserType> users = new EnumListItemCollection<UserType>();

        /// <summary>Тип пользователя</summary>
        UserType userType;

        /// <summary>Список-перечисление пользователей</summary>
        public EnumListItemCollection<UserType> Users
        {
            get => users;
        }

        /// <summary>Тип пользователя</summary>
        public UserType User
        {
            get => userType;
            set => Set(ref userType, value);
        }

        #endregion

        #region SelectedClient : Client - выбранный клиент

        /// <summary>ВЫбранный клиент</summary>
        private Client _selectedClient;

        /// <summary>ВЫбранный клиент</summary>
        public Client SelectedClient
        {
            get
            {
                if (_selectedClient == null)
                {
                    _selectedClient = new Client();
                }
                switch (User)
                {
                    case UserType.Consultant:
                        _selectedClient = new Consultant(_selectedClient);
                        break;
                    case UserType.Manager:
                        _selectedClient = new Manager(_selectedClient);
                        break;
                    default:
                        break;
                }
                return _selectedClient;

            }
            set => Set(ref _selectedClient, value);
        }
        #endregion

        public Repository Repository
        {
            get;
        }

        public MainWindowViewModel()
        {
            /// <summary>Создание репозитория клиентов</summary>
            Repository = new Repository("Clients");

            #region Команды
            CloseApplicationCommand = new RelayCommands(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            AddClientCommand = new RelayCommands(OnAddClientCommand, CanAddClientCommand);
            SaveDateClient = new RelayCommands(OnSaveDateClient, CanSaveDateClient);
            #endregion        
        }
    }
}
