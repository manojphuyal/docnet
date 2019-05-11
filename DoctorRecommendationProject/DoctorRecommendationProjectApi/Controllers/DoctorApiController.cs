using DoctorRecommendationProject.Models;
using DoctorRecommendationProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DoctorRecommendationProject.Controllers
{
    [RoutePrefix("api/Doctorapi")]
    public class DoctorApiController : ApiController
    {
        // GET api/<controller>
        DoctorRepository ur = new DoctorRepository();
        // GET: api/Useraip
        [Route("GetDoctor")]
        [ResponseType(typeof(DoctorModel))]
        public IHttpActionResult Get()
        {
            var list = ur.List();
            return Ok(list);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}