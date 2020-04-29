using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeAPI.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class ArtController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            //Anrop till fake Repo
            return "artists that spend money";
        }

    }
}
