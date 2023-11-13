using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testApi41P.ModelBase
{
    [Table ("users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column ("nameUser")]
        public string nameUser { get; set; }
        public int Age { get; set; }
    }
}
