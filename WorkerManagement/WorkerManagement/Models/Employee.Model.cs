using System.ComponentModel.DataAnnotations;

namespace WorkerManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id  { get; set;}
        public string Name { get; set;}
        public string LastName { get; set;}
        public string Occupation { get; set;}
      
        public DateTime StartDate { get; set; } = DateTime.Now;
    }
}
