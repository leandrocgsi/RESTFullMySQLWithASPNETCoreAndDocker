using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace RESTFullMySQLWithASPNETCoreAndDocker.Model.Base
{
    // Contrato entre atributos
    // e a estrutura da tabela
    // [DataContract]
    public class BaseEntity
    {
        [Column("id")]
        public long? Id { get; set; }
    }
}
