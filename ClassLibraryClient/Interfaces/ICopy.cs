using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillbox_11.Models
{
    /// <summary>Интерфейс для создания копии экзампляра того же типа
    /// и копирования значений в другой или из другого экзепляра</summary>
    /// <typeparam name="T"></typeparam>
    public interface ICopy<T>
    {
        /// <summary>Создание копии экземпляра</summary>
        /// <returns>Новый экземпляр в том же типе</returns>
        T Copy();
        /// <summary>Копирование значений экземпляра в другой экземпляр</summary>
        /// <param name="other">Другой экземпляр в который надо скопировать значения</param>
        void CopyTo(T other);
        /// <summary>Копирование значений экземпляра из другого экземпляра</summary>
        /// <param name="other">Другой экземпляр из которого надо скопировать значения</param>
        void CopyFrom(T other);
    }
}
