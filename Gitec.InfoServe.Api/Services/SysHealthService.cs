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
            case ServiceType.Hardware:

                json = JsonConverter<Hardware>
                break;
            case ServiceType.Applications:
                json = "{ \"applications\": { \"app1\": \"App1\", \"app2\": \"App2\" } }";
                break;
            case ServiceType.Network:
                json = JsonSer


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