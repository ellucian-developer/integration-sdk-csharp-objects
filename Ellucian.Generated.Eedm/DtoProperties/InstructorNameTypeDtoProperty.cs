// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Instructor Name DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructorNameTypeDtoProperty
    {
        /// <summary>
        /// The <see cref="PersonNameType">type</see> of the person's name
        /// </summary>
        [JsonProperty("category")]
        public InstructorNameType2? Category { get; set; }

        /// <summary>
        /// Person's title/prefix
        /// </summary>
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        [JsonConstructor]
        public InstructorNameTypeDtoProperty()
        {
            //don't have anything to populate this with right now
            Detail = null;
        }
    }
}
