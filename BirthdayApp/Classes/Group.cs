﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Classes
{
    public class Group
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}
