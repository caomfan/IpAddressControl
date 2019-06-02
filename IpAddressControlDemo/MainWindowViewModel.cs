using IpAddressControl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpAddressControlDemo
{
    public class MainWindowViewModel : BaseViewModel
    {

        private IpAddressViewModel _IpAddressViewModel1;

        public IpAddressViewModel IpAddressViewModel1
        {
            get { return _IpAddressViewModel1; }
            set
            {
                _IpAddressViewModel1 = value;
                OnPropertyChanged();
            }
        }

        private IpAddressViewModel _IpAddressViewModel2;

        public IpAddressViewModel IpAddressViewModel2
        {
            get { return _IpAddressViewModel2; }
            set
            {
                _IpAddressViewModel2 = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            IpAddressViewModel1 = new IpAddressViewModel();
            IpAddressViewModel2 = new IpAddressViewModel();
        }
    }
}
