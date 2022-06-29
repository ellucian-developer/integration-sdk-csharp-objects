// Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Financial award details by period.
    /// </summary>
    [DataContract]
    public class StudentAwardsByPeriod2DtoProperty
    {
        /// <summary>
        /// The period in which the award was bestowed.
        /// </summary>
        [DataMember(Name = "awardPeriod", EmitDefaultValue = false)]
        public GuidObject2 AwardPeriod { get; set; }

        /// <summary>
        /// Academic periods for which the financial award was made.
        /// </summary>
        [DataMember(Name = "academicPeriods", EmitDefaultValue = false)]
        public List<GuidObject2> AcademicPeriods { get; set; }

        /// <summary>
        /// Status of the financial aid award.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StudentAwardStatusDtoProperty Status { get; set; }

        /// <summary>
        /// Status of the financial aid award.
        /// </summary>
        [DataMember(Name = "amounts", EmitDefaultValue = false)]
        public StudentAwardAmount2DtoProperty Amounts { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public StudentAwardsByPeriod2DtoProperty()
        {
        }
    }
}