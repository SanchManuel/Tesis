using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class State
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? acronimo { get; set; }
        public int country_id { get; set; }
        public Country? country { get; set; }
        public List<StateRegulatoryDependencies>? stateRegulatoryDependencies { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? created_at { get; set; }
    }
}