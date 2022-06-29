// Copyright 2018 Ellucian Company L.P. and its affiliates.

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Ellucian.Generated.Eedm;

namespace Ellucian.Generated.Eedm.Converters
{
    /// <summary>
    /// Allows generic properties to accept either an array or single vlaue
    /// </summary>
    public class CodeTitleDetailFilterConverter<T> : JsonConverter
    {
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
            JToken token = JToken.Load(reader);
            //bool isArray = false;
            Type type = typeof(T);
            bool isList = false;

            if (token.Type == JTokenType.Array)
            {
                var value = token.ToObject<T>();
                // Verify all the properties from the query object are included.
                // JObject created from DTO property type
                var jToken = JArray.Parse(JsonConvert.SerializeObject(value)) as JArray;
                if ((jToken != null) && (!JArray.DeepEquals(jToken, token)))
                {
                    throw new Exception("Invalid Properties");
                }
                return value;
            }

            //If its a list - then we need to get the type
            if ((typeof(T).IsGenericType && (typeof(T).GetGenericTypeDefinition() == typeof(List<>))))
            {
                type = typeof(T).GetGenericArguments()[0];
                isList = true;
            }
                      
            if (reader.TokenType != JsonToken.Null)
            {
               
                if (reader.TokenType == JsonToken.String)
                {
                    JValue jValue = new JValue(reader.Value);

                    if ((type == typeof(BaseCodeTitleDetailDtoProperty))
                        || (type.BaseType == typeof(BaseCodeTitleDetailDtoProperty)))
                    {
                        if (isList)
                            token = JToken.FromObject(new List<BaseCodeTitleDetailDtoProperty>() { new BaseCodeTitleDetailDtoProperty()
                            { Detail = new GuidObject2(jValue.ToString()) } });
                        else
                            token = JToken.FromObject(new BaseCodeTitleDetailDtoProperty()
                            { Detail = new GuidObject2(jValue.ToString()) });
                    }
                    else if (type == typeof(GuidObject2))
                    {
                        if (isList)
                            token = JToken.FromObject(new List<GuidObject2>() { new GuidObject2(jValue.ToString()) });
                        else
                            token = JToken.FromObject(new GuidObject2(jValue.ToString()));
                    }
                    else if (type == typeof(CourseDtoProperty))
                    {
                        token = JToken.FromObject(new CourseDtoProperty()
                        { Detail = new GuidObject2(jValue.ToString()) });
                    }
                    else if ((type == typeof(OwningOrganizationDtoProperty))
                        || (type.BaseType == typeof(OwningOrganizationDtoProperty)))
                    {
                        if (isList)
                            token = JToken.FromObject(new List<OwningOrganizationDtoProperty>() { new  OwningOrganizationDtoProperty()
                            { Detail = new GuidObject2(jValue.ToString()) } });
                        else
                            token = JToken.FromObject(new OwningOrganizationDtoProperty()
                            { Detail = new GuidObject2(jValue.ToString()) });
                    }
                   
                    if (isList)
                    {
                        var value = token.ToObject<T>();
                        // Verify all the properties from the query object are included.
                        // JObject created from DTO property type
                        var jToken = JArray.Parse(JsonConvert.SerializeObject(value)) as JArray;
                        if ((jToken != null) && (!JArray.DeepEquals(jToken, token)))
                        {
                            throw new Exception("Invalid Properties");
                        }
                        return value;
                    }
                    else 
                    {
                        var value = token.ToObject<T>();
                        // Verify all the properties from the query object are included.
                        // JObject created from DTO property type
                        var jToken = JToken.Parse(JsonConvert.SerializeObject(value)) as JToken;
                        if ((jToken != null) && (!JObject.DeepEquals(jToken, token)))
                        {
                            throw new Exception("Invalid Properties");
                        }
                        return value;
                    }
                }
                else if (objectType == typeof(T))
                {
                    var value = token.ToObject<T>();

                    // Verify all the properties from the query object are included.
                    // JObject created from DTO property type
                    var jObject = JToken.Parse(JsonConvert.SerializeObject(value)) as JToken;
                    if ((jObject != null) && (!JObject.DeepEquals(jObject, token)))
                    {
                        throw new Exception("Invalid Properties");
                    }
                    return value;
                }
            }
           
          return token.ToObject<T>() ;
        }

        /// <summary>
        /// CanConvert
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return true; //(objectType == typeof(List<T>));
        }

        /// <summary>
        /// CanWrite
        /// </summary>
        public override bool CanWrite { get { return false; } }

        /// <summary>
        /// WriteJson
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException(); //This will never be called since CanWrite is false
        }
    }
}