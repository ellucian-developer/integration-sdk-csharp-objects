//Copyright 2020 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The list of valid vendor address usages. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class VendorAddressUsages_V1_0_0 : BaseModel2
    {    
        /// <summary>
       /// The full name of the vendor address usage.
       /// </summary>
         
       [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Title { get; set; }
     
        /// <summary>
       /// The description of the vendor address usage.
       /// </summary>
         
       [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Description { get; set; }
         
     }      
}          
