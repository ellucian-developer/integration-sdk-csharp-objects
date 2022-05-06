// Copyright 2015 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Site DTO property
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SiteDtoProperty : BaseCodeTitleDetailDtoProperty
    {
        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public SiteDtoProperty() : base() { }
    }
}