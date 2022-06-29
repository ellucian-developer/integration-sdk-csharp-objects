// Copyright 2015-2018 Ellucian Company L.P. and its affiliates.

using System;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// AdministrativePeriod DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AdministrativePeriodDtoProperty : BaseCodeTitleDetailDtoProperty2
    {
        /// <summary>
        /// Start date in UTC
        /// </summary>
        [JsonProperty("startOn")]
        public DateTime? Start { get; set; }

        /// <summary>
        /// End date in UTC
        /// </summary>
        [JsonProperty("endOn")]
        public DateTime? End { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public AdministrativePeriodDtoProperty() : base() { }
    }
}