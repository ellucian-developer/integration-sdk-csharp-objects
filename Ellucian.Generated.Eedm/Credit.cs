// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Credit Information for a course or section
    /// </summary>
    [DataContract]
    public class Credit
    {
        /// <summary>
        /// The type of credit earned for the course or section
        /// </summary>
        [DataMember(Name = "creditCategory")]
        public GuidObject CreditCategory { get; set; }

        /// <summary>
        /// The type of credit earned for the course or section
        /// </summary>
        [DataMember(Name = "measure")]
        public CreditMeasure? Measure { get; set; }

        /// <summary>
        /// Minimum number of credits/CEUs that can be earned for a course or section
        /// </summary>
        [DataMember(Name = "minimum")]
        public decimal Minimum { get; set; }

        /// <summary>
        /// Maximum number of credits that can be earned for a course or section
        /// </summary>
        [DataMember(Name = "maximum")]
        public decimal? Maximum { get; set; }

        /// <summary>
        /// Variable by which the number of credits earned can be incremented for a course or section
        /// </summary>
        [DataMember(Name = "increment")]
        public decimal? Increment { get; set; }
    }
}