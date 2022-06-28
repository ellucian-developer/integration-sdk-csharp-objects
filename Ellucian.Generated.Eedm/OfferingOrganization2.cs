// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A collection of people organized together into a community or other social, commercial or political structure
    /// for the purposes of education, and its percentage of responsibility for a course/section
    /// </summary>
    [DataContract]
    public class OfferingOrganization2
    {
        /// <summary>
        /// Globally unique identifier for the organization
        /// </summary>
        [DataMember(Name = "organization")]
        public GuidObject2 Organization { get; set; }

        /// <summary>
        /// Organization's percentage of responsibility
        /// </summary>
        [DataMember(Name = "ownershipPercentage", EmitDefaultValue = false)]
        public decimal? Share { get; set; }

        /// <summary>
        /// constructor for property initialization
        /// </summary>
        public OfferingOrganization2()
        {
            Organization = new GuidObject2();
        }
    }
}