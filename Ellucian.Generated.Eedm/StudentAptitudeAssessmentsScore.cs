using Ellucian.Generated.Eedm;
// Copyright 2017 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Property to contain Student Aptitude Assessments Scores
    /// </summary>
    [DataContract]
    public class StudentAptitudeAssessmentsScore
    {
        /// <summary>
        /// The Student Aptitude Assessments Scores type
        /// </summary>
        [DataMember(Name = "type")]
        public StudentAptitudeAssessmentsScoreType? Type { get; set; }

        /// <summary>
        ///value of Student Aptitude Assessments Scores
        /// </summary>
        [DataMember(Name="value")]
        public decimal? Value { get; set; }
    }
}
