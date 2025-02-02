
using Google.Protobuf.WellKnownTypes;
using Gitec.InfoServe.Api.Enumerations.grpc;

public class ClientHealthData
    {
        public DeviceData DeviceData { get; set; } = new DeviceData();
        public Timestamp Timestamp { get; set; } = Timestamp.FromDateTime(DateTime.UtcNow);
        public string JsonPayload { get; set; } = "{}";
    }