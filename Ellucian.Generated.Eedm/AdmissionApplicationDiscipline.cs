//Copyright 2017 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// Discipline
    /// </summary>
    [DataContract]
    public class AdmissionApplicationDiscipline
    {
        /// <summary>
        /// Discipline
        /// </summary>
        [DataMember(Name = "discipline", EmitDefaultValue = false)]
        public GuidObject2 Discipline { get; set; }
    }
}
