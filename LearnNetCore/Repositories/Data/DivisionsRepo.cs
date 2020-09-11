using LearnNetCore.Context;
using LearnNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnNetCore.Repositories.Data
{
    public class DivisionsRepo : GeneralRepository<Divisions, MyContext>
    {
        MyContext _context;
        public DivisionsRepo(MyContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<List<Divisions>> GetAll()
        {

            var data = await _context.Divisions.Include("Departments").Where(x => x.isDelete == false).ToListAsync();
            return data;
        }
    }
}
