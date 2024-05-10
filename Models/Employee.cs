using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("employee")]
    public class Employee
    {
        [Column("employeeid")]
        public Guid employeeId { get; set; }

        [Column("firstname")]
        public string firstName { get; set; }

        [Column("lastname")]
        public string lastName { get; set; }

        [Column("age")]
        public int age { get; set; }

        [Column("domain")]
        public string domain { get; set; }
    }
}
