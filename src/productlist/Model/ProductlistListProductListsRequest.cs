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
using OpenAPIDateConverter = productlist.Client.OpenAPIDateConverter;

namespace productlist.Model
{
    /// <summary>
    /// ProductlistListProductListsRequest
    /// </summary>
    [DataContract(Name = "productlistListProductListsRequest")]
    public partial class ProductlistListProductListsRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductlistListProductListsRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="pageToken">pageToken.</param>
        public ProductlistListProductListsRequest(string tenantId = default(string), long pageSize = default(long), string pageToken = default(string))
        {
            this.TenantId = tenantId;
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public long PageSize { get; set; }

        /// <summary>
        /// Gets or Sets PageToken
        /// </summary>
        [DataMember(Name = "pageToken", EmitDefaultValue = false)]
        public string PageToken { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductlistListProductListsRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
