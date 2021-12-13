using Skillbox_11.ClientLibrary;

namespace ClientLibrary
{
    internal interface IClientVew
    {
        /// <summary>Выбранный клиент</summary>
        Client SelectedClient { get; set; }

        /// <summary>Режим просмотра клиента</summary>
        bool IsModeView { get; set; }

    }
}
