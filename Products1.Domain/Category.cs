using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//https://www.youtube.com/watch?v=r63TErUu6WQ&index=18&list=PLuEZQoW9bRnT5LUI1rQFwu9ujQVIVQTF3
namespace Products1.Domain
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="The field {0} is required")]
        [MaxLength(50, ErrorMessage ="The field {0} only can contain {1} characters lenght.)")]
        [Index("Category_Description_Index", IsUnique = true)]
        public string Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<Product> Products { get; set; }
    }
}
