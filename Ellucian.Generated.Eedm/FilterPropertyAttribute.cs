// Copyright 2018-2019 Ellucian Company L.P. and its affiliates.
using System;

namespace Ellucian.Generated.Eedm.Attributes
{
    /// <summary>
    /// DTO attribute
    /// </summary>
    public class FilterPropertyAttribute : Attribute
    {
        /// <summary>
        /// SupportedOperators
        /// </summary>
        public string[] SupportedOperators { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string[] Name { get; set; }

        /// <summary>
        ///  If set to true, the property will not appear in the resources output
        /// </summary>
        public bool Ignore { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="values"></param>
        /// <param name="ignore"></param>
        public FilterPropertyAttribute(string[] values, bool ignore = false)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values", "values are required for FilterPropertyAttribute");
            }

            Name = values;
            Ignore = ignore;
        }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="value"></param>
        /// <param name="ignore"></param>
        public FilterPropertyAttribute(string value, bool ignore = false)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value", "value is required for FilterPropertyAttribute");
            }
            Name = new string[] { value };
            Ignore = ignore;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="supportedOperators"></param>
        /// <param name="ignore"></param>
        public FilterPropertyAttribute(string value, string[] supportedOperators,  bool ignore = false)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value", "value is required for FilterPropertyAttribute");
            }
            Name = new string[] { value };
            Ignore = ignore;
            SupportedOperators = supportedOperators;
        }

    }
}