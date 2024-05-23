using System.ComponentModel.DataAnnotations;

namespace BlazorCRUDWithAuthentication.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EmployeName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Designation { get; set; }
    }
}
