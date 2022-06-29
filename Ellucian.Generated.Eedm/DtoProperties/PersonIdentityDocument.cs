// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Converters;

using Newtonsoft.Json;

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The person's government issued identity document.
    /// </summary>
    [DataContract]
    public class PersonIdentityDocument
    {
        /// <summary>
        /// The ISO 639-3 alpha-3 languague code
        /// </summary>
        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PersonIdentityDocumentCountryDtoProperty Country { get; set; }

        /// <summary>
        /// Identity Document Type.
        /// </summary>
        [JsonProperty("type")]
        public PersonIdentityDocumentType Type { get; set; }

        /// <summary>
        /// Identity Document number or ID
        /// </summary>
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Date the document expires.
        /// </summary>
        [JsonConverter(typeof(DateOnlyConverter))]
        [JsonProperty("expiresOn", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? ExpiresOn { get; set; }
    }
}