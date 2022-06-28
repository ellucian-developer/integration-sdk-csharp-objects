//Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The list of valid accounting string subcomponents. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountingStringSubcomponents_V13_0 : BaseModel2
    {
        /// <summary>
        /// The full name of the accounting string subcomponent.
        /// </summary>

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The description of the accounting string subcomponent.
        /// </summary>

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The type of subcomponent.
        /// </summary>

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AccountingStringSubcomponentsType Type { get; set; }

        /// <summary>
        /// The accounting string subcomponent that is one level higher in the subcomponent hierarchy.
        /// </summary>

        [JsonProperty("parentSubcomponent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ParentSubcomponent { get; set; }

    }
}
