using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity.User
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100), Column("name", TypeName = "varchar"), Required]
        public string name { get; set; }
        [MaxLength(255), Column("email", TypeName = "varchar"), Required]
        public string email { get; set; }
        [MaxLength(50), Column("password", TypeName = "varchar")]
        public string password { get; set; }
        [MaxLength(20), Column("phone", TypeName = "varchar")]
        public string phone { get; set; }
        public int created_by { get; set; }
        public int updated_by { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int active { get; set; }
        public int del_flag { get; set; }
    }
}
