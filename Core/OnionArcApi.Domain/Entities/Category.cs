﻿using OnionArcApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcApi.Domain.Entities
{
    
    public class Category:EntityBase,IEntityBase
    {
        public Category() 
        {

        }
        public Category(int parentId,string name,int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }
        public required int ParentId { get; set; }  
        public required string Name { get; set; }    
        public required int Priorty { get; set; }
        public ICollection<Detail> Details { get; set;} //1 to many ilişki

        public ICollection<Product> Products { get; set; } //many to many çok ilişki.

    }
}
