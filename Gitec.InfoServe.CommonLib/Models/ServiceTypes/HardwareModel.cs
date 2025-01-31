using System;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models.ServiceTypes;

public class HardwareModel : ServiceTypeBase
{
    public string CpuModel { get; set; } = string.Empty;
    public double CpuUtilization { get; set; } = 0.0; // Percentage (0 - 100)
    public ulong MemoryTotal { get; set; } = 0; // Bytes (Can be converted to GB)
    public double RamUtilization { get; set; } = 0.0; // Percentage (0 - 100)

    public HardwareModel()
    {
        ServiceType = ServiceTypeModel.Hardware;
    }
}