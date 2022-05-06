// Copyright 2018-2019 Ellucian Company L.P. and its affiliates.

using Ellucian.Generated.Eedm.Attributes;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Reflection;
using System.Runtime.Serialization;

namespace Ellucian.Generated.Eedm.Converters
{

    /// <summary>
    /// JSON converter to parse query string segment
    /// </summary>
    public class FilterConverter : JsonConverter
    {
        private readonly List<Tuple<string, JProperty, InvalidFilterType, string>> _invalidFilterProperties;
        private readonly List<Tuple<string, FilterMemberInfo>> _filterProperties;
        private List<string> _filterGroups;

        /// <summary>
        /// GetFilterNames
        /// </summary>
        public IEnumerable<string> GetFilterGroups
        {
            get { return _filterGroups; }
        }

        /// <summary>
        /// GetFilterProperties
        /// </summary>
        public IEnumerable<Tuple<string, FilterMemberInfo>> GetFilterProperties
        {
            get { return _filterProperties; }
        }

        /// <summary>
        /// InvalidFilterProperties
        /// </summary>
        public List<Tuple<string, JProperty, InvalidFilterType, string>> InvalidFilterProperties
        {
            get { return _invalidFilterProperties; }
        }

        /// <summary>
        /// ContainsEmptyFilterProperties
        /// </summary>
        public bool ContainsEmptyFilterProperties { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public FilterConverter()
        {
            _invalidFilterProperties = new List<Tuple<string, JProperty, InvalidFilterType, string>>();
            _filterProperties = new List<Tuple<string, FilterMemberInfo>>();
            _filterGroups = new List<string>();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public FilterConverter(string filterName)
        {
            _invalidFilterProperties = new List<Tuple<string, JProperty, InvalidFilterType, string>>();
            _filterProperties = new List<Tuple<string, FilterMemberInfo>>();
            _filterGroups = new List<string>();
            _filterGroups.Add(filterName);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public FilterConverter(List<string> filterNames)
        {
            _invalidFilterProperties = new List<Tuple<string, JProperty, InvalidFilterType, string>>();
            _filterProperties = new List<Tuple<string, FilterMemberInfo>>();
            _filterGroups = filterNames;
        }

        /// <summary>
        /// ContainsInvalidFilterProperties
        /// </summary>
        /// <returns>returns true if any invalid filter parameters were found.</returns>
        public bool ContainsInvalidFilterProperties()
        {
            bool retval = false;
            if ((_invalidFilterProperties != null) && (_invalidFilterProperties.Any()))
            {
                retval = true;
            }
            return retval;
        }

        /// <summary>
        /// ContainsFilterProperties
        /// </summary>
        /// <returns>returns true if any invalid filter parameters were found.</returns>
        public bool ContainsFilterProperties()
        {
            bool retval = false;
            if ((_filterProperties != null) && (_filterProperties.Any()))
            {
                retval = true;
            }
            return retval;
        }

        /// <summary>
        /// AddFilterGroupName
        /// </summary>
        /// <param name="filterGroupName"></param>
        public void AddFilterGroupName(string filterGroupName)
        {
            if (string.IsNullOrEmpty(filterGroupName))
                return;

            if (_filterGroups == null)
                _filterGroups = new List<string>();
            _filterGroups.Add(filterGroupName);
        }

        /// <summary>
        /// AddFilterGroupNames
        /// </summary>
        /// <param name="filterGroupNames"></param>
        public void AddFilterGroupNames(List<string> filterGroupNames)
        {
            if (filterGroupNames == null || !filterGroupNames.Any())
                return;
            if (_filterGroups == null)
                _filterGroups = filterGroupNames;
            else
                this._filterGroups.AddRange(filterGroupNames);
        }

        /// <summary>
        /// ResetFilterGroupNames
        /// </summary>
        public void ResetFilterGroupNames()
        {
            if (_filterGroups == null || !_filterGroups.Any())
                return;
            this._filterGroups.Clear();
        }

        /// <summary>
        /// CanConvert
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        /// <summary>
        /// WriteJson
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ReadJson
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // TODO: Once JSON.NET is updated to v12.0.1, add support for preventing duplicate property names 
            //serializer.DuplicatePropertyNameHandling = DuplicatePropertyNameHandling.Error;
                       

            serializer.StringEscapeHandling = StringEscapeHandling.EscapeHtml;

            //create an instance of the DTO which will be returned 
            existingValue = existingValue ?? Activator.CreateInstance(objectType, true);

            //get all the metadata for the DTO properties
            PropertyInfo[] properties =
               objectType.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // are there any filter groups used by the resource. 
            if (_filterGroups == null || !_filterGroups.Any())
                return existingValue;

            // read in the query string into a JObject           
            JObject jObject = JObject.Load(reader);
            if (jObject == null)
                return existingValue;

            //get all the properties associated with the query string
            IEnumerable<JProperty> jProperties = jObject.Properties();

            // Loop through all the properties of that JObject
            foreach (JProperty jProperty in jProperties)
            {
                try
                {
                    // Determine if the filter property is defined on the DTO and get attributes                
                    var propertyInfo = this.GetPropertyInfo(objectType, jProperty.Name);

                    if ((propertyInfo == null) || (string.IsNullOrEmpty(propertyInfo.PropertyName)))
                    {
                        AddInvalidFilterProperty(jProperty, InvalidFilterType.Property); continue;
                    }
                   

                    var jToken = jObject[jProperty.Name];
                    if (jToken != null)
                    {
                        object value = null;
                        // See if we have any qualifiers for the query
                        if (jToken.Children().Any())
                        {
                            var childToken = jToken.Last;
                            var path = childToken.Path.ToString();
                            var oper = "";
                            if (path.Contains('.'))
                            {
                                var pathSplit = path.Split('.');
                                oper = pathSplit.LastOrDefault();
                            }
                            else
                            {
                                oper = path;
                            }
                            if (!string.IsNullOrEmpty(oper) && oper.Substring(0, 1) == "$")
                            {
                                jToken = childToken.Last;
                                ValidateFilterOperator(jProperty, propertyInfo, oper);
                                if (_invalidFilterProperties.Any())
                                    continue;

                                propertyInfo.FilterCriteria = oper;
                            }
                        }

                        if (propertyInfo.JsonConverter != null)
                        {
                            try
                            {
                                var jTokenSerializer = AddConvertersType(propertyInfo.JsonConverter);
                                value = jToken.ToObject(propertyInfo.Type, jTokenSerializer);
                                jToken = JToken.FromObject(value);
                            }
                            catch (JsonSerializationException)
                            {
                                AddInvalidFilterProperty(jProperty, InvalidFilterType.DataType); continue;
                            }
                        }

                        if (IsInvalidFilterPropertyFound(jToken, jProperty, propertyInfo))
                        {
                             continue;
                        }
                        if (CheckForEmtpyProperties(jToken))
                        {
                            ContainsEmptyFilterProperties = true; continue;
                        }

                        
                        var type = IsNullableType(propertyInfo.Type)
                            ? getGenericArgumentType(propertyInfo, jToken, value)
                             : propertyInfo.Type;

                        value = jToken.ToObject(type);

                        var itemType = jObject[jProperty.Name].GetType();
                        if (itemType != typeof(JValue))
                        {
                         
                            // If a parent object is defined to have a filter attribute, then
                            // we need to validate all the properties on its children are valid for its type                    
                            if (propertyInfo.Type.BaseType != typeof(System.Enum))
                            {
                                if (jToken.Type == JTokenType.Array)
                                {
                                    var obj1 = JArray.Parse(JsonConvert.SerializeObject(value,
                                        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })) as JArray;
                                    if ((obj1 != null)) //&& (!JArray.DeepEquals(jToken, obj1)))
                                    {
                                        JArray obj2 = (JArray)jObject[jProperty.Name];
                                        if (!JArray.DeepEquals(obj1, obj2))
                                        {
                                            AddInvalidFilterProperty(jProperty, InvalidFilterType.Property);
                                        }
                                    }
                                }
                                else
                                {
                                    //JObject created from DTO property type
                                    var obj1 = JToken.Parse(JsonConvert.SerializeObject(value,
                                        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })) as JObject;
                                    if (obj1 != null)
                                    {
                                        JObject obj2 = (JObject)jObject[jProperty.Name];  //JObject created from query string property
                                                                                          // compare the properties on both objects
                                        if ((!obj1.HasValues) || (!(obj1.Properties().Select(p => p.Name).ToList()
                                            .All(obj2.Properties().Select(q => q.Name).ToList().Contains))))
                                        {
                                            AddInvalidFilterProperty(jProperty, InvalidFilterType.Property);
                                        }
                                        //if (!JObject.DeepEquals(obj1, obj2))
                                        //{
                                        //    AddInvalidFilterProperty(jProperty, InvalidFilterType.DataType);
                                        //}
                                    }
                                }
                            }
                        }
                        // Build the output. If the property is found on the DTO, then set the value 
                        var dtoProperty = properties.FirstOrDefault(x => x.Name == propertyInfo.PropertyName);
                        if (dtoProperty == null)
                        {
                            AddInvalidFilterProperty(jProperty);
                        }
                        else
                        {
                            dtoProperty.SetValue(existingValue, value, null);
                            AddFilterProperty(propertyInfo);
                        }
                    }
                }
                catch
                {
                    AddInvalidFilterProperty(jProperty);
                }
            }
            return existingValue;
        }

