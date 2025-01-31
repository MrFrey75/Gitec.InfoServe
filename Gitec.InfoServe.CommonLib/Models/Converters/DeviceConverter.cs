using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo; // Ensure DevExpress.Xpo is included for UnitOfWork
using Gitec.InfoServe.CommonLib.Data;

namespace Gitec.InfoServe.CommonLib.Models.Converters;

public static class DeviceConverter
{
    /// <summary>
    /// Converts a Device entity to a DeviceModel.
    /// </summary>
    public static DeviceModel ToDeviceModel(this Device device)
    {
        return new DeviceModel
        {
            DeviceName = device.DeviceName,
            FirstCheckin = device.FirstCheckin
        };
    }

    /// <summary>
    /// Converts a DeviceModel to a Device entity using UnitOfWork.
    /// </summary>
    public static Device ToDevice(this DeviceModel deviceModel, UnitOfWork unitOfWork)
    {
        return new Device(unitOfWork)
        {
            DeviceName = deviceModel.DeviceName,
            FirstCheckin = deviceModel.FirstCheckin
        };
    }
}