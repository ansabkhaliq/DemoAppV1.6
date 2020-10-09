using DemoAppV1._6.MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppV1._6.ViewModel
{
    internal class ViewModelBase : Observable
    {
        private static readonly ObservableCollection<MenuItem> AppMenu = new ObservableCollection<MenuItem>();

        public ViewModelBase()
        {
        }

        public ObservableCollection<MenuItem> Menu => AppMenu;

      
    }
}
