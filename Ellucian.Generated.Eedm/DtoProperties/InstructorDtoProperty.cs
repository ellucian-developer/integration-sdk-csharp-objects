// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Instructor DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructorDtoProperty
    {
        /// <summary>
        /// Id of the Instructor
        /// </summary>
        [JsonProperty("detail")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// The name of the instructor
        /// </summary>
        [JsonProperty("names", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<InstructorNameDtoProperty> Names { get; set; }

        /// <summary>
        /// The credentials of the instructor
        /// </summary>
        [JsonProperty("credentials", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<CredentialDtoProperty> Credentials { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructorDtoProperty()
        {
            Detail = new GuidObject2();
        }

    }
}
