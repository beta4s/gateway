namespace b4s.Message.Model
{
    public class Message : IMessage
    {
        public string? Id { get; set; }
        public DateTime? DateTime { get; set; }
        public MessageChannel SourceChannel { get; set; }
        public MessageChannel DestinationChannel { get; set; }
        public MessageSource Source { get; set; }
        public int? CareTeamId { get; set; }
        public int PatientId { get; set; }
        public string? DestinationPhoneNumber { get; set; }
        public string? SourcePhoneNumber { get; set; }
        public string? DialogFlow { get; set; }
        public string? Text { get; set; }

    }
}