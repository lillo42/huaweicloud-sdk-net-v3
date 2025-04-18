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
    public class EIPSwitchStatusVO 
    {

        /// <summary>
        /// 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，注意type为0的为互联网边界防护对象id，type为1的为VPC边界防护对象id。此处仅取type为0的防护对象id，可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 修改eip防护状态失败状态列表，状态包括成功\&quot;successful\&quot;，失败“fail”
        /// </summary>
        [JsonProperty("fail_eip_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FailEipIdList { get; set; }

        /// <summary>
        /// 修改eip防护状态失败信息列表
        /// </summary>
        [JsonProperty("fail_eip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<FailedEipInfo> FailEipList { get; set; }

        /// <summary>
        /// 防火墙id，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EIPSwitchStatusVO {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  failEipIdList: ").Append(FailEipIdList).Append("\n");
            sb.Append("  failEipList: ").Append(FailEipList).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EIPSwitchStatusVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EIPSwitchStatusVO input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.FailEipIdList != input.FailEipIdList || (this.FailEipIdList != null && input.FailEipIdList != null && !this.FailEipIdList.SequenceEqual(input.FailEipIdList))) return false;
            if (this.FailEipList != input.FailEipList || (this.FailEipList != null && input.FailEipList != null && !this.FailEipList.SequenceEqual(input.FailEipList))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.FailEipIdList != null) hashCode = hashCode * 59 + this.FailEipIdList.GetHashCode();
                if (this.FailEipList != null) hashCode = hashCode * 59 + this.FailEipList.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
