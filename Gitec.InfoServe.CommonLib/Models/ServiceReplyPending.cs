using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitec.InfoServe.CommonLib.Models;

public class ServiceReplyPending : ServiceReplyDetails
{
    public string State { get; set; } = string.Empty;
}