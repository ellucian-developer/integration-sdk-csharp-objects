// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Visas issued to a person.
    /// </summary>
    [DataContract]
    public class PersonVisas_V11_0 : BaseModel2
    {
        /// <summary>
        /// The person to whom the visa was issued.
        /// </summary>
        [DataMember(Name = "person")]
        [FilterProperty("criteria")]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// A type of a visa.
        /// </summary>
        [DataMember(Name = "visaType")]
        [FilterProperty("criteria")]
        public VisaType2 VisaType { get; set; }

        /// <summary>
        /// The identifier of the visa.
        /// </summary>
        [DataMember(Name = "visaId", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]     
        public string VisaId { get; set; }

        /// <summary>
        /// Visa status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public VisaStatus? VisaStatus { get; set; }

        /// <summary>
        /// The date when the visa was requested.
        /// </summary>
        [DataMember(Name = "requestedOn")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? RequestedOn { get; set; }

        /// <summary>
        /// The date when the visa was issued.
        /// </summary>
        [DataMember(Name = "issuedOn")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? IssuedOn { get; set; }

        /// <summary>
        /// The visa expiration date.
        /// </summary>
        [DataMember(Name = "expiresOn", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public DateTime? ExpiresOn { get; set; }

        /// <summary>
        /// Entries into the country on this visa.
        /// </summary>
        [DataMember(Name = "entries", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<PersonVisaEntry> Entries { get; set; }
    }
}