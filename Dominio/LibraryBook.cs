using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Dominio
{
    public class LibraryBook
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public School? School { get; set; }

        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Isbn10 { get; set; }
        public string? Isbn13 { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public int PublisherYear { get; set; }

        public string? Format { get; set; }
        public string? Language { get; set; }
        public string? Category { get; set; }
        public string? TagsCsv { get; set; }

        public string? CoverUrl { get; set; }
        public string? Description { get; set; }
        public ICollection<LibraryCopy>? Copies { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }

    }
}