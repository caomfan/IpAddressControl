# IpAddressControl
WPF IpAddressControl



# IpAddressControl 使用
IpAddressControl使用需要绑定IpAddressViewModel类

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition/>
            <RowDefinition/>
        </Grid.RowDefinitions>
        <control:IpAddressControl BorderThickness="1" BorderBrush="#666" Grid.Row="0" DataContext="{Binding IpAddressViewModel1, UpdateSourceTrigger=PropertyChanged, NotifyOnSourceUpdated=True}" Width="150" Height="25"/>
        <control:IpAddressControl BorderThickness="1" BorderBrush="#666" Grid.Row="1" DataContext="{Binding IpAddressViewModel2, UpdateSourceTrigger=PropertyChanged, NotifyOnSourceUpdated=True}" Width="150" Height="25"/>
    </Grid>


ViewModel：
    
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

# 运行效果
![](https://i.imgur.com/8KiElYQ.gif)
