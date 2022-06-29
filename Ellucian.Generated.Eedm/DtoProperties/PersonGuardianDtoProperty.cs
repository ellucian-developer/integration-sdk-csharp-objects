// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a persons guardian.
    /// </summary>
    [DataContract]
    public class PersonGuardianDtoProperty
    {
        /// <summary>
        /// Guid of the guardian
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}