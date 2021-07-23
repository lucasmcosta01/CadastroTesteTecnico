using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.Domain.Entities
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool Ative { get; set; }

        [ForeignKey("ClienttId")]
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
    }
}
