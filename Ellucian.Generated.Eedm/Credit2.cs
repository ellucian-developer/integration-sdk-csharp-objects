// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Credit Information for a course or section
    /// </summary>
    [DataContract]
    public class Credit2
    {
        /// <summary>
        /// The type of credit earned for the course or section
        /// </summary>
        [DataMember(Name = "creditCategory")]
        public CreditIdAndTypeProperty CreditCategory { get; set; }
        
        /// <summary>
        /// The type of credit earned for the course or section
        /// </summary>
        [DataMember(Name = "measure", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public CreditMeasure2? Measure { get; set; }

        /// <summary>
        /// Minimum number of credits/CEUs that can be earned for a course or section
        /// </summary>
        [DataMember(Name = "minimum", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Minimum { get; set; }

        /// <summary>
        /// Maximum number of credits that can be earned for a course or section
        /// </summary>
        [DataMember(Name = "maximum", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Maximum { get; set; }

        /// <summary>
        /// Variable by which the number of credits earned can be incremented for a course or section
        /// </summary>
        [DataMember(Name = "increment", EmitDefaultValue = false)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Increment { get; set; }
    }
}