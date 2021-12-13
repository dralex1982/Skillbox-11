using System;
using System.Windows.Input;

namespace Skillbox_11.ViewModels.Commands.Base
{
    /// <summary>Класс реализующий интерфейс ICommand для создания WPF команд</summary>
    public abstract class Command : ICommand
    {
        /// <summary>Событие извещающее об имении состояния команды</summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>Вызов разрешающего метода команды</summary>
        /// <param name="parameter">Параметр команды</param>
        /// <returns>True - если выполнение команды разрешено</returns>
        public abstract bool CanExecute(object parameter);

        /// <summary>Вызов выполняющего метода команды</summary>
        /// <param name="parameter">Параметр команды</param>
        public abstract void Execute(object parameter);
    }
}
