// Copyright 2016-2021 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Attributes;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A list of units of the educational institution (optionally, hierarchical) that own or are responsible for a course 
    /// </summary>
    [DataContract]
    [JsonObject(MemberSerialization.OptIn)]
    public class OwningInstitutionUnit
    {
        /// <summary>
        /// A School, College, Division, Department, or any other organizational unit in the institution
        /// </summary>
        [JsonProperty("institutionUnit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        [JsonConverter(typeof(GuidObject2FilterConverter))]
        public GuidObject2 InstitutionUnit { get; set; }

        /// <summary>
        /// The portion of a course that is owned or allocated to a particular organization.
        /// </summary>
        [JsonProperty("ownershipPercentage", DefaultValueHandling = DefaultValueHandling.Ignore)]

        public decimal OwnershipPercentage { get; set; }

        /// <summary>
        /// constructor for property initialization
        /// </summary>
        public OwningInstitutionUnit()
        {
            InstitutionUnit = new GuidObject2();
        }
    }
}