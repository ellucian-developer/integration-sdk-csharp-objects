// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A classification of humans based on such genetic markers as blood groups or on other physical characteristics.
    /// </summary>
    [DataContract]
    public class Races_V6_0 : CodeItem2
    {
        /// <summary>
        /// Properties required for governmental or other reporting.
        /// </summary>
        [DataMember(Name = "reporting", EmitDefaultValue = false)]
        public List<RaceReporting> RaceReporting { get; set; }
    }
}