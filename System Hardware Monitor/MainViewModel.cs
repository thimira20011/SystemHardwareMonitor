using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

public class MainViewModel : INotifyPropertyChanged
{
    private readonly HardwareService _service;
    private string _gpuTemp;

    public string GpuTemp
    {
        get => _gpuTemp;
        set { _gpuTemp = value; OnPropertyChanged(); }
    }

    public MainViewModel()
    {
        _service = new HardwareService();

        // Timer to refresh data every 1 second
        DispatcherTimer timer = new DispatcherTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += (s, e) => UpdateStats();
        timer.Start();
    }

    private void UpdateStats()
    {
        GpuTemp = _service.GetGpuTemperature();
    }

    // Standard MVVM boilerplate
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}