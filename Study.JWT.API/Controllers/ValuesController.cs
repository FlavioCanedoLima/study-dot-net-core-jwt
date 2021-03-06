﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Study.JWT.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [Authorize("Bearer")]
        public IEnumerable<string> Get()
        {
            return new [] { "value1", "value2" };
        }

        [HttpGet("Demandas")]
        [Authorize("Bearer", Roles="Desenvolvedor, Administrador")]
        public IEnumerable<string> GetDemandas()
        {
            return new [] { "value1", "value2" };
        }

        [HttpGet("PLR")]
        [Authorize("Bearer", Roles = "RH")]
        public IEnumerable<string> GetPlr()
        {
            return new[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
