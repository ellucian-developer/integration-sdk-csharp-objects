// Copyright 2016 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The person or organization acting as the vendor.
    /// </summary>
    [DataContract]
    public class VendorDetailsDtoProperty
    {
        /// <summary>
        ///  Detail information of the organization acting as the vendor.
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Organization { get; set; }

        /// <summary>
        /// Detail information of the person acting as the vendor.
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Person { get; set; }

        /// <summary>
        /// Detail information of the institution acting as the vendor.
        /// </summary>
        [DataMember(Name = "institution", EmitDefaultValue = false)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 Institution { get; set; }
    }
}