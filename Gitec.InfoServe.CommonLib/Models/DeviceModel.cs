using System;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models;

public class DeviceModel
{
    public string DeviceName { get; set; } = "CTE000X0000";
    public DateTime FirstCheckin { get; set; } = DateTime.UtcNow;
    public string OsVersion { get; set; } = "Unknown";
    public DeviceTypeEnum DeviceType { get; set; } = DeviceTypeEnum.UNKNOWN;
    public TimeSpan SystemUptime { get; set; } = TimeSpan.Zero;
    public ArchitectureEnum Architecture { get; set; } = ArchitectureEnum.UNKNOWN;
    public string SerialNumber { get; set; } = "Unknown";
    public string Manufacturer { get; set; } = "Unknown";
    public string Model { get; set; } = "Unknown";
    public string AssetNumber { get; set; } = "Unknown";

    public DeviceModel()
    {
        DeviceName = "CTE000X0000";
        FirstCheckin = DateTime.UtcNow;
        OsVersion = "Unknown";
        DeviceType = DeviceTypeEnum.UNKNOWN;
        SystemUptime = TimeSpan.Zero;
        Architecture = ArchitectureEnum.UNKNOWN;
        SerialNumber = "Unknown";
        Manufacturer = "Unknown";
        Model = "Unknown";
        AssetNumber = "Unknown";
    }

}