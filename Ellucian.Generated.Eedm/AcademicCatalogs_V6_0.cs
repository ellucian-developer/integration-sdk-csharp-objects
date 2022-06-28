// Copyright 2015-2016 Ellucian Company L.P. and its affiliates.

using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    ///  A catalog listing of the courses offered by an organization.
    /// </summary>
    [DataContract]
    public class AcademicCatalogs_V6_0 : CodeItem2
    {   
        /// <summary>
        /// The beginning date for when an academic catalog takes effect
        /// </summary>
        [DataMember(Name = "startOn", EmitDefaultValue = false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The ending date for when an academic catalog is no longer in effect
        /// </summary>
        [DataMember(Name = "endOn", EmitDefaultValue = false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// A status of an academic catalog
        /// </summary>
        [DataMember(Name = "status")]
        public LifeCycleStatus status { get; set;  }
    }
}