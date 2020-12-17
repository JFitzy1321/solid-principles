namespace ISPLibrary
{
    public interface IDVD : ILibraryItem
    {
        System.Collections.Generic.List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }
    }
}