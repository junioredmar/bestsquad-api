using System;
using System.Collections.Generic;
using System.Text;
using BestSquad.Data.Model;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace BestSquad.Data.Infrastructure
{
    public class MongoContext
    {
        public IMongoDatabase Db;

        public MongoContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("BestSquadConnection"));
            Db = client.GetDatabase("bestsquad");
        }

        public IMongoCollection<Player> Players => Db.GetCollection<Player>("Player");
    }
}
