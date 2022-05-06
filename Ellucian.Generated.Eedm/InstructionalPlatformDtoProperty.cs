// Copyright 2015 Ellucian Company L.P. and its affiliates.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Instructional Platform DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InstructionalPlatformDtoProperty : BaseCodeTitleDetailDtoProperty
    {
        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public InstructionalPlatformDtoProperty() : base() { }
    }
}
