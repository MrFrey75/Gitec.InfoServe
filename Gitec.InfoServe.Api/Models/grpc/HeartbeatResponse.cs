using Google.Protobuf.WellKnownTypes;

public class HeartbeatResponse
{
        public Timestamp Timestamp { get; set; } = Timestamp.FromDateTime(DateTime.UtcNow);
        public string Message { get; set; } = "Success";
        public string JsonPayload { get; set; } = "{}";
}