namespace b4s.MessageGateway.Models
{
    public class Message
    {

        /// <summary>
        /// Id da mensagem
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Data e hora da mensagem
        /// </summary>
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Canal de comunicação de origem da mensagem
        /// </summary>
        public MessageChannel SourceChannel { get; set; }

        /// <summary>
        /// Canal de comunicação de destino da mensagem
        /// </summary>
        public MessageChannel DestinationChannel { get; set; }

        /// <summary>
        /// Origem da mensagem
        /// </summary>
        public MessageSource Source { get; set; }

        /// <summary>
        /// Id do atentende
        /// </summary>
        public int? CareTeamId { get; set; }

        /// <summary>
        /// Id do paciente
        /// </summary>
        public int PatientId { get; set; }

        /// <summary>
        /// Numero de telefone de destino
        /// </summary>
        public string? DestinationPhoneNumber { get; set; }

        /// <summary>
        /// Numero de telefone de origem
        /// </summary>
        public string? SourcePhoneNumber { get; set; }

        /// <summary>
        /// Id do fluxo de dialogo
        /// </summary>
        public string? DialogFlow { get; set; }

        /// <summary>
        /// Texto da mensagem
        /// </summary>
        public string? Text { get; set; }

    }

    public enum MessageChannel
    {
        Rasa = 0,
        WhatsApp = 1,
        MobileApp = 2,
        WebApp = 3,
        CareApp = 4
    }

    public enum MessageSource
    {
        Rasa = 0,
        CareTeam = 1,
        CareBotFallowUp = 2,
        CareBotLongitudinal = 3,
        Patient = 4
    }

}


