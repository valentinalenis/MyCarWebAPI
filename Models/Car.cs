﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyCarWebAPI.Models
{
    public class Car
    {
        [BsonId]
        public ObjectId id { get; set; }

        public string Consecutivo { get; set; }

        public float Value { get; set; }
       
        public string Details { get; set; }
      
        public float Trm { get; set; }
    }
}
