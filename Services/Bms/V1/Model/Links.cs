using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// links字段数据结构说明
    /// </summary>
    public class Links 
    {

        /// <summary>
        /// 快捷链接标记名称
        /// </summary>
        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public string Rel { get; set; }

        /// <summary>
        /// 对应快捷链接
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Links {\n");
            sb.Append("  rel: ").Append(Rel).Append("\n");
            sb.Append("  href: ").Append(Href).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Links);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Links input)
        {
            if (input == null) return false;
            if (this.Rel != input.Rel || (this.Rel != null && !this.Rel.Equals(input.Rel))) return false;
            if (this.Href != input.Href || (this.Href != null && !this.Href.Equals(input.Href))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Rel != null) hashCode = hashCode * 59 + this.Rel.GetHashCode();
                if (this.Href != null) hashCode = hashCode * 59 + this.Href.GetHashCode();
                return hashCode;
            }
        }
    }
}
