using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WineApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Vinyards")]
    public class VinyardsController : Controller
    {
        // GET: api/Vinyards
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Rodney Strong", "Cooper's Hawk", "Rutherford", "Lynfred", "Kirkand Singature" };
        }

       
        
    }
}
