// Copyright 2015 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Information about a person name type
    /// </summary>
    [DataContract]
    public class PersonNameTypes_V12_0 : CodeItem2
    {
        /// <summary>
        /// <see cref="PersonNameType2">PersonNameType</see>
        /// </summary>
        [DataMember(Name = "category")]
        public PersonNameType2 Type { get; set; }
    }
}