using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gitec.InfoServe.CommonLib;
using Gitec.InfoServe.CommonLib.Enumerations;
using Microsoft.Graph.Models;

namespace Gitec.InfoServe.CommonLib.Enumerations
{
    public static class EnumMapper
    {
        /// <summary>
        /// Converts StatusTypeModel (C# Enum) to StatusType (gRPC Enum).
        /// </summary>
        public static StatusType ToGrpcStatus(StatusTypeModel model) =>
            model switch
            {
                StatusTypeModel.Pending => StatusType.Pending,
                StatusTypeModel.Success => StatusType.Success,
                StatusTypeModel.Failure => StatusType.Failure,
                _ => StatusType.UnknownStatus
            };

        /// <summary>
        /// Converts StatusType (gRPC Enum) to StatusTypeModel (C# Enum).
        /// </summary>
        public static StatusTypeModel ToModelStatus(StatusType grpc) =>
            grpc switch
            {
                StatusType.Pending => StatusTypeModel.Pending,
                StatusType.Success => StatusTypeModel.Success,
                StatusType.Failure => StatusTypeModel.Failure,
                _ => StatusTypeModel.UnknownStatus
            };






        public static ServiceType ToGrpcServiceType(ServiceTypeModel model) =>
            model switch
            {
                ServiceTypeModel.Hardware => ServiceType.Hardware,
                ServiceTypeModel.Applications => ServiceType.Applications,
                ServiceTypeModel.Network => ServiceType.Network,
                ServiceTypeModel.PowerPerformance => ServiceType.PowerPerformance,
                ServiceTypeModel.Processes => ServiceType.Processes,
                ServiceTypeModel.SecurityLogs => ServiceType.SecurityLogs,
                ServiceTypeModel.Storage => ServiceType.Storage,
                    

                _ => ServiceType.UnknownService
            };

        public static ServiceTypeModel ToModelServiceType(ServiceType grpc) =>
        grpc switch
        {
            ServiceType.Hardware => ServiceTypeModel.Hardware,
            ServiceType.Applications => ServiceTypeModel.Applications,
            ServiceType.Network => ServiceTypeModel.Network,
            ServiceType.PowerPerformance => ServiceTypeModel.PowerPerformance,
            ServiceType.Processes => ServiceTypeModel.Processes,
            ServiceType.SecurityLogs => ServiceTypeModel.SecurityLogs,
            ServiceType.Storage => ServiceTypeModel.Storage,
            _ => ServiceTypeModel.UnknownService
        };

    }
}
