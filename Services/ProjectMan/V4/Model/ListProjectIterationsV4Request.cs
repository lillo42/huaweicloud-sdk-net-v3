using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListProjectIterationsV4Request 
    {

        /// <summary>
        /// devcloud的项目id
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 更新迭代的时间(查询的起始时间,查询的结束时间)
        /// </summary>
        [SDKProperty("updated_time_interval", IsQuery = true)]
        [JsonProperty("updated_time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedTimeInterval { get; set; }

        /// <summary>
        /// 是否包含被删除的迭代,默认false不包含被删除的迭代
        /// </summary>
        [SDKProperty("include_deleted", IsQuery = true)]
        [JsonProperty("include_deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeDeleted { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProjectIterationsV4Request {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  updatedTimeInterval: ").Append(UpdatedTimeInterval).Append("\n");
            sb.Append("  includeDeleted: ").Append(IncludeDeleted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProjectIterationsV4Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProjectIterationsV4Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.UpdatedTimeInterval == input.UpdatedTimeInterval ||
                    (this.UpdatedTimeInterval != null &&
                    this.UpdatedTimeInterval.Equals(input.UpdatedTimeInterval))
                ) && 
                (
                    this.IncludeDeleted == input.IncludeDeleted ||
                    (this.IncludeDeleted != null &&
                    this.IncludeDeleted.Equals(input.IncludeDeleted))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.UpdatedTimeInterval != null)
                    hashCode = hashCode * 59 + this.UpdatedTimeInterval.GetHashCode();
                if (this.IncludeDeleted != null)
                    hashCode = hashCode * 59 + this.IncludeDeleted.GetHashCode();
                return hashCode;
            }
        }
    }
}
