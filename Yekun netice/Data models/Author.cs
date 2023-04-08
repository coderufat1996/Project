﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yekun_netice.Data_models
{
    public class Author : IEquatable<Author>
    {


        static int counter = 0;
        public Author()
        {
            counter++;
            this.Id = counter;
        }
        public Author(int id)
        {
            this.Id = id;
        }
        public int Id { get; private set; }
        public string Name;
        public string Surname;

        public bool Equals(Author? other)
        {
            return other?.Id == this.Id;
        }

        public override string ToString()
        {
            return $"{Id} | {Name} | {Surname} | ";
        }
    }
}
