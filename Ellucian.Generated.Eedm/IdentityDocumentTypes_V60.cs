// Copyright 2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a identity document type
    /// </summary>
    [DataContract]
    public class IdentityDocumentTypes_V60 : CodeItem2
    {
        /// <summary>
        /// The <see cref="IdentityDocumentTypes_V60">entity type</see> for the identity document types
        /// </summary>
        [DataMember(Name = "category")]
        public IdentityDocumentTypeCategory identityDocumentTypeCategory { get; set; }
    }
}