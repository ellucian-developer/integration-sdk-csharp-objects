// Copyright 2014-2016 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A building on a site.
    /// </summary>
    [DataContract]
    public class Buildings_V11_0 : Buildings_V6_0
    {
        /// <summary>
        /// The physical address associated with the building
        /// </summary>
        //[JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public BuildingAddress Address { get; set; }

        /// <summary>
        /// A link to a publicly available image of the building.
        /// </summary>
        //[JsonProperty("imageUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DataMember(Name = "imageUrl", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }
        
        /// <summary>
        /// The attributes or additional services associated with the building
        /// </summary>
        //[JsonProperty("characteristics", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DataMember(Name = "characteristics", EmitDefaultValue = false)]
        public List<string> Characteristics { get; set; }

        /// <summary>
        /// The comments associated with the building.
        /// </summary>
        //[JsonProperty("comments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public List<string> Comments { get; set; }

    }
}