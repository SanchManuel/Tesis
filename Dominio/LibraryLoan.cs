using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class LibraryLoan
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }

        public int LibraryCopyId { get; set; }
        public LibraryCopy? LibraryCopy { get; set; }
        public int BorrowerUserId { get; set; }
        public User? BorrowerUser { get; set; }

        public DateTime LoanDateUtc { get; set; }
        public DateTime DueDateUtc { get; set; }
        public DateTime? ReturnDateUtc { get; set; }
        public string? LoanStatus { get; set; } // e.g., "On Loan", "Returned", "Overdue"
        public int RenewCount { get; set; }
        public string? Notes { get; set; }
    }
}