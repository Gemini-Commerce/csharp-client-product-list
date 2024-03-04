/*
 * Collection Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = product-list.Client.OpenAPIDateConverter;

namespace product-list.Model
{
    /// <summary>
    /// Defines OrderByDirection
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderByDirection
    {
        /// <summary>
        /// Enum DEFAULT for value: DEFAULT
        /// </summary>
        [EnumMember(Value = "DEFAULT")]
        DEFAULT = 1,

        /// <summary>
        /// Enum ASC for value: ASC
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC = 2,

        /// <summary>
        /// Enum DESC for value: DESC
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC = 3
    }

}
