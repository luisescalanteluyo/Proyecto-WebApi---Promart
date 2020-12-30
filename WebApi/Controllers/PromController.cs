using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBusiness;
using ApiEntitty;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Produces("application/json")]


    [Route("api/[controller]")]
    [ApiController]
    public class PromController : ControllerBase
    {
        [HttpGet]
        [Route("GetAllEmployees")]
        public object GetAllEmployees()
        {
            ModelResponse modeloRpta = new ModelResponse();

            //object objResult = null;

            LogicEmployees asas = new LogicEmployees();

            try {
                //objResult =  asas.GetAllEmployees();

                modeloRpta.bEstado = true;
                modeloRpta.obj = asas.GetAllEmployees();
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.sRpta = ex.ToString();
            }
         
            return modeloRpta;//    return JsonConvert.SerializeObject(objResult);
        }

        [HttpPost]
        [Route("SaveEmployees")]
        public object SaveEmployees([FromBody] employees value)
        {
            ModelResponse modeloRpta = new ModelResponse();

            LogicEmployees asas = new LogicEmployees();

            try
            {
               // objResult = asas.SaveEmployees(value);

                modeloRpta.bEstado = true;
                modeloRpta.obj = asas.SaveEmployees(value);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.sRpta = ex.ToString();
            }

            return modeloRpta;// 
        }

        [HttpPut]
        [Route("UpdateEmployees")]
        public object UpdateEmployees([FromBody] employees value)
        {
            ModelResponse modeloRpta = new ModelResponse();

            LogicEmployees asas = new LogicEmployees();

            try
            {
                // objResult = asas.SaveEmployees(value);

                modeloRpta.bEstado = true;
                modeloRpta.obj = asas.UpdateEmployees(value);
            }
            catch (Exception ex)
            {
                modeloRpta.bEstado = false;
                modeloRpta.sRpta = ex.ToString();
            }

            return modeloRpta;// 
        }





        // GET: api/Prom
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Prom/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Prom
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Prom/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
