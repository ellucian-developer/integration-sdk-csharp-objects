// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The type of the hold
    /// </summary>
    [DataContract]
    public class PersonHoldTypeType
    {
        /// <summary>
        /// A global category for student holds
        /// </summary>
        [DataMember(Name = "category")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public PersonHoldCategoryTypes? PersonHoldCategory { get; set; }

        /// <summary>
        /// The global identifier for the Detail.
        /// </summary>
        [DataMember(Name = "detail")]
        public GuidObject2 Detail { get; set; }
    }
}
