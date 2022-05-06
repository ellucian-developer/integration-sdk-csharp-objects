// Copyright 2017 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The restrictions on the relationship type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RelationshipTypesRestrictedUsage
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// personsOnly
        /// </summary>
        [EnumMember(Value = "personsOnly")]
        Personsonly,
                     
         /// <summary>
        /// nonpersonsOnly
        /// </summary>
        [EnumMember(Value = "nonpersonsOnly")]
        Nonpersonsonly,
        }
} 


