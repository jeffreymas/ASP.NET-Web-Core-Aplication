﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearnNetCore.Models
{
    [Table("tb_m_user")]
    public class User:IdentityUser
    {
        public ICollection<RoleUser> userRoles { get; set; }
        public Employees Employees { get; set; }
    }
}
