//Copyright 2019 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The specific elements included on a tax form (i.e. non-exempt income, prizes and awards, etc). 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class TaxFormComponents_V1_0_0 : CodeItem2
    {
        /// <summary>
        /// The tax form with which the components are associated.
        /// </summary>

        [JsonProperty("taxForm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GuidObject2 TaxForm { get; set; }

    }
}