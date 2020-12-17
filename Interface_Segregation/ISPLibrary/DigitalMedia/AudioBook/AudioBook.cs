using System;

namespace ISPLibrary
{
    public class AudioBook : IBorrowableAudioBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string LibraryId { get; set; }
        public string Borrower { get; set; }
        public int CheckOutDurationInDays { get; set; } = 14;
        public int Pages { get; set; } = -1;
        public DateTime BorrowDate { get; set; }
        public int RuntimeInMinutes { get; set; }

        public void CheckIn() => Borrower = string.Empty;

        public void CheckOut(string name)
        {
            Borrower = name;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}