using LearnNetCore.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnNetCore.Models
{
    [Table("tb_m_divisions")]
    public class Divisions : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int department_id { get; set; }

        [ForeignKey("department_id")]
        public Departments Departments { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public DateTimeOffset updateDate { get; set; }
        public bool isDelete { get; set; }
    }
}
