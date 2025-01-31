using System;
using System.Net;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models.ServiceTypes;

public class NetworkModel : ServiceTypeBase
{
    public IPAddress IpAddress { get; set; } = IPAddress.None;
    public bool IsStatic { get; set; } = false;
    public string MacAddress { get; set; } = string.Empty;
    public IPAddress DefaultGateway { get; set; } = IPAddress.None;
    public double NetworkSpeed { get; set; } = 0.0; // Mbps

    public NetworkModel()
    {
        ServiceType = ServiceTypeModel.Network;
    }
}