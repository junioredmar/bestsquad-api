using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestSquad.Data.Infrastructure;
using BestSquad.Data.Model;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BestSquad.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private MongoContext _context;

        public ValuesController(MongoContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var players = _context.Players;
            var filter = Builders<Player>.Filter.Eq("Name", "edmar");
            var player = players.Find(filter).FirstOrDefault();

            return new ObjectResult(player);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var players = _context.Players;
            // use async instead
            players.InsertOne(new Player
            {
                BaseId = 1001,
                Name = "edmar",
                Rating = 90,
                Nation = "Brazil",
                Club = "Spurs",
                League = "Premier League"
            });

            
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
