// Copyright 2017 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Property to contain student Aptitude Assessments Scores
    /// </summary>
    [DataContract]
    public class StudentAptitudeAssessmentsPercentile
    {
        /// <summary>
        /// The enrollment status enumerations
        /// </summary>
        [DataMember(Name = "type")]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// Id of the Enrollment status
        /// </summary>
        [DataMember(Name = "value")]
        public decimal? Value { get; set; }
    }
}