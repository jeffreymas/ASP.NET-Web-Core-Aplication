using LearnNetCore.Context;
using LearnNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnNetCore.Repositories.Data
{
    public class DepartmentsRepo : GeneralRepository<Departments, MyContext>
    {
        public DepartmentsRepo(MyContext context) : base(context)
        {

        }
    }
}
