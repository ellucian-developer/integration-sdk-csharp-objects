// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Course Level DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CourseLevelDtoProperty : BaseCodeTitleDetailDtoProperty2
    {
         /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public CourseLevelDtoProperty() : base() { }
    }
}