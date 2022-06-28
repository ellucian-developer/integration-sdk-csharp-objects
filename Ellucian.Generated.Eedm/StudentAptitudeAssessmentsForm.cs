// Copyright 2017 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Property to contain Student Aptitude Assessments Form
    /// </summary>
    [DataContract]
    public class StudentAptitudeAssessmentsForm
    {
        /// <summary>
        /// Student Aptitude Assessments Form Number
        /// </summary>
        [DataMember(Name = "number")]
        public string Number { get; set; }

        /// <summary>
        /// Student Aptitude Assessments Form Name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}