        private void ValidateFilterOperator(JProperty jProperty, FilterMemberInfo propertyInfo, string oper)
        {

            if ((string.IsNullOrEmpty(oper)) || (jProperty == null) || (propertyInfo == null))
                    return;

            // if supplying an filter operator, and no supported operators are associated with the property, then trow a not supported message
            if ((propertyInfo.SupportedOperators == null) || (!propertyInfo.SupportedOperators.Keys.Any()))
            {
                AddInvalidFilterProperty(jProperty, InvalidFilterType.UnsupportedFilterOperator, oper);
                return;
            }

            foreach (var keys in propertyInfo.SupportedOperators.Keys)
            {
                foreach (var key in keys)
                {
                    var supportedOperatorValues = propertyInfo.SupportedOperators.FirstOrDefault(y => _filterGroups.Any(z => z == key));

                    if (!supportedOperatorValues.Value.Any())
                        continue;

                    var uppercaseSupportedOperators = supportedOperatorValues.Value.ConvertAll(d => d.ToUpper());

                    if (uppercaseSupportedOperators != null && uppercaseSupportedOperators.Contains(oper))
                    {
                        AddInvalidFilterProperty(jProperty, InvalidFilterType.InvalidFilterOperator, oper);

                    }
                    else if (!supportedOperatorValues.Value.Contains(oper))
                    {
                        AddInvalidFilterProperty(jProperty, InvalidFilterType.UnsupportedFilterOperator, oper);
                    }
                }
            }
        }

