// Copyright 2016 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Section property got SectionCrosslist
    /// </summary>
    [DataContract]
    public class SectionsForCrosslistDtoProperty
    {
        /// <summary>
        /// Id of the Instructor
        /// </summary>
        [DataMember(Name = "section")]
        public GuidObject2 Section { get; set; }

        /// <summary>
        /// The name of the person who entered the comment
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public SectionTypeForCrosslist? Type { get; set; }

    }
}
