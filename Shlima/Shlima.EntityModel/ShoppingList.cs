using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Common.EntityModel;

namespace Shlima.EntityModel
{
    public class ShoppingList : TimestampEntity
    {
        [Required]
        [StringLength(9)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
    }
}
