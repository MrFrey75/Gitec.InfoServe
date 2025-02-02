using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gitec.InfoServe.CommonLib.Enumerations;
using Google.Protobuf.WellKnownTypes;

namespace Gitec.InfoServe.CommonLib.Models;

public class ClientActionRequestModel
{
    Timestamp _timestamp = Timestamp.FromDateTime(DateTime.Now);
    public string DeviceId { get; set; } = string.Empty;
    public ServiceTypeModel Service { get; set; } = ServiceTypeModel.UnknownService;
    public string data { get; set; } = string.Empty;


}