  
  
 
 
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
    /// The valid reciprocal relationships that a direct relationship of a person can have. 
    /// </summary>
   [JsonObject(MemberSerialization.OptIn)]
    public class RelationshipTypesValidReciprocalRelationships 
    {        


        /// <summary>
       /// The extension to the type of the reciprocal relationship.
       /// </summary>
          
       [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]  
       public GuidObject2 Detail { get; set; }
      

     }      
}  

