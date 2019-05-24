using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApplication.DB.Models
{
    public class EmployeeDbModel
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("surname")]
        public string Surname { get; set; }

        [Column("patronomyc")]
        public string Patronomyc { get; set; }

        [Column("bithrday")]
        public int Birthday { get; set; }

        [Column("position")]
        public string Position { get; set; }
    }
}
