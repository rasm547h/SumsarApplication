﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsarApplication.Model
{
    public class Service
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Service(string name, string desc)
        {
            Name = name;
            Description = desc;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}";
        }
    }
}
