﻿using System.ComponentModel.DataAnnotations;

namespace Exam_Cinema.Model
{
    public class Film
    {
        public Film()
        {
        }

        public Film(string isbn, string title, string author, EFormatType eCoverType, int publishYear)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            ECoverType = eCoverType;
            PublishYear = publishYear;
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        [Key]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public ECoverType ECoverType { get; set; }
        public int PublishYear { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int AvailableBooksInLibrary { get; set; } = 0;
        public virtual IEnumerable<LibraryBook>? LibraryBooks { get; set; }
    }
}
}
