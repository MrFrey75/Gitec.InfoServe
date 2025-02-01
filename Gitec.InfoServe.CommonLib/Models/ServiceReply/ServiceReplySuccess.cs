using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models;

   public class ServiceReplySuccess : ServiceReplyDetails
    {
        public string JsonData { get; set; } = string.Empty;

        public ServiceReplySuccess(string jsonData, string message)
            : base(jsonData, message)
        {
            JsonData = jsonData;
            Message = message;
            Status = StatusTypeModel.Success;        
        }

        

    }