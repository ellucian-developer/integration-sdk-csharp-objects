// Copyright 2016 Ellucian Company L.P. and its affiliates.
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    ///  Person relationship
    /// </summary>
    [DataContract]
    public class PersonGuardians_V7_0 : BaseModel2
    {
        /// <summary>
        /// A person, with regards to whom the relationship is considered.
        /// </summary>
        [DataMember(Name = "person")]
        public GuidObject2 SubjectPerson { get; set; }

        /// <summary>
        /// The subject person's guardians.
        /// </summary>
        [DataMember(Name = "guardians")]
        public IEnumerable<PersonGuardianDtoProperty> Guardians { get; set; }
    }
}
