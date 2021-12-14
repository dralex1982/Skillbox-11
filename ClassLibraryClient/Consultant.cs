using System;

namespace Skillbox_11.ClientLibrary
{
    /// <summary>Консультант</summary>
    public class Consultant : Client

    {
        public Consultant(Client client)
        {
            base.id = client.Id;
            base.surname = client.Surname;
            base.name = client.Name;
            base.patronymic = client.Patronymic;
            base.passport = client.Passport;
            base.phone = client.Phone;
        }

        /// <summary>Клиент для редактирования менеджером</summary>
        /// <param name="client">Выбранный клиент</param>
        /// <returns>Клиент для редактирования менеджером</returns>
        public Client GetForManager(this Client client)
        {
            return new Manager(this);
        }

        /// <summary>Клиент для редактирования консультантом</summary>
        /// <param name="client">Выбранный клиент</param>
        /// <returns>Клиент для редактирования консультантом</returns>
        public Client ForConsultant(this Client client)
        {
            return new GetConsultant(this);
        }

        #region Свойства

        public override string Name
        {
            get => base.Name;
            set
            {
                OnPropertyChanged(nameof(base.Name));
            }
        }
        public override string Patronymic
        {
            get => base.Patronymic;
            set { OnPropertyChanged(nameof(base.Patronymic)); }
        }
        public override string Surname
        {
            get => base.Surname;
            set { OnPropertyChanged(nameof(base.Surname)); }
        }
        public override string Passport
        {
            get
            {
                if (base.Passport != String.Empty)
                {
                    return "******************";
                }
                else return string.Empty;
            }
            set { OnPropertyChanged(nameof(base.Passport)); }
        }
        public override string Phone
        {
            get => base.Phone;
            set
            {
                if (value != String.Empty)
                {
                    base.Phone = value;
                }
                phone = base.Phone;
            }
        }

        #endregion



    }
}
