using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models;

[Table("Employee")]
public class Employee : Person {
    [Key]
    public string? EmployeeId { get; set; }
    public int Age {get; set;}
}