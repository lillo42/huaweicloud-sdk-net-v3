using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateExpireAutoScanConfigResponse : SdkResponse
    {

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 是否开启自动扫描
        /// </summary>
        [JsonProperty("enable_auto_scan", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoScan { get; set; }

        /// <summary>
        /// 首次扫描时间，例如：2023-07-07T15:00:05.000
        /// </summary>
        [JsonProperty("first_scan_at", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstScanAt { get; set; }

        /// <summary>
        /// 间隔时间(秒)
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 超时时间(秒)
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 扫描数
        /// </summary>
        [JsonProperty("scan_keys_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScanKeysCount { get; set; }

        /// <summary>
        /// 更新时间，例如：2023-06-15T06:20:13.283Z
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateExpireAutoScanConfigResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  enableAutoScan: ").Append(EnableAutoScan).Append("\n");
            sb.Append("  firstScanAt: ").Append(FirstScanAt).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  scanKeysCount: ").Append(ScanKeysCount).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateExpireAutoScanConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateExpireAutoScanConfigResponse input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.EnableAutoScan != input.EnableAutoScan || (this.EnableAutoScan != null && !this.EnableAutoScan.Equals(input.EnableAutoScan))) return false;
            if (this.FirstScanAt != input.FirstScanAt || (this.FirstScanAt != null && !this.FirstScanAt.Equals(input.FirstScanAt))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.ScanKeysCount != input.ScanKeysCount || (this.ScanKeysCount != null && !this.ScanKeysCount.Equals(input.ScanKeysCount))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.EnableAutoScan != null) hashCode = hashCode * 59 + this.EnableAutoScan.GetHashCode();
                if (this.FirstScanAt != null) hashCode = hashCode * 59 + this.FirstScanAt.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.ScanKeysCount != null) hashCode = hashCode * 59 + this.ScanKeysCount.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
