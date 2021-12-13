using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Skillbox_11.ViewModels.Base
{
    /// <summary>Базовый класс с реализацией INPC </summary>
    public abstract class ViewModel : INotifyPropertyChanged
    {
        /// <summary>Событие для извещения об изменения свойства</summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>Метод для вызова события извещения об изменении свойства</summary>
        /// <param name="propertyName">Изменившееся свойство</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>Виртуальный метод определяющий изменения в значении поля значения свойства</summary>
        /// <param name="fieldProperty">Ссылка на поле значения свойства</param>
        /// <param name="newValue">Новое значение</param>
        /// <param name="propertyName">Название свойства</param>
        protected virtual bool Set<T>(ref T fieldProperty, T newValue,
            [CallerMemberName] string propertyName = null)
        {
            if (Equals(fieldProperty, newValue)) return false;
            fieldProperty = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
