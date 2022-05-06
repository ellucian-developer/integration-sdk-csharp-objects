//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The contact specified for the destination. 
    /// </summary>
   [JsonObject(MemberSerialization.OptIn)]
    public class ShipToDestinationsContact 
    {    
        /// <summary>
       /// The name of the contact.
       /// </summary>
          
       [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public string Name { get; set; }
     
        /// <summary>
       /// The phone number and extension of the contact.
       /// </summary>
          
       [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public PhoneDtoProperty Phone { get; set; }
         

 

     }      
}  

