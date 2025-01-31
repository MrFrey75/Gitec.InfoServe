using System;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models.ServiceTypes;

public class StorageModel : ServiceTypeBase
{
    public StorageDeviceTypeEnum StorageType { get; set; } = StorageDeviceTypeEnum.UNKNOWN;
    public ulong StorageSize { get; set; } = 0; // Bytes
    public double StorageUtilization { get; set; } = 0.0; // Percentage (0-100)
    public double StorageSpeed { get; set; } = 0.0; // MB/s
    public StorageHealthStatusEnum StorageHealth { get; set; } = StorageHealthStatusEnum.UNKNOWN;
    public string StorageName { get; set; } = string.Empty;
    public char? DriveLetter { get; set; } = null; // Nullable for unlettered volumes
    public FileTypeSystemEnum FileTypeSystem { get; set; } = FileTypeSystemEnum.UNKNOWN;

    public StorageModel()
    {
        ServiceType = ServiceTypeModel.Storage;
    }
}