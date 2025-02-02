using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models;

public class ServiceReplyFailure : ServiceReplyDetails
{

    public string ErrorMessage { get; set; }
    public string ErrorDetails { get; set; }
    public string ErrorStackTrace { get; set; }
    public string ErrorCategory { get; set; }

    public ServiceReplyFailure(string message, string details)
        : base(message, details)
    {
        Status = StatusTypeModel.Failure;
        ErrorMessage = message;
        ErrorDetails = details;
        ErrorCategory = string.Empty; // or provide a default value
        ErrorStackTrace = string.Empty; // or provide a default value
    }
}