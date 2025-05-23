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
    public class DomainSetVo 
    {

        /// <summary>
        /// 域名组id
        /// </summary>
        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SetId { get; set; }

        /// <summary>
        /// 域名组名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 域名组描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 域名组被规则引用次数
        /// </summary>
        [JsonProperty("ref_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RefCount { get; set; }

        /// <summary>
        /// 域名组类型，0表示应用域名组，1表示网络域名组
        /// </summary>
        [JsonProperty("domain_set_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DomainSetType { get; set; }

        /// <summary>
        /// 配置状态，-1表示未配置态，0表示配置失败，1表示配置成功，2表示配置中，3表示正常，4表示配置异常
        /// </summary>
        [JsonProperty("config_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfigStatus { get; set; }

        /// <summary>
        /// 使用规则id列表
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<UseRuleVO> Rules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainSetVo {\n");
            sb.Append("  setId: ").Append(SetId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  refCount: ").Append(RefCount).Append("\n");
            sb.Append("  domainSetType: ").Append(DomainSetType).Append("\n");
            sb.Append("  configStatus: ").Append(ConfigStatus).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainSetVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainSetVo input)
        {
            if (input == null) return false;
            if (this.SetId != input.SetId || (this.SetId != null && !this.SetId.Equals(input.SetId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RefCount != input.RefCount || (this.RefCount != null && !this.RefCount.Equals(input.RefCount))) return false;
            if (this.DomainSetType != input.DomainSetType || (this.DomainSetType != null && !this.DomainSetType.Equals(input.DomainSetType))) return false;
            if (this.ConfigStatus != input.ConfigStatus || (this.ConfigStatus != null && !this.ConfigStatus.Equals(input.ConfigStatus))) return false;
            if (this.Rules != input.Rules || (this.Rules != null && input.Rules != null && !this.Rules.SequenceEqual(input.Rules))) return false;

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
                if (this.SetId != null) hashCode = hashCode * 59 + this.SetId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RefCount != null) hashCode = hashCode * 59 + this.RefCount.GetHashCode();
                if (this.DomainSetType != null) hashCode = hashCode * 59 + this.DomainSetType.GetHashCode();
                if (this.ConfigStatus != null) hashCode = hashCode * 59 + this.ConfigStatus.GetHashCode();
                if (this.Rules != null) hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }
    }
}
