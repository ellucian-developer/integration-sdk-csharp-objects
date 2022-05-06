// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The IPEDS racial category to which the race belongs.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportingRacialCategory
    {
        /// <summary>
        /// American indian or alaska native
        /// </summary>
        [EnumMember(Value = "americanIndianOrAlaskaNative")]       
        AmericanIndianOrAlaskaNative,
        /// <summary>
        /// Asian
        /// </summary>
        [EnumMember(Value = "asian")]
        Asian,
        /// <summary>
        /// Black or african american
        /// </summary>
        [EnumMember(Value = "blackOrAfricanAmerican")]
        BlackOrAfricanAmerican,
        /// <summary>
        /// Hawaiian or pacific islander
        /// </summary>
        [EnumMember(Value = "hawaiianOrPacificIslander")]
        HawaiianOrPacificIslander,
        /// <summary>
        /// White
        /// </summary>
        [EnumMember(Value = "white")]
        White
    }
}
