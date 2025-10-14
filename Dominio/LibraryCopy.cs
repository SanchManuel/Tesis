using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class LibraryCopy
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }

        public int LibraryBookId { get; set; }
        public LibraryBook? LibraryBook { get; set; }

        public string? InventoryCode { get; set; }
        public string? ShelfLocation { get; set; }
        public string? CopyStatus { get; set; }
        public decimal? ReplacementCost { get; set; }

        public ICollection<LibraryLoan>? Loans { get; set; }
        public ICollection<LibraryReservation>? Reservations { get; set; }

    }
}