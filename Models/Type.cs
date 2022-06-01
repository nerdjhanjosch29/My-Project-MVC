using System;
using System.ComponentModel.DataAnnotations;

namespace woww.Models
{
    public class Type
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public Item Item { get; set; }
        public int ItemId { get; set; }
    }
}
