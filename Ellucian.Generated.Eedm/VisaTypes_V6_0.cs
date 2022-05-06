// Copyright 2015 Ellucian Company L.P. and its affiliates.
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// VisaType object
    /// </summary>
    [DataContract]
    public class VisaTypes_V6_0 : CodeItem2
    {
        /// <summary>
        /// The <see cref="VisaTypeCategory">entity type</see> for the visa type categories
        /// </summary>
        [DataMember(Name = "category")]
        public VisaTypeCategory VisaTypeCategory { get; set; }
    }
}
