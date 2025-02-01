namespace Gitec.InfoServe.CommonLib.Models.ServiceReply
{
    public class ServiceReplyUnknown
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public ServiceReplyUnknown()
        {
            Message = string.Empty;
        }

        public ServiceReplyUnknown(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }
    }
}