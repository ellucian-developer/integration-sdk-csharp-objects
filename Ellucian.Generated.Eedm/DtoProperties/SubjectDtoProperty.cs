// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Course DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SubjectDtoProperty
    {
        /// <summary>
        /// Id of the InstructionalPlatform
        /// </summary>
        [JsonProperty("detail")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// Title of the InstructionalPlatform
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// A numbering scheme to distinguish different Courses
        /// </summary>
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public SubjectDtoProperty()
        {
            Detail = new GuidObject2();
        }

    }
}