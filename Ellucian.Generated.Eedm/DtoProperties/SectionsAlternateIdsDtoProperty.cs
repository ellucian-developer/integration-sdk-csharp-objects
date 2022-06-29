using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Additional unique identifiers assigned to sections to support non-Ethos integrations. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SectionsAlternateIdsDtoProperty
    {
        /// <summary>
        /// The title of the alternate identifier.
        /// </summary>
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The value of the alternate identifier.
        /// </summary>
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
