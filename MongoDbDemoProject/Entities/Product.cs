﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDbDemoProject.Entities
{
	public class Product
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