        private Type getGenericArgumentType(FilterMemberInfo propertyInfo, JToken jToken, object value)
        {
            Type genericObjectType = null;
            var genericArgument = propertyInfo.Type.GetGenericArguments();
            if (genericArgument != null && genericArgument.Any())
            {
                genericObjectType = propertyInfo.Type.GetGenericArguments()[0];
            }
            return genericObjectType;
        }

        private bool JTokenIsNullOrEmpty(JToken token)
        {
      
            return (token == null) ||          
                   (token.Type == JTokenType.Array && !token.HasValues) ||
                   (token.Type == JTokenType.Object && !token.HasValues) ||
                   (token.Type == JTokenType.String && token.ToString() == String.Empty) ||
                   (token.Type == JTokenType.Boolean && token.Value<bool>() == false) ||
                   (token.Type == JTokenType.Integer && token.Value<int>() == 0) ||
                   (token.Type == JTokenType.Null);
        }

        private JsonSerializer AddConvertersType(JsonConverter type, bool integerCheck = true)
        {
            JsonSerializer jTokenSerializer = new JsonSerializer();
            if (type == null)
                return jTokenSerializer;
            jTokenSerializer.Converters.Add(type);
            if (integerCheck)
                jTokenSerializer.Converters.Add(new IntegerConverter());
            return jTokenSerializer;
        }
      
