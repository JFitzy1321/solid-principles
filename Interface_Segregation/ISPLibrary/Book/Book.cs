using System;

namespace ISPLibrary
{
    public class Book : IBorrowableBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string LibraryId { get; set; }
        public string Borrower { get; set; }
        public int Pages { get; set; }
        public int CheckOutDurationInDays { get; set; } = 14;
        public DateTime BorrowDate { get; set; }

        public void CheckIn() => Borrower = string.Empty;

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueDate() => BorrowDate.AddDays(CheckOutDurationInDays);
    }
}