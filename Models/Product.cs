using System.ComponentModel.DataAnnotations;

namespace Lr8.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Назва товару обов'язкова")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Довжина назви має бути від 3 до 100 символів")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ціна обов'язкова")]
        [Range(0.01, 10000, ErrorMessage = "Ціна має бути від 0.01 до 10000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Дата створення обов'язкова")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
    }
}