        private bool CheckForEmtpyProperties(JToken jToken)
        {
            var retval = false;
            if (jToken == null)
            {
                return true;
            }
            if (JTokenIsNullOrEmpty(jToken))
            {
                return true;
            }
            
            foreach (JToken token in jToken.Children())
            {
                var tokenValues = token.Values();
                if (tokenValues != null && tokenValues.Any())
                {
                    foreach (var tokenValue in tokenValues)
                    {
                        if (JTokenIsNullOrEmpty(tokenValue))
                        {
                            return true;
                        }
                    }
                }
                if (CheckForEmtpyProperties(token))
                    return true;
            }
            return retval;
        }

        /// <summary>
        /// AddInvalidFilterProperty
        /// </summary>
        /// <param name="jProperty"></param>
        /// <param name="invalidFilterType"></param>
        /// <param name="value"></param>
        public void AddInvalidFilterProperty(JProperty jProperty, InvalidFilterType invalidFilterType = InvalidFilterType.NotSet, string value = "")
        {
            if (_invalidFilterProperties == null)
                return;
            if (!_invalidFilterProperties.Any(m => m.Item1 == jProperty.Name))
            _invalidFilterProperties.Add(new Tuple<string, JProperty, InvalidFilterType, string>(jProperty.Name, jProperty, invalidFilterType, value));

        }

        private void AddFilterProperty(FilterMemberInfo jProperty)
        {
            if (_filterProperties == null)
                return;
            if (!_filterProperties.Any(m => m.Item1 == jProperty.PropertyName))
                _filterProperties.Add(new Tuple<string, FilterMemberInfo>(jProperty.PropertyName, jProperty));

        }

        /// <summary>
        ///  Error message to return on invalid filters
        /// </summary>
        /// <returns></returns>
        public string GetInvalidFilterErrorMessage()
        {
            var retval = string.Empty;

            if (InvalidFilterProperties != null && InvalidFilterProperties.Any())
            {
                foreach (var invalidFilterProperties in InvalidFilterProperties)
                {
                    string name = invalidFilterProperties.Item1;

                    var jProperty = invalidFilterProperties.Item2;
                    if ((jProperty != null) && (jProperty.Value != null))
                    {
                        var jToken = (jProperty.Value);
                        if (jToken != null)
                        {
                            if (jToken.Type == JTokenType.Array)
                            {
                                jToken = jToken.Children().FirstOrDefault();
                            }
                            name = jToken.HasValues && jToken.Last != null ? jToken.Last.Path : jToken.Path;
                        }
                    }

                    switch (invalidFilterProperties.Item3)
                    {
                        case InvalidFilterType.QueryParameter:
                            retval = string.Concat(retval, "'", name, "' is an invalid query parameter for filtering. ");
                            break;
                        case InvalidFilterType.Property:
                            retval = string.Concat(retval, "'", name, "' is an invalid property on the schema. ");
                            break;
                        case InvalidFilterType.Enumeration:
                            name = invalidFilterProperties.Item4;
                            retval = string.Concat(retval, "'", name, "' is an invalid enumeration value. ");
                            break;
                        case InvalidFilterType.InvalidFilterOperator:
                            name = invalidFilterProperties.Item4;
                            retval = "Invalid filter operator."; // string.Concat(retval, "'", name, "' is an invalid filter operator. ");
                            break;
                        case InvalidFilterType.UnsupportedFilterOperator:
                            name = invalidFilterProperties.Item4;
                            retval = "Unsupported filter operator."; // string.Concat(retval, "'", name, "' is an unsupported filter operator. ");
                            break;
                        case InvalidFilterType.DataType:
                            retval = string.Concat(retval, "'", name, "' is an invalid data type. ");
                            break;
                        default:
                            retval = string.Concat(retval, "Invalid filter parameter or enumeration value: ", name, ". ");
                            break;
                    }
                }
            }
            return retval;
        }

