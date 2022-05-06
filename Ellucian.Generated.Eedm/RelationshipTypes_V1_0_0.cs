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
    /// The types of relationships between persons, organizations or institutions. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class RelationshipTypes_V1_0_0 : CodeItem2
    {    
        /// <summary>
       /// The valid reciprocal relationships that a direct relationship of a person can have.
       /// </summary>
         
       [JsonProperty("validReciprocalRelationships", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public List<RelationshipTypesValidReciprocalRelationships> ValidReciprocalRelationships { get; set; }
     
        /// <summary>
       /// The restrictions on the relationship type.
       /// </summary>
         
       [JsonProperty("restrictedUsage", DefaultValueHandling = DefaultValueHandling.Ignore)]
       public RelationshipTypesRestrictedUsage RestrictedUsage { get; set; }
         
     }      
}          
