// Copyright 2018 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Ellucian.Generated.Eedm
{   
   /// <summary>
    /// The category to which the course transfer status belongs.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CourseTransferStatusesCategory
    {     
        /// <summary>
        /// Used when the value is not set or an invalid enumeration is used
        /// </summary>
        NotSet = 0,
       
                           
         /// <summary>
        /// preliminary
        /// </summary>
        [EnumMember(Value = "preliminary")]
        Preliminary,
                     
         /// <summary>
        /// approved
        /// </summary>
        [EnumMember(Value = "approved")]
        Approved,
        }
} 