        /// <summary>
        ///  Determine if a property, or its children, are valid for the filterGroup
        /// </summary>
        /// <param name="jToken"></param>
        /// <param name="jProperty"></param>
        /// <param name="memberInfo"></param>
        /// <returns></returns>
        private bool IsInvalidFilterPropertyFound(JToken jToken, JProperty jProperty, FilterMemberInfo memberInfo)
        {
            if ((jToken == null) || (jProperty == null) || (memberInfo == null))
                return false;

            bool found = false;

            if (IsNullableType(memberInfo.Type))
                memberInfo.Type = Nullable.GetUnderlyingType(memberInfo.Type);

            if ((IsInvalidDataType(jToken, memberInfo.Type)) && (IsContainedInFilterGroup(jProperty, memberInfo)))
            {
                AddInvalidFilterProperty(jProperty, InvalidFilterType.DataType);
                return true;

            }

            if (memberInfo.Type.BaseType == typeof(System.Enum))
            {
                if (!IsContainedInFilterGroup(jProperty, memberInfo))
                {
                    AddInvalidFilterProperty(jProperty, InvalidFilterType.Property);
                    return true;
                }              
               if (!ValidateEnum(memberInfo.Type, jToken.ToString()))
                {
                    AddInvalidFilterProperty(jProperty, InvalidFilterType.Enumeration, jToken.ToString());
                    return true;
                }
                else return false;
            }
            
            if (memberInfo.IsPrimitive)
            {
                if (!IsContainedInFilterGroup(jProperty, memberInfo))
                {
                    AddInvalidFilterProperty(jProperty, InvalidFilterType.Property);
                    return true;
                }
                else return false;
            }

            var tokenChildren = new JObject();

            foreach (JToken token in jToken.Children())
            {
                if (token.Type == JTokenType.Object)
                {
                    tokenChildren = ((JObject)token);
                }
                else if (token.Type == JTokenType.Property)
                {
                    var property = token as JProperty; //current level property
                    tokenChildren.Add((JContainer)token);
                }
                else
                {
                    if (token.Type != JTokenType.String)
                        tokenChildren.Add(token);
                }
            }
            // if this is a parent - and we determine its a member of a filter group, then 
            // make sure its a valid group
            if (memberInfo.FilterCollection.Any())
            {
                if (!IsContainedInFilterGroup(jProperty, memberInfo))
                {
                    AddInvalidFilterProperty(jProperty, InvalidFilterType.Property);
                    return true;
                }
                else return false;
            }
            //otherwise, if it has children, determine if they should be included.
            else if (tokenChildren.Count > 0)
            {
               
                foreach (var prop in tokenChildren.Properties())
                {
                    var childTokenMember = this.GetPropertyInfo(memberInfo.Type, prop.Name, false);  

                    if (IsInvalidFilterPropertyFound(prop.Value, prop, childTokenMember))
                            return true;
                }
            }
            return found;
        }

