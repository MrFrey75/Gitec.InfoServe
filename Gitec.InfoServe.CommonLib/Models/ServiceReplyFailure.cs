using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitec.InfoServe.CommonLib.Models;

public class ServiceReplyFailure : ServiceReplyDetails
{
    public string ErrorMessage { get; set; } = string.Empty;
    public string StackTrace { get; set; } = string.Empty;
}