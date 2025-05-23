using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EipOperateProtectReqIpInfos 
    {

        /// <summary>
        /// 弹性公网IP ID，可通过调用弹性IP列表查询接口获得，通过返回值中的data.records.id（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 弹性公网IP IPv4地址，可通过调用弹性IP列表查询接口获得，通过返回值中的data.records.public_ip（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 弹性公网IP IPv6地址，可通过调用弹性IP列表查询接口获得，通过返回值中的data.records.public_ipv6（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("public_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpv6 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipOperateProtectReqIpInfos {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  publicIpv6: ").Append(PublicIpv6).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipOperateProtectReqIpInfos);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipOperateProtectReqIpInfos input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.PublicIpv6 != input.PublicIpv6 || (this.PublicIpv6 != null && !this.PublicIpv6.Equals(input.PublicIpv6))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.PublicIpv6 != null) hashCode = hashCode * 59 + this.PublicIpv6.GetHashCode();
                return hashCode;
            }
        }
    }
}
