# System Hardware Monitor

A lightweight Windows desktop application built with WPF that provides real-time monitoring of your system's hardware metrics. Currently focused on GPU temperature monitoring with a clean, modern UI.

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=.net)
![WPF](https://img.shields.io/badge/WPF-Windows-blue)
![License](https://img.shields.io/badge/license-MIT-green)

## Features

- **Real-Time GPU Temperature Monitoring**: Displays current NVIDIA GPU temperature with live updates every second
- **Minimalist UI**: Clean, dark-themed interface designed for at-a-glance monitoring
- **Lightweight**: Minimal resource usage while running in the background
- **Hardware Integration**: Uses LibreHardwareMonitor for accurate hardware metrics

## Screenshots

The application displays GPU temperature in a centered, easy-to-read format with a dark theme:

```
┌─────────────────────────┐
│   GPU TEMPERATURE       │
│                         │
│       75.3°C           │
│                         │
└─────────────────────────┘
```

## Prerequisites

Before running this application, ensure you have:

- **Operating System**: Windows 10 or later
- **.NET Runtime**: .NET 10.0 SDK or runtime
- **Hardware**: NVIDIA GPU (for temperature monitoring)
- **Permissions**: Administrator privileges (required for hardware access)

## Installation

### Option 1: Build from Source

1. **Clone the repository**:
   ```bash
   git clone https://github.com/thimira20011/SystemHardwareMonitor.git
   cd SystemHardwareMonitor
   ```

2. **Open the solution**:
   - Open `System Hardware Monitor.slnx` in Visual Studio 2022 or later
   - Or use the command line with .NET CLI

3. **Restore NuGet packages**:
   ```bash
   dotnet restore "System Hardware Monitor/System Hardware Monitor.csproj"
   ```

4. **Build the project**:
   ```bash
   dotnet build "System Hardware Monitor/System Hardware Monitor.csproj" --configuration Release
   ```

5. **Run the application**:
   ```bash
   dotnet run --project "System Hardware Monitor/System Hardware Monitor.csproj"
   ```

### Option 2: Run Pre-built Binary

If a pre-built release is available, download the latest release from the [Releases](https://github.com/thimira20011/SystemHardwareMonitor/releases) page and extract the files to a folder. Run `System Hardware Monitor.exe` with administrator privileges.

## Usage

1. **Launch the application** with administrator privileges (required for hardware sensor access)
2. The main window will display the current GPU temperature
3. The temperature updates automatically every second
4. Keep the application running to monitor your GPU temperature in real-time

> **Note**: The application requires administrator privileges to access hardware sensors. Right-click the executable and select "Run as administrator" if needed.

## Technology Stack

- **Framework**: .NET 10.0
- **UI Framework**: Windows Presentation Foundation (WPF)
- **Architecture Pattern**: Model-View-ViewModel (MVVM)
- **Hardware Monitoring**: [LibreHardwareMonitorLib](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor) v0.9.4

## Project Structure

```
SystemHardwareMonitor/
├── System Hardware Monitor/
│   ├── App.xaml                    # Application definition
│   ├── App.xaml.cs                 # Application code-behind
│   ├── MainWindow.xaml             # Main window UI definition
│   ├── MainWindow.xaml.cs          # Main window code-behind
│   ├── MainViewModel.cs            # ViewModel for UI data binding
│   ├── HardwareService.cs          # Hardware monitoring service
│   ├── AssemblyInfo.cs             # Assembly information
│   ├── app.manifest                # Application manifest
│   └── System Hardware Monitor.csproj  # Project file
├── System Hardware Monitor.slnx    # Solution file
└── README.md                       # This file
```

### Key Components

- **MainWindow.xaml**: Defines the user interface with a dark theme and centered temperature display
- **MainViewModel.cs**: Implements INotifyPropertyChanged for data binding and updates the UI every second
- **HardwareService.cs**: Interfaces with LibreHardwareMonitor to retrieve GPU temperature data
- **App.xaml**: Application-level configuration and resources

## Future Enhancements

Potential features for future development:

- [ ] CPU temperature and usage monitoring
- [ ] RAM usage statistics
- [ ] Support for AMD GPUs
- [ ] Multiple sensor display options
- [ ] System tray integration
- [ ] Temperature alerts and notifications
- [ ] Historical data graphs
- [ ] Export data to CSV/JSON
- [ ] Customizable refresh intervals
- [ ] Multi-GPU support

## Troubleshooting

### Application shows "N/A" instead of temperature

- Ensure you're running the application as administrator
- Verify you have an NVIDIA GPU installed
- Check that the GPU drivers are up to date
- Try restarting the application

### Application won't start

- Verify .NET 10.0 runtime is installed
- Check Windows Event Viewer for error details
- Ensure no antivirus software is blocking the application

## Contributing

Contributions are welcome! If you'd like to contribute:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is open source and available under the [MIT License](LICENSE).

## Acknowledgments

- [LibreHardwareMonitor](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor) - For providing the hardware monitoring capabilities
- Built with [.NET](https://dotnet.microsoft.com/) and [WPF](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/)

## Contact

Project Link: [https://github.com/thimira20011/SystemHardwareMonitor](https://github.com/thimira20011/SystemHardwareMonitor)

---

**Note**: This application requires administrator privileges to access hardware sensors. Always download and run software from trusted sources.
