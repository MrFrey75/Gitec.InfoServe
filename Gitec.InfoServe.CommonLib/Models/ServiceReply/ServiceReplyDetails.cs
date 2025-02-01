using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models;

public class ServiceReplyDetails
{
    public string Details { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public StatusTypeModel Status { get; set; } = StatusTypeModel.Pending;
    public DateTime Timestamp { get; set; } = DateTime.Now;

    public ServiceReplyDetails(string message, string details)
    {
        Message = message;
        Details = details;
    }
}