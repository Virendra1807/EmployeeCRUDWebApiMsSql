using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;

namespace EmployeeWebAPI.Models
{
    public class EmployeeAPI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        public required string? EmployeeName { get; set; }
        public string? Department { get; set; }
        
        [Required]
        public string Designation { get; set; }
    }

}
