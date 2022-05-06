using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ellucian.Generated.Eedm.Converters;
using Ellucian.Generated.Eedm;
using Newtonsoft.Json;

namespace Ellucian.Generated.Eedm
{
    /// <summary>
    /// A list of valid reasons that may be used when overriding a standard cost/fee. 
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class BillingOverrideReasons_V8_0 : CodeItem2
    {
    }
}
