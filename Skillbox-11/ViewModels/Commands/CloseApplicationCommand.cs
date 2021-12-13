using Skillbox_11.ViewModels.Commands.Base;
using System.Windows;

namespace Skillbox_11.ViewModels.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object parameter)=> true;

        public override void Execute(object parameter)=> Application.Current.Shutdown();
    }
}
