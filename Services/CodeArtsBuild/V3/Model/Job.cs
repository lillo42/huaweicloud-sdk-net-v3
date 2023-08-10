using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Job 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 任务创建者
        /// </summary>
        [JsonProperty("job_creator", NullValueHandling = NullValueHandling.Ignore)]
        public string JobCreator { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 最新执行时间
        /// </summary>
        [JsonProperty("last_build_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? LastBuildTime { get; set; }

        /// <summary>
        /// 健康分值
        /// </summary>
        [JsonProperty("health_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? HealthScore { get; set; }

        /// <summary>
        /// 代码来源
        /// </summary>
        [JsonProperty("source_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCode { get; set; }

        /// <summary>
        /// 最新构建状态
        /// </summary>
        [JsonProperty("last_build_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LastBuildStatus { get; set; }

        /// <summary>
        /// 是否已结束
        /// </summary>
        [JsonProperty("is_finished", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFinished { get; set; }

        /// <summary>
        /// 是否已禁用
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 是否已收藏
        /// </summary>
        [JsonProperty("favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Favorite { get; set; }

        /// <summary>
        /// 是否有修改任务权限
        /// </summary>
        [JsonProperty("is_modify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsModify { get; set; }

        /// <summary>
        /// 是否有删除任务权限
        /// </summary>
        [JsonProperty("is_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDelete { get; set; }

        /// <summary>
        /// 是否有执行任务权限
        /// </summary>
        [JsonProperty("is_execute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExecute { get; set; }

        /// <summary>
        /// 是否有复制任务权限
        /// </summary>
        [JsonProperty("is_copy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCopy { get; set; }

        /// <summary>
        /// 是否有禁用任务权限
        /// </summary>
        [JsonProperty("is_forbidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForbidden { get; set; }

        /// <summary>
        /// 是否有查看任务权限
        /// </summary>
        [JsonProperty("is_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsView { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Job {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  jobCreator: ").Append(JobCreator).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  lastBuildTime: ").Append(LastBuildTime).Append("\n");
            sb.Append("  healthScore: ").Append(HealthScore).Append("\n");
            sb.Append("  sourceCode: ").Append(SourceCode).Append("\n");
            sb.Append("  lastBuildStatus: ").Append(LastBuildStatus).Append("\n");
            sb.Append("  isFinished: ").Append(IsFinished).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  favorite: ").Append(Favorite).Append("\n");
            sb.Append("  isModify: ").Append(IsModify).Append("\n");
            sb.Append("  isDelete: ").Append(IsDelete).Append("\n");
            sb.Append("  isExecute: ").Append(IsExecute).Append("\n");
            sb.Append("  isCopy: ").Append(IsCopy).Append("\n");
            sb.Append("  isForbidden: ").Append(IsForbidden).Append("\n");
            sb.Append("  isView: ").Append(IsView).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Job);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Job input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.JobCreator == input.JobCreator ||
                    (this.JobCreator != null &&
                    this.JobCreator.Equals(input.JobCreator))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.LastBuildTime == input.LastBuildTime ||
                    (this.LastBuildTime != null &&
                    this.LastBuildTime.Equals(input.LastBuildTime))
                ) && 
                (
                    this.HealthScore == input.HealthScore ||
                    (this.HealthScore != null &&
                    this.HealthScore.Equals(input.HealthScore))
                ) && 
                (
                    this.SourceCode == input.SourceCode ||
                    (this.SourceCode != null &&
                    this.SourceCode.Equals(input.SourceCode))
                ) && 
                (
                    this.LastBuildStatus == input.LastBuildStatus ||
                    (this.LastBuildStatus != null &&
                    this.LastBuildStatus.Equals(input.LastBuildStatus))
                ) && 
                (
                    this.IsFinished == input.IsFinished ||
                    (this.IsFinished != null &&
                    this.IsFinished.Equals(input.IsFinished))
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    (this.Disabled != null &&
                    this.Disabled.Equals(input.Disabled))
                ) && 
                (
                    this.Favorite == input.Favorite ||
                    (this.Favorite != null &&
                    this.Favorite.Equals(input.Favorite))
                ) && 
                (
                    this.IsModify == input.IsModify ||
                    (this.IsModify != null &&
                    this.IsModify.Equals(input.IsModify))
                ) && 
                (
                    this.IsDelete == input.IsDelete ||
                    (this.IsDelete != null &&
                    this.IsDelete.Equals(input.IsDelete))
                ) && 
                (
                    this.IsExecute == input.IsExecute ||
                    (this.IsExecute != null &&
                    this.IsExecute.Equals(input.IsExecute))
                ) && 
                (
                    this.IsCopy == input.IsCopy ||
                    (this.IsCopy != null &&
                    this.IsCopy.Equals(input.IsCopy))
                ) && 
                (
                    this.IsForbidden == input.IsForbidden ||
                    (this.IsForbidden != null &&
                    this.IsForbidden.Equals(input.IsForbidden))
                ) && 
                (
                    this.IsView == input.IsView ||
                    (this.IsView != null &&
                    this.IsView.Equals(input.IsView))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.JobCreator != null)
                    hashCode = hashCode * 59 + this.JobCreator.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.LastBuildTime != null)
                    hashCode = hashCode * 59 + this.LastBuildTime.GetHashCode();
                if (this.HealthScore != null)
                    hashCode = hashCode * 59 + this.HealthScore.GetHashCode();
                if (this.SourceCode != null)
                    hashCode = hashCode * 59 + this.SourceCode.GetHashCode();
                if (this.LastBuildStatus != null)
                    hashCode = hashCode * 59 + this.LastBuildStatus.GetHashCode();
                if (this.IsFinished != null)
                    hashCode = hashCode * 59 + this.IsFinished.GetHashCode();
                if (this.Disabled != null)
                    hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.Favorite != null)
                    hashCode = hashCode * 59 + this.Favorite.GetHashCode();
                if (this.IsModify != null)
                    hashCode = hashCode * 59 + this.IsModify.GetHashCode();
                if (this.IsDelete != null)
                    hashCode = hashCode * 59 + this.IsDelete.GetHashCode();
                if (this.IsExecute != null)
                    hashCode = hashCode * 59 + this.IsExecute.GetHashCode();
                if (this.IsCopy != null)
                    hashCode = hashCode * 59 + this.IsCopy.GetHashCode();
                if (this.IsForbidden != null)
                    hashCode = hashCode * 59 + this.IsForbidden.GetHashCode();
                if (this.IsView != null)
                    hashCode = hashCode * 59 + this.IsView.GetHashCode();
                return hashCode;
            }
        }
    }
}
