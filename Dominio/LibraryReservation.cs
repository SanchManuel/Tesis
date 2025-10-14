using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class LibraryReservation
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }

        public int LibraryBookId { get; set; }
        public LibraryBook? LibraryBook { get; set; }

        public int RequesterUserId { get; set; }
        public User? RequesterUser { get; set; }

        public string? RequesterName { get; set; }
        public DateTime RequestedAtUtc { get; set; }

        public bool Fulfilled { get; set; }
        public DateTime? FulfilledAtUtc { get; set; }

        public bool Cancelled { get; set; }

        public DateTime? CancelledAtUtc { get; set; }
    }
}