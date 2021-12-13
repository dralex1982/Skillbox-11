using ClassLibraryClient.Interfaces;
using Skillbox_11.Models;
using System;

namespace Skillbox_11.Model
{
    /// <summary>Менеджер</summary>
    public class Manager : Client
    {
        /// <summary>Конструктор менеджера</summary>
        /// <param name="client">Клиент</param>
        public Manager(Client client)
        {
            base.id = client.Id;
            base.surname = client.Surname;
            base.name = client.Name;
            base.patronymic = client.Patronymic;
            base.passport = client.Passport;
            base.phone = client.Phone;
        }

        #region Свойства
        public override string Name
        {
            get => base.Name;
            set
            {
                base.Name = value;

            }
        }
        public override string Patronymic
        {
            get => base.Patronymic;
            set { base.Patronymic = value; }
        }
        public override string Surname
        {
            get => base.Surname;
            set { base.Surname = value; }
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
        public override string Passport
        {
            get => base.Passport;
            set => base.Passport = value;
        }

        #endregion

    }
}
