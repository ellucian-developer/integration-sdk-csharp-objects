namespace Ellucian.Generated.BpApi
{
    /// <summary>
    /// Errors V2.0.0
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))" )]
    public partial class ErrorsV200
    {
        /// <summary>
        /// Errors collection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty( "errors", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
        public System.Collections.Generic.ICollection<Errors> Errors { get; set; } = new System.Collections.ObjectModel.Collection<Errors>();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// AdditionalProperties.
        /// </summary>
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

    /// <summary>
    /// Errors
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode( "NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))" )]
    public partial class Errors
    {
        /// <summary>
        /// Message.
        /// </summary>
        [Newtonsoft.Json.JsonProperty( "message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
        public string? Message { get; set; } = default!;

        /// <summary>
        /// Description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty( "description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore )]
        public string? Description { get; set; } = default!;

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// AdditionalProperties.
        /// </summary>
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }
}
