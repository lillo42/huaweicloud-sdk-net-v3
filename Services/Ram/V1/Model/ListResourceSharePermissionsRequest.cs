using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListResourceSharePermissionsRequest 
    {

        /// <summary>
        /// 资源共享实例的ID。
        /// </summary>
        [SDKProperty("resource_share_id", IsPath = true)]
        [JsonProperty("resource_share_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceShareId { get; set; }

        /// <summary>
        /// 共享资源权限的名称。
        /// </summary>
        [SDKProperty("permission_name", IsQuery = true)]
        [JsonProperty("permission_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionName { get; set; }

        /// <summary>
        /// 分页页面的最大值。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 页面标记。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceSharePermissionsRequest {\n");
            sb.Append("  resourceShareId: ").Append(ResourceShareId).Append("\n");
            sb.Append("  permissionName: ").Append(PermissionName).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceSharePermissionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceSharePermissionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceShareId == input.ResourceShareId ||
                    (this.ResourceShareId != null &&
                    this.ResourceShareId.Equals(input.ResourceShareId))
                ) && 
                (
                    this.PermissionName == input.PermissionName ||
                    (this.PermissionName != null &&
                    this.PermissionName.Equals(input.PermissionName))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
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
                if (this.ResourceShareId != null)
                    hashCode = hashCode * 59 + this.ResourceShareId.GetHashCode();
                if (this.PermissionName != null)
                    hashCode = hashCode * 59 + this.PermissionName.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
