using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using LearnNetCore.Base;
using LearnNetCore.Models;
using LearnNetCore.Repositories.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;

namespace LearnNetCore.Controllers
{
    //[Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : BaseController<Departments, DepartmentsRepo>
    {
        private readonly DepartmentsRepo _repo;

        public DepartmentsController(DepartmentsRepo departmentsRepo) : base(departmentsRepo)
        {
            this._repo = departmentsRepo;
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<int>> Update (int Id, Departments entity)
        {
            var getId = await _repo.GetById(Id);
            getId.Name = entity.Name;
            var data = await _repo.Update(getId);
            if (data.Equals(null))
            {
                return BadRequest("Update Failed!");
            }
            return data;
        }
    }
}