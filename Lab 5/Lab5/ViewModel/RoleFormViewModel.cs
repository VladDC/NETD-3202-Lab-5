using System.ComponentModel.DataAnnotations;

namespace Lab5.ViewModel
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}