using LibreHardwareMonitor.Hardware;

public class HardwareService
{
    private Computer _computer;

    public HardwareService()
    {
        _computer = new Computer
        {
            IsCpuEnabled = true,
            IsGpuEnabled = true, // Crucial for your NVIDIA stats
            IsMemoryEnabled = true
        };
        _computer.Open();
    }

    public string GetGpuTemperature()
    {
        // Iterate through hardware to find the GPU
        foreach (var hardware in _computer.Hardware)
        {
            if (hardware.HardwareType == HardwareType.GpuNvidia)
            {
                hardware.Update(); // Refresh the sensor data
                foreach (var sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        return $"{sensor.Value:F1}°C";
                    }
                }
            }
        }
        return "N/A";
    }

    public void Close()
    {
        _computer.Close();
    }
}