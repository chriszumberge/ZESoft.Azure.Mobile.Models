namespace ZESoft.Azure.Mobile.Models
{
    /// <summary>
    /// Interface for implementing an Azure Data Object with the minimum number of required fields to work
    /// with the data store classes.
    /// </summary>
    public interface IAzureDataObject
    {
        string Id { get; set; }

        byte[] Version { get; set; }

        bool Deleted { get; set; }
    }
}
