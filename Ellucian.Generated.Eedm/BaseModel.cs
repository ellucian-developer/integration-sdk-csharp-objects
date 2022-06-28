// Copyright 2014 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// This abstract class is the basis for all entities in the Higher Education Data Model
    /// </summary>
    public abstract class BaseModel
    {
        /// <summary>
        /// An object containing metadata
        /// </summary>
        [JsonProperty("metadata")]
        public MetadataObject MetadataObject { get; set; }

        /// <summary>
        /// A Globally Unique ID (GUID)
        /// </summary>
        [JsonProperty("guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Base constructor for object initialization only
        /// </summary>
        protected BaseModel()
        {
            MetadataObject = new MetadataObject();
        }
    }
}
