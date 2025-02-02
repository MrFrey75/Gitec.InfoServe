using Google.Protobuf.WellKnownTypes;

public class HeartbeatPing
    {
        public Timestamp Timestamp { get; set; } = Timestamp.FromDateTime(DateTime.UtcNow);
        public DeviceData DeviceData { get; set; } = new DeviceData();
    }