// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Credit DTO Property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CreditDtoProperty
    {
        /// <summary>
        /// The type of credit earned for the course or section
        /// </summary>
        [JsonProperty("measure")]
        public CreditMeasure2? Measure { get; set; }

        /// <summary>
        /// Minimum number of credits/CEUs that can be earned for a course or section
        /// </summary>
        [JsonProperty("minimum")]
        public decimal? Minimum { get; set; }

        /// <summary>
        /// Maximum number of credits that can be earned for a course or section
        /// </summary>
        [JsonProperty("maximum", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Maximum { get; set; }

        /// <summary>
        /// Variable by which the number of credits earned can be incremented for a course or section
        /// </summary>
        [JsonProperty("increment", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal? Increment { get; set; }

        /// <summary>
        /// Credit Category for credit
        /// </summary>
        [JsonProperty("creditCategory")]
        public CreditCategoryDtoProperty CreditCategory { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public CreditDtoProperty()
        {
            CreditCategory = new CreditCategoryDtoProperty();
        }

    }
}
