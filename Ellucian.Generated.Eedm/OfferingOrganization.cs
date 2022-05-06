// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A collection of people organized together into a community or other social, commercial or political structure
    /// for the purposes of education, and its percentage of responsibility for a course/section
    /// </summary>
    [DataContract]
    public class OfferingOrganization
    {
        /// <summary>
        /// Globally unique identifier for the organization
        /// </summary>
        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        /// <summary>
        /// Organization's percentage of responsibility
        /// </summary>
        [DataMember(Name = "ownershipPercentage")]
        public decimal Share { get; set; }
    }
}