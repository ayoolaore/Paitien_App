using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Patient_App.Contracts;
using Contracts;
using Entities.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Patient_App.Controllers
{
    [Route("api/patient")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public PatientController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
         
        }

        [HttpGet]
        public IActionResult GetAllPatients()
        {
            try
            {
                 var patients = _repository.Patient.GetAllPatients();
                _logger.LogInfo($"Returned all patients from database.");

                return Ok(patients);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllPatients action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        /*[HttpGet("{id}")]
        public IActionResult GetPatientById(Guid id)
        {
            try
            {
                var patient = _repository.Patient.GetPatientbById(id);

                if (patient == null)
                {
                    _logger.LogError($"Owner with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned owner with id: {id}");
                    return Ok(patient);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetPatientById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }*/

        // GET: api/<controller>
        /* [HttpGet]
         public IEnumerable<string> Get()
         {
             return new string[] { "value1", "value2" };
         }

         // GET api/<controller>/5
         [HttpGet("{id}")]
         public string Get(int id)
         {
             return "value";
         }

         // POST api/<controller>
         [HttpPost]
         public void Post([FromBody]string value)
         {
         }

         // PUT api/<controller>/5
         [HttpPut("{id}")]
         public void Put(int id, [FromBody]string value)
         {
         }

         // DELETE api/<controller>/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
