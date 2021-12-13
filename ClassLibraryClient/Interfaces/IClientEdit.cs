
namespace Skillbox_11.ClientLibrary
{
    public interface IClientEdit
    {
        /// <summary>Выбранный клиент</summary>
        Client SelectedClient { get; set; }

        /// <summary>Редактируемый клиент</summary>
        Client EditClient { get; }

        /// <summary>Режим редактирования клиента</summary>
        bool IsModeEdit { get; }
    }
}
