using LearnNetCore.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnNetCore.Models
{
    [Table ("tb_m_departments")]
    public class Departments : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset DeleteDate { get; set; }
        public DateTimeOffset updateDate { get; set; }
        public bool isDelete { get; set; }
    }
}
