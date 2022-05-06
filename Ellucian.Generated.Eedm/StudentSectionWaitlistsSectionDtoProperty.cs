using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The section associated with the waitlist. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    [DataContract]
    public class StudentSectionWaitlistsSectionDtoProperty
    {
        /// <summary>
        /// The related section GUID
        /// </summary>
        [DataMember(Name = "id")]
        public string sectionId { get; set; }

    }
}
  