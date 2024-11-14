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
    /// ProductlistCreateProductListAssociationRequest
    /// </summary>
    [DataContract(Name = "productlistCreateProductListAssociationRequest")]
    public partial class ProductlistCreateProductListAssociationRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductlistCreateProductListAssociationRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="listId">listId.</param>
        /// <param name="position">position.</param>
        /// <param name="productGrn">productGrn.</param>
        public ProductlistCreateProductListAssociationRequest(string tenantId = default(string), string listId = default(string), int position = default(int), string productGrn = default(string))
        {
            this.TenantId = tenantId;
            this.ListId = listId;
            this.Position = position;
            this.ProductGrn = productGrn;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets ListId
        /// </summary>
        [DataMember(Name = "listId", EmitDefaultValue = false)]
        public string ListId { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public int Position { get; set; }

        /// <summary>
        /// Gets or Sets ProductGrn
        /// </summary>
        [DataMember(Name = "productGrn", EmitDefaultValue = false)]
        public string ProductGrn { get; set; }

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
            sb.Append("class ProductlistCreateProductListAssociationRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  ProductGrn: ").Append(ProductGrn).Append("\n");
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