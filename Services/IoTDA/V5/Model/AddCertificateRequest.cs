using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class AddCertificateRequest 
    {

        /// <summary>
        /// Sp用户Token。通过调用IoBPS服务获取SP用户Token
        /// </summary>
        [SDKProperty("Sp-Auth-Token", IsHeader = true)]
        [JsonProperty("Sp-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string SpAuthToken { get; set; }

        /// <summary>
        /// Stage用户的Token, 仅提供给IoStage服务使用
        /// </summary>
        [SDKProperty("Stage-Auth-Token", IsHeader = true)]
        [JsonProperty("Stage-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string StageAuthToken { get; set; }

        /// <summary>
        /// 实例ID。物理多租下各实例的唯一标识，一般华为云租户无需携带该参数，仅在物理多租场景下从管理面访问API时需要携带该参数。
        /// </summary>
        [SDKProperty("Instance-Id", IsHeader = true)]
        [JsonProperty("Instance-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CreateCertificateDTO Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddCertificateRequest {\n");
            sb.Append("  spAuthToken: ").Append(SpAuthToken).Append("\n");
            sb.Append("  stageAuthToken: ").Append(StageAuthToken).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddCertificateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddCertificateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpAuthToken == input.SpAuthToken ||
                    (this.SpAuthToken != null &&
                    this.SpAuthToken.Equals(input.SpAuthToken))
                ) && 
                (
                    this.StageAuthToken == input.StageAuthToken ||
                    (this.StageAuthToken != null &&
                    this.StageAuthToken.Equals(input.StageAuthToken))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.SpAuthToken != null)
                    hashCode = hashCode * 59 + this.SpAuthToken.GetHashCode();
                if (this.StageAuthToken != null)
                    hashCode = hashCode * 59 + this.StageAuthToken.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
