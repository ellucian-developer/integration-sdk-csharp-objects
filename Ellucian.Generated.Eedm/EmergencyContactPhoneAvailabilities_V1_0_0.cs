//Copyright 2019 Ellucian Company L.P. and its affiliates.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// The valid list of user defined emergency contact phone availabilities. (e.g. evening, afternoon, etc.) 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class EmergencyContactPhoneAvailabilities_V1_0_0 : CodeItem2
    {
    }
}
