using Skillbox_11.MVVMLibrary;

namespace Skillbox_11.ClientLibrary
{
    /// <summary>Клиент</summary>
    public class Client
    {

        #region Поля
        /// <summary>Id</summary>
        private protected int id;

        /// <summary>Фамилия</summary>
        private protected string surname;

        /// <summary>Имя</summary>
        private protected string name;

        /// <summary>Отчество</summary>
        private protected string patronymic;

        /// <summary>Номер телефона</summary>
        private protected string phone;

        /// <summary>Серия, номер паспорта</summary>
        private protected string passport;
        #endregion

        #region Cвойства

        /// <summary>Id</summary>
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>Фамилия</summary>
        public virtual string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        /// <summary>Имя</summary>
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>Отчество</summary>
        public virtual string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        /// <summary>Номер телефона</summary>
        public virtual string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        /// <summary>Серия, номер паспорта</summary>
        public virtual string Passport
        {
            get { return passport; }
            set { passport = value; }
        }

        #endregion

        #region Конструкторы
        /// <summary>Конструктор</summary>
        /// <param name="surname">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="patronymic">Отчество</param>
        /// <param name="phohe">Номер телефона</param>
        /// <param name="passport">Серия, номер паспорта</param>
        public Client(string surname, string name, string patronymic, string phohe, string passport)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Phone = phohe;
            Passport = passport;
        }

        public Client (Client client)
        {
            this.Id = client.Id;
            this.Surname = client.Surname;
            this.Name = client.Name;
            this.Patronymic = client.Patronymic;
            this.Phone = client.Phone;
            this.Passport = client.Passport;
        }

        public Client()
        {

        }
        #endregion

        /// <summary>Клиент для редактирования/просмотра менеджером</summary>
        /// <returns>Клиент для менеджера</returns>
        public Client GetForManager()
        {
            return new Manager(this);
        }

        /// <summary>Клиент для редактирования/просмотра консультантом</summary>
        /// <returns>Клиент для консультанта</returns>
        public Client GetForConsultant()
        {
            return new Consultant(this);
        }
    }
}

