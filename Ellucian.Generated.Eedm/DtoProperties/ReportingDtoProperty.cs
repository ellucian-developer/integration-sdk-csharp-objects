// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Ellucian.Generated.Eedm;
using System.Collections.Generic;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Reporting DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ReportingDtoProperty 
    {
        /// <summary>
        /// The CIP code of the academic discipline
        /// </summary>
        [JsonProperty("country")]
        public ReportingCountryDtoProperty Value { get; set; }

    }
}
