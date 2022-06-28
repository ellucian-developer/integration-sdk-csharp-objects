// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The characteristics of duration
    /// </summary>
    [DataContract]
    public class SectionDuration
    {
        /// <summary>
        /// The length of the duration
        /// </summary>
        [DataMember(Name = "length")]
        public int Length { get; set; }

        /// <summary>
        /// The unit of measure for the duration
        /// </summary>
        [DataMember(Name = "unit")]
        public DurationUnit Unit { get; set; }
    }
}
