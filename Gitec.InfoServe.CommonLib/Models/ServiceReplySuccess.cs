using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitec.InfoServe.CommonLib.Models;

public class ServiceReplySuccess : ServiceReplyDetails
{
    public string JsonData { get; set; } = string.Empty;
}