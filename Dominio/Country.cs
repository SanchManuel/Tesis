using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Country
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? acronimo { get; set; }
        public List<State>? states { get; set; }
        public DateTime? created_at { get; set; }
    }
}