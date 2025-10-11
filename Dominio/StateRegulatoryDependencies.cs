using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class StateRegulatoryDependencies
    {
        public int id { get; set; }
        public int state_id { get; set; }
        public string? description { get; set; }
        public DateTime? updated_at { get; set; }
        public DateTime? created_at { get; set; }
    }
}