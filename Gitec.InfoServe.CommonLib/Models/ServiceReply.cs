using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo.Helpers;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models;

public class ServiceReply
{
    public DateTime TimeStamp { get; set; } = DateTime.Now;
    public StatusTypeModel Status { get; set; }
    public ServiceReplyDetails Details { get; set; }

    public ServiceReply(string jsonData)
    {


        switch (Status)
        {
            case StatusTypeModel.Pending:
                Details = new ServiceReplyPending(){
                    State = "Pending"
                };
                break;
            case StatusTypeModel.Success:
                Details = new ServiceReplySuccess()
                {
                    JsonData = jsonData
                };

                break;
            case StatusTypeModel.Failure:
                Details = new ServiceReplyFailure()
                {
                    ErrorMessage = "Error",
                    StackTrace = "Error"
                };

                break;
            default:
                Details = new ServiceReplyFailure()
                {
                    ErrorMessage = "StatusType us not known or unrecognized",
                    StackTrace = "StatusType us not known or unrecognized"
                };
                break;
        }

    }
}