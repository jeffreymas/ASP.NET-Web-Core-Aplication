using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnNetCore.Context;
using LearnNetCore.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearnNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChartsController : ControllerBase
    {
        private readonly MyContext _context;
        public ChartsController(MyContext myContext)
        {
            _context = myContext;
        }
        // GET api/values
        [HttpGet]
        [Route("pie")]
        public async Task<List<PieChartVM>> GetPie()
        {

            var data1 = await _context.Divisions.Include("Departments")
                            .Where(x => x.isDelete == false)
                            .GroupBy(q => q.Departments.Name)
                            .Select(q => new PieChartVM
                            {
                                DepartmentName = q.Key,
                                total = q.Count()
                            }).ToListAsync();
            return data1;
        }
    }
}