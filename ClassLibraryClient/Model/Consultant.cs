using ClassLibraryClient.Interfaces;
using Skillbox_11.Models;
using System;

namespace Skillbox_11.Model
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
