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
    
    [RoutePrefix("api/Hospitalapi")]
    public class HospitalApiController : ApiController
    {
        // GET api/<controller>
        HospitalRepository ur = new HospitalRepository();
        // GET: api/Useraip
        [Route("GetHospital")]
        [ResponseType(typeof(HospitalModel))]
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