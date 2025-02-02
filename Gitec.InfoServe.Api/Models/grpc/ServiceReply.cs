using Gitec.InfoServe.CommonLib.Enumerations;
using Google.Protobuf.WellKnownTypes;

public class ServiceReply
{
    public Timestamp Timestamp { get; set; } = Timestamp.FromDateTime(DateTime.UtcNow);
    public DeviceTypeEnum ServiceType { get; set; } = DeviceTypeEnum.UNKNOWN;
    public ServiceReplySuccess? Success { get; set; } = null;
    public ServiceReplyFailure? Failure { get; set; } = null;
}

public class ServiceReplySuccess
{
    public string Message { get; set; } = "Success";
    public string JsonPayload { get; set; } = "{}";
}

public class ServiceReplyFailure
{
    public string Message { get; set; } = "Failure";
    public string ErrorData { get; set; } = "{}";
}