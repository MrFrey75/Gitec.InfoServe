using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gitec.InfoServe.CommonLib.Enumerations;

namespace Gitec.InfoServe.CommonLib.Models;

public class ServiceReplyComplete : ServiceReplyDetails
{
    public CompletionTypeModel CompletionType { get; set; } = new CompletionTypeModel();

    public ServiceReplyComplete(string jsonData, string message) : base(jsonData, message)
    {
        Message = message; 
        Status = StatusTypeModel.Complete;
        CompletionType = CompletionType.Complete ?? new CompletionTypeModel();
    }

}

public class CompletionTypeModel
{
    public CompletionTypeModel? Complete { get; internal set; }
    public CompletionTypeModel? Pending { get; internal set; }
    public CompletionTypeModel? Failure { get; internal set; }
    public CompletionTypeModel? Success { get; internal set; }
    public CompletionTypeModel? None { get; internal set; }

    public CompletionTypeModel()
    {

    }
    
}

public static class CompletionType

{
    public static readonly CompletionTypeModel Complete = new CompletionTypeModel(){};
    public static readonly CompletionTypeModel Pending = new CompletionTypeModel();
    public static readonly CompletionTypeModel Failure = new CompletionTypeModel();
    public static readonly CompletionTypeModel Success = new CompletionTypeModel();
    public static readonly CompletionTypeModel None = new CompletionTypeModel();

}