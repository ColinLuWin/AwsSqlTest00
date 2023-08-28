using System;
using System.ComponentModel.DataAnnotations;

namespace SqlTest00.Db.Entities
{
    public class Student
    {
        [Key]
        public int UID { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
