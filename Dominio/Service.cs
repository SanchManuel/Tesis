using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Service
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
    }
}