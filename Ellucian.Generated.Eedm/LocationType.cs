// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a location type
    /// </summary>
    [DataContract]
    public class LocationType
    {
        /// <summary>
        /// The <see cref="PersonLocationType">type</see> of location type for this entity
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        public PersonLocationType PersonLocationType { get; set; }

        /// <summary>
        /// The <see cref="OrganizationLocationType">type</see> of location type for this entity
        /// </summary>
        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public OrganizationLocationType OrganizationLocationType { get; set; }
    }
}
