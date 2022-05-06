// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// An Academic Credential Type
    /// </summary>
    [DataContract]
    public class AcademicCredentials_V6_0 : AbbreviationItem
    {
        /// <summary>
        /// A type of academic credential
        /// </summary>
        [DataMember(Name = "type")]
        public AcademicCredentialType AcademicCredentialType { get; set; }

    }
}
