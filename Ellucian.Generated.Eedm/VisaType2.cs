// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A type of a visa.
    /// </summary>
    [DataContract]
    public class VisaType2
    {
        /// <summary>
        /// The <see cref="VisaTypeCategory">A global category of visa types</see> for the visa type categories
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        [Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public VisaTypeCategory? VisaTypeCategory { get; set; }

        /// <summary>
        /// The global identifier for the Detail..
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        [Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GuidObject2 Detail { get; set; }
    }
}
