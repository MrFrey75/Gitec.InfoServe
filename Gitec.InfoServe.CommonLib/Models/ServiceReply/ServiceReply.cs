using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using DevExpress.Xpo.Helpers;
using Gitec.InfoServe.CommonLib.Enumerations;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Gitec.InfoServe.CommonLib.Models.ServiceReply;

public class ServiceReply
{
    public string Message { get; set; }
    public StatusTypeModel Status { get; set; }
    public string JsonData { get; set; }

    public ServiceReply()
    {
        Message = string.Empty;
        JsonData = string.Empty;
    }

    public ServiceReply(StatusTypeModel status, string message)
    {
        Message = message;
        Status = status;
        string jsonData = string.Empty;

        JsonData = status switch
        {
            StatusTypeModel.Pending => JsonConvert.SerializeObject(new ServiceReplyPending(PendingReasonEnum.Unknown, "Pending")),
            StatusTypeModel.Complete => JsonConvert.SerializeObject(new ServiceReplyComplete(jsonData, "Complete")),
            StatusTypeModel.Success => JsonConvert.SerializeObject(new ServiceReplySuccess(jsonData, "Success")),
            StatusTypeModel.Failure => JsonConvert.SerializeObject(new ServiceReplyFailure(jsonData, "Failure")),
            StatusTypeModel.UnknownStatus => JsonConvert.SerializeObject(new ServiceReplyUnknown(0, "UnknownStatus")),
            _ => throw new NotImplementedException()

        };
    }
}