// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an Academic Period Category
    /// </summary>
    [DataContract]
    public class AcademicPeriodCategory2
    {
        /// <summary>
        /// The <see cref="AcademicTimePeriod">Academic Time Period type</see>
        /// </summary>
        [DataMember(Name = "type")]
        public AcademicTimePeriod2 Type { get; set; }

        /// <summary>
        /// Globally unique identifier for parentId
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public GuidObject2 ParentGuid { get; set; }

        /// <summary>
        /// Globally unique identifier for precedingId
        /// </summary>
        [DataMember(Name = "preceding", EmitDefaultValue= false)]
        public GuidObject2 PrecedingGuid { get; set; }

    }
}
