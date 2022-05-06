// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about an valid reciprocal relationship
    /// </summary>
    [DataContract]
    //public class ValidReciprocalRelationship : CodeItem2
    public class ValidReciprocalRelationship
    {
        /// <summary>
        /// The <see cref="type">entity type</see> for the valid reciprocal relationship
        /// </summary>
        [DataMember(Name = "type")]
        public PersonalRelationshipType PersonalRelationshipType { get; set; }

        /// <summary>
        /// Relationship type guid.
        /// </summary>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public GuidObject2 Detail { get; set; } 
    }
}