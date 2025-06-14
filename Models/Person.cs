using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models;

[Table("Person")]
public class Person
{
    [Key]
    public string? PersonId { get; set; }
    public string? FullName { get; set; }
    public string? Address { get; set; }
    public string? Shape { get; set; }
}