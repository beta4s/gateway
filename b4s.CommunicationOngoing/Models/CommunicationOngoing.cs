using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace b4s.CommunicationOngoing.Models
{
    public class CommunicationOngoing
    {

        [Column(TypeName = "BINARY(16)")]
        [Key]
        public byte[] Id { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime DateTime { get; set; }

        [Column(TypeName = "SMALLINT")]
        public int Chanel { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string PatientId { get; set; }

        [Column(TypeName = "INT")]
        public int? CareTeamId { get; set; }

    }
}
