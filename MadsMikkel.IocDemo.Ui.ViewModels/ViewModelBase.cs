using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MadsMikkel.IocDemo.Ui.ViewModels
{
    public interface IViewModel
    {
        void Initialize();
    }

    public abstract class ViewModelBase: IViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public abstract void Initialize();

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}