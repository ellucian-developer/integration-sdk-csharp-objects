//Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The reference document checked for available funds.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class ReferenceDocumentDtoProperty
    {
        /// <summary>
        /// The item number of the reference document.
        /// </summary>      
        [JsonProperty("itemNumber")]
        public string ItemNumber { get; set; }
    }
}