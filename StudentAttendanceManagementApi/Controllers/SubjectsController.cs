using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagementApi.Contracts;
using StudentAttendanceManagementApi.Models;

namespace StudentAttendanceManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private ISubjectService _subjectService;

        public SubjectsController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Subject>> Get()
        {
            return Ok(_subjectService.GetSubjects());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return NotImplentedException();
        }

        private ActionResult<string> NotImplentedException()
        {
            throw new NotImplementedException();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
