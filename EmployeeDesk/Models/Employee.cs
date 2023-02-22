using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeDesk.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(14)")]
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }
        public long Salary { get; set; }
    }
}
