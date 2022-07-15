using Microsoft.AspNetCore.Http;
using FinalProject.Models;
using FinalProject.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MytableController : ControllerBase
    {
        private readonly IMytable _IMytable;
        public MytableController(IMytable IMytable)
        {
            _IMytable = IMytable;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mytable>>> Get()
        {
            return await Task.FromResult(_IMytable.GetMytableDetails());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Mytable>> Get(int id)
        {
            var mytable = await Task.FromResult(_IMytable.GetMytableDetails(id));
            if (mytable == null)
            {
                return NotFound();
            }
            return mytable;
        }

        [HttpPost]
        public async Task<ActionResult<Mytable>> Post(Mytable mytable)
        {
            _IMytable.AddMytable(mytable);
            return await Task.FromResult(mytable);
        }

        // PUT api/employee/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Mytable>> Put(int id, Mytable mytable)
        {
            if (id != mytable.Id)
            {
                return BadRequest();
            }
            try
            {
                _IMytable.UpdateMytable(mytable);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return await Task.FromResult(mytable);
        }

        // DELETE api/employee/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Mytable>> Delete(int id)
        {
            var mytable = _IMytable.DeleteMytable(id);
            return await Task.FromResult(mytable);
        }
        [HttpHead]
        private bool EmployeeExists(int id)
        {
            return _IMytable.CheckMytable(id);
        }
    }

}

