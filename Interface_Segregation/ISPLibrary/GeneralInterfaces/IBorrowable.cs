namespace ISPLibrary
{
    public interface IBorrowable
    {
        string Borrower { get; set; }

        int CheckOutDurationInDays { get; set; }
        System.DateTime BorrowDate { get; set; }

        void CheckIn();
        void CheckOut(string borrower);
        System.DateTime GetDueDate();
    }
}