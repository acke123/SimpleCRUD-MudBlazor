using System.ComponentModel.DataAnnotations;

namespace SimpleCRUD.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }

        public string EmployeeIdView {
            get
            {
                return "EMP" + EmployeeId.ToString().PadLeft(4, '0');
            }

        }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
