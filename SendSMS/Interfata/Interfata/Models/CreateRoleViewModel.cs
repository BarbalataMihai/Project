using System.ComponentModel.DataAnnotations;

namespace Interfata.Models
{
    public class CreateRoleViewModel
    {
        [Key]
        [Required]
        public string RoleName { get; set; }
    }
}
