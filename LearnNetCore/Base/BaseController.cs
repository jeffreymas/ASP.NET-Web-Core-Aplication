﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnNetCore.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnNetCore.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class
        where TRepository : IRepository<TEntity>
    {
        private IRepository<TEntity> _repo;
        
        public BaseController(TRepository repository)
        {
            this._repo = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<TEntity>> GetAll() => await _repo.GetAll();

        [HttpGet("{Id}")]
        public async Task<ActionResult<TEntity>> GetById(int Id) => await _repo.GetById(Id);

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post (TEntity entity)
        {
            var data = await _repo.Create(entity);
            if(data > 0)
            {
                return Ok("Data Created");
            }
            return BadRequest("Created Failed!");
        }

        [HttpDelete ("{Id}")]
        public async Task<ActionResult<int>> Delete (int Id)
        {
            var deleted = await _repo.Delete(Id);
            if (deleted.Equals(null))
            {
                return NotFound("Data is Not Found!");
            }
            return deleted;
        }
        //public async Task<ActionResult<int>> Update (TEntity entity)
        //{
        //    var updated = await _repo.Update(entity);
        //    return Ok();
        //}
    }
}