using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class StateRegulatoryDependencies
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public State? state { get; set; }
        public string? Description { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}