        /// <summary>
        /// Converts filter string value to enum value.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public TEnum GetEnumFromEnumMemberAttribute<TEnum>(string value, TEnum defaultValue) where TEnum : struct
        {
            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            TEnum result;
            var enumType = typeof(TEnum);
            foreach (var enumName in Enum.GetNames(enumType))
            {
                var fieldInfo = enumType.GetField(enumName);
                var enumMemberAttribute = ((EnumMemberAttribute[])fieldInfo.GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
                if (enumMemberAttribute != null && enumMemberAttribute.Value == value)
                {
                    return Enum.TryParse(enumName, true, out result) ? result : defaultValue;
                }
            }
            throw new Exception(string.Format("Invalid Enumeration value: {0}", value));
        }

        /// <summary>
        ///  ValidateEnum
        /// </summary>
        /// <param name="T">type</param>
        /// <param name="value">value</param>
        /// <returns></returns>
        public bool ValidateEnum(Type T, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }
            foreach (var enumName in Enum.GetNames(T))
            {
                var fieldInfo = T.GetField(enumName);

                if (fieldInfo != null)
                {
                    if ((!string.IsNullOrEmpty(fieldInfo.Name)) && (fieldInfo.Name == value))
                    {
                        return true;
                    }
                    var enumMemberAttribute = ((EnumMemberAttribute[])fieldInfo.GetCustomAttributes(typeof(EnumMemberAttribute), true)).FirstOrDefault();
                    if (enumMemberAttribute != null && enumMemberAttribute.Value.ToLower() == value.ToLower())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Determines if the token is the correct data type for the property
        /// </summary>
        /// <param name="jToken"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private bool IsInvalidDataType(JToken jToken, Type type)
        {
            bool retval = false;

            if ((jToken == null) || (type == null) || JTokenIsNullOrEmpty(jToken))
            {
                return retval;
            }

            if (jToken.Type == JTokenType.Array)
            {
              
                foreach (var prop in jToken.Children())
                {
                    if (IsInvalidDataType(prop, type))
                        return true;

                }
            }
            if (IsNullableType(type))
                type = Nullable.GetUnderlyingType(type);

            DateTime dateValue;
            if ((type == typeof(DateTime))
                   && (!DateTime.TryParse(jToken.ToString(), out dateValue)))
            {
                return true;
            }
            DateTimeOffset dateoffsetValue;
            if ((type == typeof(DateTimeOffset))
                   && (!DateTimeOffset.TryParse(jToken.ToString(), out dateoffsetValue)))
            {
                return true;
            }

            switch (jToken.Type)
            {
                case JTokenType.Integer:
                    if (type != typeof(int))
                        retval = true;
                    break;
                case JTokenType.String:
                    if (type == typeof(int))
                        retval = true;
                    break;
                case JTokenType.Date:
                    if ((type != typeof(DateTime))
                        && (type != typeof(DateTimeOffset)))
                        retval = true;
                    break;
                default:                    
                    break;
            }

            if (jToken.Type != JTokenType.Object)
            {
                try
                {
                    if (jToken.Type == JTokenType.String)
                    {
                        //If its a list -then we need to get the type
                        if ((type.GetTypeInfo().IsGenericType) && ((type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                         || type.GetGenericTypeDefinition() == typeof(List<>)))
                        {
                            type = type.GetGenericArguments()[0];
                            if (type != null && IsNullableType(type))
                                type = Nullable.GetUnderlyingType(type);
                        }
                    }
                    if ((type != null) && (type.BaseType != typeof(System.Enum)))
                    {
                        var obj = jToken.ToObject(type);
                        if (obj == null)
                        {
                            retval = true;
                        }
                    }
                }

                catch
                {
                    retval = true;
                }
            }
            return retval;
        }

        /// <summary>
        /// Is Nullable Type
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        private bool IsNullableType(Type t)
        {
            if ((t == null) || (!t.IsGenericType))
            {
                return false;
            }
            return t.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        /// <summary>
        /// Is the property filter attribute set to ignore
        /// </summary>
        /// <param name="memberInfo"></param>
        /// <returns></returns>
        private bool IsPropertyIgnored(FilterMemberInfo memberInfo)
         {
            bool ignored = false;
            if (memberInfo == null || memberInfo.FilterCollection == null)
                return ignored;

            foreach (KeyValuePair<List<string>, bool> kvp in memberInfo.FilterCollection)
            {
                if ((kvp.Value) && (this._filterGroups.Intersect(kvp.Key).Any()))
                    ignored = true;
            }
            return ignored;
        }

        /// <summary>
        ///  Review the the collection of filters, the attribute is associated with, to determine
        ///  if its valid for this filterConverter
        /// </summary>
        /// <param name="jProperty"></param>
        /// <param name="memberInfo"></param>
        /// <returns></returns>
        private bool IsContainedInFilterGroup(JProperty jProperty, FilterMemberInfo memberInfo)
        {
            bool found = true;

            if (jProperty == null)
                return true;
            if (memberInfo.FilterCollection == null || !(memberInfo.FilterCollection.Any()))
            {
                return false;
            }
            foreach (KeyValuePair<List<string>, bool> kvp in memberInfo.FilterCollection)
            {
                // if the filter attribute is not set to ignore, then check if its in the filter group
                if ((!kvp.Value) && (!this._filterGroups.Intersect(kvp.Key).Any()))
                {
                    AddInvalidFilterProperty(jProperty, InvalidFilterType.QueryParameter);
                    found = false;
                }
            }
            return found;
        }

     
        /// <summary>
        /// Determine if a property is on a dto object by looking at datamember and jsonproperty attributes.
        /// If found, determine which filters the property is associated with
        /// </summary>
        /// <param name="modelType"></param>
        /// <param name="memberName"></param>
        /// <param name="isChild"></param>
        /// <returns>FilterMemberInfo</returns>
        private FilterMemberInfo GetPropertyInfo(Type modelType, string memberName, bool isChild = false)
        {
            FilterMemberInfo filterMemberInfo = null;
            var filterAttributes = new List<string>();
            var filterAttributesDict = new Dictionary<List<string>, bool>();
            var supportedFilterDict = new Dictionary<List<string>, List<string>>();

            bool isPrimative = false;
            try
            {
                //If its a list - then we need to get the type
                if ((modelType.GetTypeInfo().IsGenericType) && ((modelType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                 || modelType.GetGenericTypeDefinition() == typeof(List<>)))
                {
                    modelType = modelType.GetGenericArguments()[0];
                }

                //if (IsNullableType(modelType))
                //   modelType = Nullable.GetUnderlyingType(modelType);

                var properties = modelType.GetProperties();

                PropertyInfo matchingProperty = properties
                    .FirstOrDefault(p => Attribute.IsDefined(p, typeof(DataMemberAttribute))
                     && (((DataMemberAttribute)Attribute.GetCustomAttribute(
                                     p, typeof(DataMemberAttribute))).Name != null)
                     && (((DataMemberAttribute)Attribute.GetCustomAttribute(
                                     p, typeof(DataMemberAttribute))).Name.ToLower() == memberName.ToLower()));

                if (matchingProperty == null)
                {
                    matchingProperty = properties
                   .FirstOrDefault(p => Attribute.IsDefined(p, typeof(JsonPropertyAttribute))
                   && (((JsonPropertyAttribute)Attribute.GetCustomAttribute(
                                    p, typeof(JsonPropertyAttribute))).PropertyName != null)
                   && (((JsonPropertyAttribute)Attribute.GetCustomAttribute(
                                    p, typeof(JsonPropertyAttribute))).PropertyName.ToLower() == memberName.ToLower()
                                    ));
                }

                if (matchingProperty != null)
                {
                    var matchingFilterAttributes = matchingProperty.GetCustomAttributes(typeof(FilterPropertyAttribute), false);

                    foreach (FilterPropertyAttribute matchingFilterAttribute in matchingFilterAttributes)
                    {
                        if (matchingFilterAttribute != null)
                        {
                            filterAttributes = (matchingFilterAttribute.Name).ToList();
                            filterAttributesDict.Add(filterAttributes, matchingFilterAttribute.Ignore);

                            if ((matchingFilterAttribute.SupportedOperators != null))
                            {
                                supportedFilterDict.Add((matchingFilterAttribute.Name).ToList(), (matchingFilterAttribute.SupportedOperators).ToList());
                            }
                        }
                    }

                    var type = isChild ? matchingProperty.DeclaringType : matchingProperty.PropertyType;

                    var propertyType = matchingProperty.PropertyType;
                    if (IsNullableType(propertyType))
                       propertyType = Nullable.GetUnderlyingType(matchingProperty.PropertyType);
                    if (propertyType.IsPrimitive || propertyType == typeof(string) 
                        || propertyType == typeof(DateTime) || propertyType == typeof(DateTimeOffset))
                    {
                        isPrimative = true;
                    }

                    var converters = matchingProperty.GetCustomAttributes(typeof(JsonConverterAttribute), false);

                    var converter = (JsonConverterAttribute)matchingProperty.GetCustomAttribute(typeof(JsonConverterAttribute), false);
                    if (converter != null)
                    {
                        var converterType = (JsonConverter)Activator.CreateInstance(converter.ConverterType, converter.ConverterParameters);
                        return new FilterMemberInfo(filterAttributesDict, type, matchingProperty.Name, isPrimative, converterType, supportedOperators: supportedFilterDict);
                    }
                    filterMemberInfo = new FilterMemberInfo(filterAttributesDict, type, matchingProperty.Name, isPrimative, supportedOperators: supportedFilterDict);

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
            return filterMemberInfo;
        }

        /// <summary>
        /// Property associated with filter attributes
        /// </summary>
        public class FilterMemberInfo
        {
            /// <summary>
            /// The collection of filters the property is associated with
            /// (example: criteria, namedQuery).   The dictionary also includes a flag
            /// indicating if the filter should be ignored in the resources output
            /// </summary>
            public Dictionary<List<string>, bool> FilterCollection { get; set; }

            /// <summary>
            /// Property name selection qualifier.
            /// </summary>
            public string FilterCriteria { get; set; }

            /// <summary>
            /// Supported advanced filter operators
            /// </summary>
            public Dictionary<List<string>, List<string>> SupportedOperators { get; set; }

            /// <summary>
            /// Property Type
            /// </summary>
            public Type Type { get; set; }
            
            /// <summary>
            /// Property Name
            /// </summary>
            public string PropertyName { get; set; }
          
            /// <summary>
            /// Instance of the jsonConverter
            /// </summary>
            public JsonConverter JsonConverter { get; set; }

            /// <summary>
            /// Does the property have any children
            /// </summary>
            public bool IsPrimitive { get; set; }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="filterCollection"></param>
            /// <param name="type"></param>
            /// <param name="propertyName"></param>   
            /// <param name="jsonConverter"></param>
            /// <param name="supportedOperators"></param>
            /// <param name="isPrimitive"></param>
            public FilterMemberInfo(Dictionary<List<string>, bool> filterCollection,
                Type type, string propertyName, bool isPrimitive = false,
                JsonConverter jsonConverter = null, Dictionary<List<string>, List<string>> supportedOperators = null)
            {
                FilterCollection = filterCollection;
                Type = type;
                PropertyName = propertyName;
                JsonConverter = jsonConverter;
                IsPrimitive = isPrimitive;
                SupportedOperators = supportedOperators;
            }
        }

        /// <summary>
        /// Enuemration for Invalid Filter Types
        /// </summary>
        public enum InvalidFilterType
        {
            /// <summary>
            /// Default
            /// </summary>
            NotSet,
            /// <summary>
            /// Invalid Data Type
            /// </summary>
            DataType,
            /// <summary>
            /// Invalid Property
            /// </summary>
            Property,
            /// <summary>
            /// Invalid Enumeration
            /// </summary>
            Enumeration,
            /// <summary>
            /// Invalid Query Parameter
            /// </summary>
            QueryParameter,
            /// <summary>
            ///Invalid Filter Operator
            /// </summary>
            InvalidFilterOperator,
            /// <summary>
            /// Unsupported Filter Operator
            /// </summary>
            UnsupportedFilterOperator
        }
    }
}
