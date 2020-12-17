namespace LSPLibrary
{
    public interface IManaged
    {
        IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);
    }
}
