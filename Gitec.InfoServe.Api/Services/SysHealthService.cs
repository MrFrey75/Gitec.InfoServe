using System.Diagnostics;
using Azure;
using Gitec.InfoServe.CommonLib;
using Gitec.InfoServe.CommonLib.Data;
using Gitec.InfoServe.CommonLib.Models;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Newtonsoft.Json;
using ServiceReply = Gitec.InfoServe.CommonLib.ServiceReply;
using ServiceReplyFailure = Gitec.InfoServe.CommonLib.ServiceReplyFailure;
using ServiceType = Gitec.InfoServe.CommonLib.ServiceType;
using StatusTypeModel = Gitec.InfoServe.CommonLib.Enumerations.StatusTypeModel;

using JsonTool;
using Gitec.InfoServe.CommonLib.JsonTool;
namespace Gitec.InfoServe.Api.Services;

public class SysHealthService : SysDataService.SysDataServiceBase
{
    public override Task<ServiceReply> SysDataClientServe(ClientActionRequest request, ServerCallContext context)
    {
        Console.WriteLine($"Received Health Check from {request.Client}");
        Console.WriteLine($"Service: {request.Service} | Details: {request.Details}");

        var json = "";

        switch(request.Service)
        {
            case ServiceType.HealthCheck:
                json = JsonTools.ToJson(new HealthCheckModel
                {
                    Status = StatusTypeModel.Success,
                    Message = "Health Check Successful",
                    Details = request.Details
                });
                break;
            case ServiceType.HealthCheckFailure:
                json = JsonTools.ToJson(new HealthCheckModel
                {
                    Status = StatusTypeModel.Failure,
                    Message = "Health Check Failed",
                    Details = request.Details
                });
                break;
            default:
                json = JsonTools.ToJson(new HealthCheckModel
                {
                    Status = StatusTypeModel.Failure,
                    Message = "Service Not Found",
                    Details = request.Details
                });
                break;

        }

        var response = new ServiceReply()
        {
            Timestamp = Timestamp.FromDateTime(DateTime.Now),
            Status = StatusType.Success
        };

        try
        {
            response.Success = new ServiceReplySucces()
            {
                Jsondata = json
            };
        }
        catch (Exception ex)
        {
            response.Failure = new ServiceReplyFailure()
            {
                Message = ex.Message,
                Stacktrace = ex.StackTrace
            };

        }
        return Task.FromResult(response);
    }
}