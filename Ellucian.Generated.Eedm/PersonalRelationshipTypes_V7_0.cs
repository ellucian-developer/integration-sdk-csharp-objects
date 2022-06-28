// Copyright 2015-2017 Ellucian Company L.P. and its affiliates.

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a relation type
    /// </summary>
    [DataContract]
    public class PersonalRelationshipTypes_V7_0 : CodeItem2
    {
        /// <summary>
        /// The <see cref="PersonalRelationshipType">entity type</see> for the personal relationship types
        /// </summary>
        [DataMember(Name = "relationshipType")]
        public PersonalRelationshipType PersonalRelationshipType { get; set; }

        /// <summary>
        /// The <see cref="ValidReciprocalRelationship">entity type</see> for the valid reciprocal relationship
        /// </summary>
        [DataMember(Name = "validReciprocalRelationships", EmitDefaultValue = false)]
        public List<ValidReciprocalRelationship> ValidReciprocalRelationship { get; set; }
    }
}