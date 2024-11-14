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
    /// &#x60;Any&#x60; contains an arbitrary serialized protocol buffer message along with a URL that describes the type of the serialized message.  Protobuf library provides support to pack/unpack Any values in the form of utility functions or additional generated methods of the Any type.  Example 1: Pack and unpack a message in C++.      Foo foo &#x3D; ...;     Any any;     any.PackFrom(foo);     ...     if (any.UnpackTo(&amp;foo)) {       ...     }  Example 2: Pack and unpack a message in Java.      Foo foo &#x3D; ...;     Any any &#x3D; Any.pack(foo);     ...     if (any.is(Foo.class)) {       foo &#x3D; any.unpack(Foo.class);     }  Example 3: Pack and unpack a message in Python.      foo &#x3D; Foo(...)     any &#x3D; Any()     any.Pack(foo)     ...     if any.Is(Foo.DESCRIPTOR):       any.Unpack(foo)       ...  Example 4: Pack and unpack a message in Go       foo :&#x3D; &amp;pb.Foo{...}      any, err :&#x3D; anypb.New(foo)      if err !&#x3D; nil {        ...      }      ...      foo :&#x3D; &amp;pb.Foo{}      if err :&#x3D; any.UnmarshalTo(foo); err !&#x3D; nil {        ...      }  The pack methods provided by protobuf library will by default use &#39;type.googleapis.com/full.type.name&#39; as the type URL and the unpack methods only use the fully qualified type name after the last &#39;/&#39; in the type URL, for example \&quot;foo.bar.com/x/y.z\&quot; will yield type name \&quot;y.z\&quot;.   JSON  The JSON representation of an &#x60;Any&#x60; value uses the regular representation of the deserialized, embedded message, with an additional field &#x60;@type&#x60; which contains the type URL. Example:      package google.profile;     message Person {       string first_name &#x3D; 1;       string last_name &#x3D; 2;     }      {       \&quot;@type\&quot;: \&quot;type.googleapis.com/google.profile.Person\&quot;,       \&quot;firstName\&quot;: &lt;string&gt;,       \&quot;lastName\&quot;: &lt;string&gt;     }  If the embedded message type is well-known and has a custom JSON representation, that representation will be embedded adding a field &#x60;value&#x60; which holds the custom JSON in addition to the &#x60;@type&#x60; field. Example (for message [google.protobuf.Duration][]):      {       \&quot;@type\&quot;: \&quot;type.googleapis.com/google.protobuf.Duration\&quot;,       \&quot;value\&quot;: \&quot;1.212s\&quot;     }
    /// </summary>
    [DataContract(Name = "protobufAny")]
    public partial class ProtobufAny : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtobufAny" /> class.
        /// </summary>
        /// <param name="type">A URL/resource name that uniquely identifies the type of the serialized protocol buffer message. This string must contain at least one \&quot;/\&quot; character. The last segment of the URL&#39;s path must represent the fully qualified name of the type (as in &#x60;path/google.protobuf.Duration&#x60;). The name should be in a canonical form (e.g., leading \&quot;.\&quot; is not accepted).  In practice, teams usually precompile into the binary all types that they expect it to use in the context of Any. However, for URLs which use the scheme &#x60;http&#x60;, &#x60;https&#x60;, or no scheme, one can optionally set up a type server that maps type URLs to message definitions as follows:  * If no scheme is provided, &#x60;https&#x60; is assumed. * An HTTP GET on the URL must yield a [google.protobuf.Type][]   value in binary format, or produce an error. * Applications are allowed to cache lookup results based on the   URL, or have them precompiled into a binary to avoid any   lookup. Therefore, binary compatibility needs to be preserved   on changes to types. (Use versioned type names to manage   breaking changes.)  Note: this functionality is not currently available in the official protobuf release, and it is not used for type URLs beginning with type.googleapis.com.  Schemes other than &#x60;http&#x60;, &#x60;https&#x60; (or the empty scheme) might be used with implementation specific semantics..</param>
        public ProtobufAny(string type = default(string))
        {
            this.Type = type;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A URL/resource name that uniquely identifies the type of the serialized protocol buffer message. This string must contain at least one \&quot;/\&quot; character. The last segment of the URL&#39;s path must represent the fully qualified name of the type (as in &#x60;path/google.protobuf.Duration&#x60;). The name should be in a canonical form (e.g., leading \&quot;.\&quot; is not accepted).  In practice, teams usually precompile into the binary all types that they expect it to use in the context of Any. However, for URLs which use the scheme &#x60;http&#x60;, &#x60;https&#x60;, or no scheme, one can optionally set up a type server that maps type URLs to message definitions as follows:  * If no scheme is provided, &#x60;https&#x60; is assumed. * An HTTP GET on the URL must yield a [google.protobuf.Type][]   value in binary format, or produce an error. * Applications are allowed to cache lookup results based on the   URL, or have them precompiled into a binary to avoid any   lookup. Therefore, binary compatibility needs to be preserved   on changes to types. (Use versioned type names to manage   breaking changes.)  Note: this functionality is not currently available in the official protobuf release, and it is not used for type URLs beginning with type.googleapis.com.  Schemes other than &#x60;http&#x60;, &#x60;https&#x60; (or the empty scheme) might be used with implementation specific semantics.
        /// </summary>
        /// <value>A URL/resource name that uniquely identifies the type of the serialized protocol buffer message. This string must contain at least one \&quot;/\&quot; character. The last segment of the URL&#39;s path must represent the fully qualified name of the type (as in &#x60;path/google.protobuf.Duration&#x60;). The name should be in a canonical form (e.g., leading \&quot;.\&quot; is not accepted).  In practice, teams usually precompile into the binary all types that they expect it to use in the context of Any. However, for URLs which use the scheme &#x60;http&#x60;, &#x60;https&#x60;, or no scheme, one can optionally set up a type server that maps type URLs to message definitions as follows:  * If no scheme is provided, &#x60;https&#x60; is assumed. * An HTTP GET on the URL must yield a [google.protobuf.Type][]   value in binary format, or produce an error. * Applications are allowed to cache lookup results based on the   URL, or have them precompiled into a binary to avoid any   lookup. Therefore, binary compatibility needs to be preserved   on changes to types. (Use versioned type names to manage   breaking changes.)  Note: this functionality is not currently available in the official protobuf release, and it is not used for type URLs beginning with type.googleapis.com.  Schemes other than &#x60;http&#x60;, &#x60;https&#x60; (or the empty scheme) might be used with implementation specific semantics.</value>
        [DataMember(Name = "@type", EmitDefaultValue = false)]
        public string Type { get; set; }

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
            sb.Append("class ProtobufAny {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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