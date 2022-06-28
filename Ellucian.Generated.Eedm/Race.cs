// Copyright 2014 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A classification of humans based on such genetic markers as blood groups or on other physical characteristics.
    /// </summary>
    [DataContract]
    public class Race : CodeItem
    {
        /// <summary>
        /// The type of race.
        /// </summary>
        [DataMember(Name = "parentCategory")]
        public RaceType? RaceType { get; set; }
    }
}