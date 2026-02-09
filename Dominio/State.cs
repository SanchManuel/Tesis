using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class State
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Acronimo { get; set; }
        public int CountryId { get; set; }
        public Country? country { get; set; }
        public List<StateRegulatoryDependencies>? stateRegulatoryDependencies { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}