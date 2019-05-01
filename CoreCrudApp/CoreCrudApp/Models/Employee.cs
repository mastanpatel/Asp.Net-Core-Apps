using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCrudApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(200)")]
        public string FullName { get; set; }

        [Column(TypeName ="nvarchar(10)")]
        public string EmpCode { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string Position { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string OfficeLocation { get; set; }
    }
}
