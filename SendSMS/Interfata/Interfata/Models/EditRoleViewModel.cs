using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interfata.Models
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }

        [Required (ErrorMessage ="Role Name is required")]
        public string RoleName { get; set; }
        [NotMapped]
        public List<string> Users { get; set; }
    }
}
