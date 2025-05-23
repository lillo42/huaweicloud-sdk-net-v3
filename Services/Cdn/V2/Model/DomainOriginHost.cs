using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 域名回源HOST配置。
    /// </summary>
    public class DomainOriginHost 
    {

        /// <summary>
        /// 域名ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 回源host的类型,accelerate：选择加速域名作为回源host域名， customize：使用自定义的域名作为回源host域名。
        /// </summary>
        [JsonProperty("origin_host_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginHostType { get; set; }

        /// <summary>
        /// 自定义回源host域名。
        /// </summary>
        [JsonProperty("customize_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomizeDomain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainOriginHost {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  originHostType: ").Append(OriginHostType).Append("\n");
            sb.Append("  customizeDomain: ").Append(CustomizeDomain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainOriginHost);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainOriginHost input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.OriginHostType != input.OriginHostType || (this.OriginHostType != null && !this.OriginHostType.Equals(input.OriginHostType))) return false;
            if (this.CustomizeDomain != input.CustomizeDomain || (this.CustomizeDomain != null && !this.CustomizeDomain.Equals(input.CustomizeDomain))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.OriginHostType != null) hashCode = hashCode * 59 + this.OriginHostType.GetHashCode();
                if (this.CustomizeDomain != null) hashCode = hashCode * 59 + this.CustomizeDomain.GetHashCode();
                return hashCode;
            }
        }
    }
}
