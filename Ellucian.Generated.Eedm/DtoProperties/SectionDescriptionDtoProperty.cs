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
    /// The course titles details. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionDescriptionDtoProperty
    {
        /// <summary>
        /// The type of course title (e.g. short title, long title).
        /// </summary>

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Type { get; set; }

        /// <summary>
        /// The title for the course associated with the type.
        /// </summary>

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
