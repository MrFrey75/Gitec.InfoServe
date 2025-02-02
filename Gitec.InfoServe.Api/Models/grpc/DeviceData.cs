using Gitec.InfoServe.CommonLib.Enumerations;

public class DeviceData
    {
        public string DeviceName { get; set; } = "Unknown";
        public string SerialNumber { get; set; } = "";
        public string IpAddress { get; set; } = "0.0.0.0";
        public DeviceTypeEnum DeviceType { get; set; } = DeviceTypeEnum.UNKNOWN;
    }