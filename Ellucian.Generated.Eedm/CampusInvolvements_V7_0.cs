// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A person's involvement with a campus organization.
    /// </summary>
    [DataContract]
    public class CampusInvolvements_V7_0 : BaseModel2
    {
        /// <summary>
        /// The id of the student who is involved in the organization.
        /// </summary>
        [DataMember(Name = "person")]
        public GuidObject2 PersonId { get; set; }

        /// <summary>
        /// The organization in the campus the student is involved with.
        /// </summary>
        [DataMember(Name = "campusOrganization")]
        public GuidObject2 CampusOrganizationId { get; set; }

        /// <summary>
        /// The involvement to the organization started on.
        /// </summary>
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        public DateTime? InvolvementStartOn { get; set; }

        /// <summary>
        /// The involvement to the organization ended on..
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        public DateTime? InvolvementEndOn { get; set; }

        /// <summary>
        /// Academic period in which the student was involved in this organization.       
        /// </summary>
        [DataMember(Name = "academicPeriod", EmitDefaultValue = false)]
        public GuidObject2 AcademicPeriod { get; set; }

        /// <summary>
        /// Role of the student in the organization..
        /// </summary>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public GuidObject2 InvolvementRole { get; set; }
    }
}