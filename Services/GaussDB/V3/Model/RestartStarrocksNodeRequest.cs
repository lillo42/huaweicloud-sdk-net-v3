using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class RestartStarrocksNodeRequest 
    {

        /// <summary>
        /// StarRocks节点ID
        /// </summary>
        [SDKProperty("starrocks_node_id", IsPath = true)]
        [JsonProperty("starrocks_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StarrocksNodeId { get; set; }

        /// <summary>
        /// StarRocks实例ID，严格匹配UUID规则。
        /// </summary>
        [SDKProperty("starrocks_instance_id", IsPath = true)]
        [JsonProperty("starrocks_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StarrocksInstanceId { get; set; }

        /// <summary>
        /// 请求语言类型。默认en-us。 取值范围： - en-us - zh-cn
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestartStarrocksNodeRequest {\n");
            sb.Append("  starrocksNodeId: ").Append(StarrocksNodeId).Append("\n");
            sb.Append("  starrocksInstanceId: ").Append(StarrocksInstanceId).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestartStarrocksNodeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestartStarrocksNodeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StarrocksNodeId == input.StarrocksNodeId ||
                    (this.StarrocksNodeId != null &&
                    this.StarrocksNodeId.Equals(input.StarrocksNodeId))
                ) && 
                (
                    this.StarrocksInstanceId == input.StarrocksInstanceId ||
                    (this.StarrocksInstanceId != null &&
                    this.StarrocksInstanceId.Equals(input.StarrocksInstanceId))
                ) && 
                (
                    this.XLanguage == input.XLanguage ||
                    (this.XLanguage != null &&
                    this.XLanguage.Equals(input.XLanguage))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.StarrocksNodeId != null)
                    hashCode = hashCode * 59 + this.StarrocksNodeId.GetHashCode();
                if (this.StarrocksInstanceId != null)
                    hashCode = hashCode * 59 + this.StarrocksInstanceId.GetHashCode();
                if (this.XLanguage != null)
                    hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                return hashCode;
            }
        }
    }
}
