// Copyright 2016-2018 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using Ellucian.Generated.Eedm.Attributes;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The positions to which this position reports.
    /// </summary>
    [DataContract]
    public class ReportsToDtoProperty
    {
        /// <summary>
         /// The position to which this position reports.
        /// </summary>
        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [FilterProperty("criteria")]
        public GuidObject2 Postition { get; set; }

        /// <summary>
        ///The type of reporting position (e.g. primary, alternate, etc.).
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PositionReportsToType? Type { get; set; }
    }
}