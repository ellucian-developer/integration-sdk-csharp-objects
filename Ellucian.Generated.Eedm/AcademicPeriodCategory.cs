// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an Academic Period Category
    /// </summary>
    [DataContract]
    public class AcademicPeriodCategory
    {
        /// <summary>
        /// The <see cref="AcademicTimePeriod">Academic Time Period type</see>
        /// </summary>
        [DataMember(Name = "type")]
        public AcademicTimePeriod Type { get; set; }

        /// <summary>
        /// Globally unique identifier for parentId
        /// </summary>
        [DataMember(Name = "parentId")]
        public string ParentGuid { get; set; }

        /// <summary>
        /// Globally unique identifier for precedingId
        /// </summary>
        [DataMember(Name = "precedingId")]
        public string PrecedingGuid { get; set; }

    }
}
