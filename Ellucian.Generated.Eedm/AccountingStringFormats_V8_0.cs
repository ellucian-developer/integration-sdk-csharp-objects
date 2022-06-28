using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The details of accounting string formats. 
    /// </summary>
    [DataContract]
    public class AccountingStringFormats_V8_0 : BaseModel2
    {


        /// <summary>
        /// The delimiter that separates the accounting components within an accounting string.
        /// </summary>
        [DataMember(Name = "delimiter", EmitDefaultValue = false)]
        public string Delimiter { get; set; }

        /// <summary>
        /// The accounting string components that make a valid accounting string along with their position within that string
        /// </summary>
        [DataMember(Name = "components", EmitDefaultValue = false)]
        public List<Components> Components { get; set; }

    }

    /// <summary>
    /// The accounting string components that make a valid accounting string along with their position within that string 
    /// </summary>
    public class Components
    {
        /// <summary>
        /// An accounting string component that is part of a valid accounting string.
        /// </summary>
        [JsonProperty("component", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Component { get; set; }

        /// <summary>
        /// The position of the accounting component within a valid accounting string.
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int order { get; set; }
    }

}