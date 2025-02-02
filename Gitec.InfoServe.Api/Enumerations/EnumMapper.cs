using Gitec.InfoServe.CommonLib;
using Gitec.InfoServe.CommonLib.Enumerations;
using Gitec.InfoServe.Api.Services;
using Gitec.InfoServe.Api.SystemHealthData;

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
                StatusTypeModel.Success => StatusType.Success,
                _ => StatusType.Failure
            };

        /// <summary>
        /// Converts StatusType (gRPC Enum) to StatusTypeModel (C# Enum).
        /// </summary>
        public static StatusTypeModel ToModelStatus(StatusType grpc) =>
            grpc switch
            {
                StatusType.Success => StatusTypeModel.Success,
                _ => StatusTypeModel.Failure
            };

        /// <summary>
        /// Converts ServiceTypeModel (C# Enum) to ServiceType (gRPC Enum).
        /// </summary>
        public static ServiceType ToGrpcServiceType(ServiceTypeModel model) =>
            model switch
            {
                ServiceTypeModel.Hardware => ServiceType.Hardware,
                ServiceTypeModel.Applications => ServiceType.Applications,
                ServiceTypeModel.EventLogs => ServiceType.EventLogs,
                ServiceTypeModel.Network => ServiceType.Network,
                ServiceTypeModel.PowerPerformance => ServiceType.PowerPerformance,
                ServiceTypeModel.Processes => ServiceType.Processes,
                ServiceTypeModel.SecurityLogs => ServiceType.SecurityLogs,
                ServiceTypeModel.Storage => ServiceType.Storage,
                _ => ServiceType.Unknown
            };

        /// <summary>
        /// Converts ServiceType (gRPC Enum) to ServiceTypeModel (C# Enum).
        /// </summary>
        public static ServiceTypeModel ToModelServiceType(ServiceType grpc) =>
            grpc switch
            {
                ServiceType.Hardware => ServiceTypeModel.Hardware,
                ServiceType.Applications => ServiceTypeModel.Applications,
                ServiceType.EventLogs => ServiceTypeModel.EventLogs,
                ServiceType.Network => ServiceTypeModel.Network,
                ServiceType.PowerPerformance => ServiceTypeModel.PowerPerformance,
                ServiceType.Processes => ServiceTypeModel.Processes,
                ServiceType.SecurityLogs => ServiceTypeModel.SecurityLogs,
                ServiceType.Storage => ServiceTypeModel.Storage,
                _ => ServiceTypeModel.UnknownService
            };
    }
}
