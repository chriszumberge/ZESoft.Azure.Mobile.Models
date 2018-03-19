using Newtonsoft.Json;
using System;

namespace ZESoft.Azure.Mobile.Models
{
    /// <summary>
    /// Base Data Object class with all the required properties for an Azure Data Object.
    /// </summary>
    /// <see cref="ZESoft.Azure.Mobile.Models.IAzureDataObject"/>
    public abstract class BaseAzureDataObject : IAzureDataObject
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [Microsoft.WindowsAzure.MobileServices.Version]
        public byte[] Version { get; set; }

        [Microsoft.WindowsAzure.MobileServices.CreatedAt]
        public DateTimeOffset CreatedAt { get; set; }

        [Microsoft.WindowsAzure.MobileServices.UpdatedAt]
        public DateTimeOffset UpdatedAt { get; set; }

        [Microsoft.WindowsAzure.MobileServices.Deleted]
        public bool Deleted { get; set; }
    }
}
