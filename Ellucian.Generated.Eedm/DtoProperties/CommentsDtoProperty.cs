//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The comments 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CommentsDtoProperty
    {

        /// <summary>
        /// A comment.
        /// </summary>
        [JsonProperty("comment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// An indication of whether the comment is printed or not printed.
        /// </summary>
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CommentTypes? Type { get; set; }

    }
}