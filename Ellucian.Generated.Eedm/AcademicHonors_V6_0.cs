// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Honor presented to a student based on academic achievement
    /// </summary>
    [DataContract]
    public class AcademicHonors_V6_0 : CodeItem2
    {
        /// <summary>
        /// A type of academic honor
        /// </summary>
        [DataMember(Name = "type")]
        public AcademicHonorType AcademicHonorType { get; set; }

    }
}
