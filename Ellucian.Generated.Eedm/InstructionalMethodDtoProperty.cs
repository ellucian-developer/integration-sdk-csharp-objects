// Copyright 2015-2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Instructional Method DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructionalMethodDtoProperty
    {
        /// <summary>
        /// Id of the InstructionalMethod
        /// </summary>
        [JsonProperty("detail")]
        public GuidObject2 Detail { get; set; }

        /// <summary>
        /// Title of the InstructionalMethod
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Abbreviation of the InstructionalMethod
        /// </summary>
        [JsonProperty("abbreviation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructionalMethodDtoProperty()
        {
            Detail = new GuidObject2();
        }
    }
}