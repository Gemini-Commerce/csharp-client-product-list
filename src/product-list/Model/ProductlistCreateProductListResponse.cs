/*
 * Collection Service
 *
 * API for managing collection
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
    /// ProductlistCreateProductListResponse
    /// </summary>
    [DataContract(Name = "productlistCreateProductListResponse")]
    public partial class ProductlistCreateProductListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductlistCreateProductListResponse" /> class.
        /// </summary>
        /// <param name="list">list.</param>
        /// <param name="errors">errors.</param>
        public ProductlistCreateProductListResponse(ProductlistProductListEntity list = default(ProductlistProductListEntity), List<ProductlistProductListError> errors = default(List<ProductlistProductListError>))
        {
            this.List = list;
            this.Errors = errors;
        }

        /// <summary>
        /// Gets or Sets List
        /// </summary>
        [DataMember(Name = "list", EmitDefaultValue = false)]
        public ProductlistProductListEntity List { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<ProductlistProductListError> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductlistCreateProductListResponse {\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
