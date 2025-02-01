using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models;

public class ServiceReplyPending : ServiceReplyDetails
{
    public PendingReasonEnum PendingReason { get; set; } = PendingReasonEnum.Unknown;

    public ServiceReplyPending(PendingReasonEnum pendingReason,
                               string message)
        : base(message, string.Empty) // Assuming the second parameter can be an empty string
    {
        PendingReason = pendingReason;
        Status = StatusTypeModel.Pending;    
    }


    
}