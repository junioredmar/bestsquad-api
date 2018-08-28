using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace BestSquad.Data.Model
{
    public class Player
    {
        public ObjectId _id { get; set; }

        public int BaseId { get; set; }

        public string Name { get; set; }

        public int Rating { get; set; }

        public string Nation { get; set; }

        public string Club { get; set; }

        public string League { get; set; }
    }
}
