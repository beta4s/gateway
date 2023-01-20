using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4s.Message.Model
{
    public interface IMessage
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

}
