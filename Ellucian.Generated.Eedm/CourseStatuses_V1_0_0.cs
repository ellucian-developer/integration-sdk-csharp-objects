//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The list of valid statuses for courses. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CourseStatuses_V1_0_0 : CodeItem2
    {
        /// <summary>
        /// The category associated with the course status (active or ended).
        /// </summary>

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CourseStatusesCategory? Category { get; set; }

    }
}
