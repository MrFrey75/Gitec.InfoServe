using System;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models.ServiceTypes;

public class PowerPerformanceModel : ServiceTypeBase
{
    public PowerPlanTypeEnum PowerPlan { get; set; } = PowerPlanTypeEnum.UNKNOWN;
    public TimeSpan SleepTimer { get; set; } = TimeSpan.Zero;
    public double CpuTemp { get; set; } = 0.0; // Temperature in Celsius

    public PowerPerformanceModel()
    {
        ServiceType = ServiceTypeModel.PowerPerformance;
    }
}