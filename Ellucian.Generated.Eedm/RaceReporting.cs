// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Race reporting
    /// </summary>
    [DataContract]
    public class RaceReporting    
    {
        /// <summary>
        /// The country with specific reporting requirements.
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public RaceReportingCountry RaceReportingCountry { get; set; }       
    }
}
