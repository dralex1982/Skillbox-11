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



        #region Свойства

        public override string Name
        {
            get => base.Name;
            set => base.Name = value;
        }
        public override string Patronymic
        {
            get => base.Patronymic;
            set => base.Patronymic = value;
        }
        public override string Surname
        {
            get => base.Surname;
            set => base.Surname = value;
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
            set => base.Passport = value;
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
