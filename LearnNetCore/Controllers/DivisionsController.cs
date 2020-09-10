using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnNetCore.Base;
using LearnNetCore.Models;
using LearnNetCore.Repositories.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnNetCore.Controllers
{
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionsController : BaseController<Divisions, DivisionsRepo>
    {
        private readonly DivisionsRepo _repo;

        public DivisionsController(DivisionsRepo divisionsRepo) : base(divisionsRepo)
        {
            this._repo = divisionsRepo;
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<int>> Update(int Id, Divisions divisions)
        {
            var getId = await _repo.GetById(Id);
            getId.Name = divisions.Name;
            getId.department_id = divisions.department_id;
            var data = await _repo.Update(getId);
            if (data.Equals(null))
            {
                return BadRequest("Update Failed!");
            }
            return data;
        }

    }
}