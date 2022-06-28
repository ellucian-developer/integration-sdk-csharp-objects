// Copyright 2014 Ellucian Company L.P. and its affiliates
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A Metadata container
    /// </summary>
    [DataContract]
    public class MetadataObject
    {
        /// <summary>
        /// The name of the originator of the data.
        /// </summary>
        [JsonConverter(typeof(DataOriginConverter))]
        [DataMember(Name = "dataOrigin")]
        public string DataOrigin { get; set; }

        /// <summary>
        /// MetadataObject constructor
        /// </summary>
        public MetadataObject()
        {
            // set the data origin to empty so it can be assigned when serialized
            DataOrigin = string.Empty;
        }
    }
}