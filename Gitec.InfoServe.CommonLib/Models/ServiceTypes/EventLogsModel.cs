using System;
using System.Collections.Generic;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models.ServiceTypes;
public class EventLogsModel : ServiceTypeBase
{
    public List<DateTime> UserLoginHistory { get; set; } = [];
    public List<DateTime> FailedLoginAttempts { get; set; } = [];
    public bool FirewallEnabled { get; set; } = false;
    public bool AntivirusEnabled { get; set; } = false;
    public bool WindowsDefenderEnabled { get; set; } = false;

    public EventLogsModel()
    {
        ServiceType = ServiceTypeModel.EventLogs;
    }
}