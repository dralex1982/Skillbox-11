using Skillbox_11.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_11.Models
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
