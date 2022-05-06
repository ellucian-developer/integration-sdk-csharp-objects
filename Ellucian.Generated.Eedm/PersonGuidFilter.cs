// Copyright 2020 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm.Filters
{
    /// <summary>
    /// Person GUID named query
    /// </summary>
    public class PersonGuidFilter
    {
        /// <summary>
        /// Return all records associated with a person
        /// </summary>        
        [JsonProperty("person")]
        [FilterProperty("person")]
        public GuidObject2 Person { get; set; }        
    }
}