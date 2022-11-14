using GW_SimpleMVVMTemplate.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Markup;

namespace GW_SimpleMVVMTemplate.ViewModels
{
    /// <summary>
    /// A Simple MVVM Template Created by GuanWei,Su. 2022/11/14
    /// </summary>
    public class MainWindowViewModel : ViewModelBase, IDisposable
    {
        public MainWindowViewModel()
        {
        }
        #region Properties
        private string _HelloString = string.Empty;
        public string HelloString { get { return _HelloString; } set { _HelloString = value; NotifyPropertyChanged(); } }
        #endregion
        #region ViewLoaded
        public ICommand ViewLoaded { get { return new RelayCommand(param => ViewLoadedExecute(), param => true); } }
        private void ViewLoadedExecute()
        {
        }
        #endregion
        #region ViewModelDispose
        public void Dispose()
        {
        }
        #endregion
        #region HelloButtonClick
        public ICommand HelloButtonClick { get { return new RelayCommand(param => HelloButtonClickExecute(), param => true); } }
        private void HelloButtonClickExecute()
        {
            if (string.IsNullOrEmpty(HelloString))
            {
                HelloString = "Hello My Friend!";
            }
            else
            {
                HelloString = string.Empty;
            }

            //App.Current.Dispatcher.Invoke((Action)delegate
            //{
            //    HelloString = string.Empty;
            //});
        }
        #endregion
    }
}
