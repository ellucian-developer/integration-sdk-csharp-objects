// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ellucian.Generated.Eedm.Converters;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// AcademicPeriod DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AcademicPeriodDtoProperty : BaseCodeTitleDetailDtoProperty
    {
        /// <summary>
        /// Start date in UTC
        /// </summary>
        [JsonProperty("startOn")]
        public DateTimeOffset? Start { get; set; }


        /// <summary>
        /// End date in UTC
        /// </summary>
        [JsonProperty("endOn")]
        public DateTimeOffset? End { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public AcademicPeriodDtoProperty() : base() { }
    }
}

