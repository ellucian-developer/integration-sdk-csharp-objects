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
    /// The details of an accounting string subcomponent. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AccountingStringSubcomponentValues_V13_0 : CodeItem2
    {
        /// <summary>
        /// The accounting string subcomponent used in the accounting string.
        /// </summary>

        [JsonProperty("subcomponent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 Subcomponent { get; set; }

        /// <summary>
        /// The accounting string subcomponent that is one level higher in the subcomponent hierarchy.
        /// </summary>

        [JsonProperty("parentSubcomponent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 ParentSubcomponent { get; set; }

    }
}