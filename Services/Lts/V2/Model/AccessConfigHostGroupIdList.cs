using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 日志接入主机组ID列表
    /// </summary>
    public class AccessConfigHostGroupIdList 
    {

        /// <summary>
        /// 主机组ID列表
        /// </summary>
        [JsonProperty("host_group_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostGroupIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessConfigHostGroupIdList {\n");
            sb.Append("  hostGroupIdList: ").Append(HostGroupIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessConfigHostGroupIdList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessConfigHostGroupIdList input)
        {
            if (input == null) return false;
            if (this.HostGroupIdList != input.HostGroupIdList || (this.HostGroupIdList != null && input.HostGroupIdList != null && !this.HostGroupIdList.SequenceEqual(input.HostGroupIdList))) return false;

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
                if (this.HostGroupIdList != null) hashCode = hashCode * 59 + this.HostGroupIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
