using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace A4S.ERP.Domain.Entidades
{
    public class EntityBase
    {
        [Key]
        public short Id { get; set; }
    }
}
