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
    /// 
    /// </summary>
    public class WorkTableIssuseListResponseBodyIssueList 
    {

        /// <summary>
        /// 工作项id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 工作项标题
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 父工作项id
        /// </summary>
        [JsonProperty("parent_issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentIssueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parent_issue", NullValueHandling = NullValueHandling.Ignore)]
        public WorkTableIssuseListResponseBodyParentIssue ParentIssue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public WorkTableIssuseListResponseBodyProject Project { get; set; }

        /// <summary>
        /// 发布版本
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 发现发布版本
        /// </summary>
        [JsonProperty("find_release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string FindReleaseDev { get; set; }

        /// <summary>
        /// 工作项完成度
        /// </summary>
        [JsonProperty("done_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? DoneRatio { get; set; }

        /// <summary>
        /// 预计工时
        /// </summary>
        [JsonProperty("expected_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ExpectedWorkHours { get; set; }

        /// <summary>
        /// 实际工时
        /// </summary>
        [JsonProperty("actual_work_hours", NullValueHandling = NullValueHandling.Ignore)]
        public double? ActualWorkHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tracker", NullValueHandling = NullValueHandling.Ignore)]
        public WorkTableIssuseListResponseBodyTracker Tracker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public WorkTableIssuseListResponseBodyOrder Order { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public WorkTableIssuseListResponseBodySeverity Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public WorkTableIssuseListResponseBodyPriority Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public WorkTableIssuseListResponseBodyDomain Domain { get; set; }

        /// <summary>
        /// 排序数值
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public double? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public WorkTableIssuseListResponseBodyModule Module { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assigned_to", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleUserIn AssignedTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleUserIn Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("developer", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleUserIn Developer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("closeder", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleUserIn Closeder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public WorkTableIssuseListResponseBodyStatus Status { get; set; }

        /// <summary>
        /// 是否删除工作项
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// 是否关注工作项
        /// </summary>
        [JsonProperty("is_watcher", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWatcher { get; set; }

        /// <summary>
        /// 关闭标志
        /// </summary>
        [JsonProperty("closed_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClosedFlag { get; set; }

        /// <summary>
        /// 工作项新建时间戳
        /// </summary>
        [JsonProperty("created_on", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// 工作项更新时间戳
        /// </summary>
        [JsonProperty("updated_on", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedOn { get; set; }

        /// <summary>
        /// 工作项预计结束时间戳
        /// </summary>
        [JsonProperty("due_date", NullValueHandling = NullValueHandling.Ignore)]
        public string DueDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkTableIssuseListResponseBodyIssueList {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  parentIssueId: ").Append(ParentIssueId).Append("\n");
            sb.Append("  parentIssue: ").Append(ParentIssue).Append("\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  findReleaseDev: ").Append(FindReleaseDev).Append("\n");
            sb.Append("  doneRatio: ").Append(DoneRatio).Append("\n");
            sb.Append("  expectedWorkHours: ").Append(ExpectedWorkHours).Append("\n");
            sb.Append("  actualWorkHours: ").Append(ActualWorkHours).Append("\n");
            sb.Append("  tracker: ").Append(Tracker).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  assignedTo: ").Append(AssignedTo).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  developer: ").Append(Developer).Append("\n");
            sb.Append("  closeder: ").Append(Closeder).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  isWatcher: ").Append(IsWatcher).Append("\n");
            sb.Append("  closedFlag: ").Append(ClosedFlag).Append("\n");
            sb.Append("  createdOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  updatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  dueDate: ").Append(DueDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkTableIssuseListResponseBodyIssueList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkTableIssuseListResponseBodyIssueList input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.ParentIssueId != input.ParentIssueId || (this.ParentIssueId != null && !this.ParentIssueId.Equals(input.ParentIssueId))) return false;
            if (this.ParentIssue != input.ParentIssue || (this.ParentIssue != null && !this.ParentIssue.Equals(input.ParentIssue))) return false;
            if (this.Project != input.Project || (this.Project != null && !this.Project.Equals(input.Project))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.FindReleaseDev != input.FindReleaseDev || (this.FindReleaseDev != null && !this.FindReleaseDev.Equals(input.FindReleaseDev))) return false;
            if (this.DoneRatio != input.DoneRatio || (this.DoneRatio != null && !this.DoneRatio.Equals(input.DoneRatio))) return false;
            if (this.ExpectedWorkHours != input.ExpectedWorkHours || (this.ExpectedWorkHours != null && !this.ExpectedWorkHours.Equals(input.ExpectedWorkHours))) return false;
            if (this.ActualWorkHours != input.ActualWorkHours || (this.ActualWorkHours != null && !this.ActualWorkHours.Equals(input.ActualWorkHours))) return false;
            if (this.Tracker != input.Tracker || (this.Tracker != null && !this.Tracker.Equals(input.Tracker))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.Position != input.Position || (this.Position != null && !this.Position.Equals(input.Position))) return false;
            if (this.Module != input.Module || (this.Module != null && !this.Module.Equals(input.Module))) return false;
            if (this.AssignedTo != input.AssignedTo || (this.AssignedTo != null && !this.AssignedTo.Equals(input.AssignedTo))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.Developer != input.Developer || (this.Developer != null && !this.Developer.Equals(input.Developer))) return false;
            if (this.Closeder != input.Closeder || (this.Closeder != null && !this.Closeder.Equals(input.Closeder))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Deleted != input.Deleted || (this.Deleted != null && !this.Deleted.Equals(input.Deleted))) return false;
            if (this.IsWatcher != input.IsWatcher || (this.IsWatcher != null && !this.IsWatcher.Equals(input.IsWatcher))) return false;
            if (this.ClosedFlag != input.ClosedFlag || (this.ClosedFlag != null && !this.ClosedFlag.Equals(input.ClosedFlag))) return false;
            if (this.CreatedOn != input.CreatedOn || (this.CreatedOn != null && !this.CreatedOn.Equals(input.CreatedOn))) return false;
            if (this.UpdatedOn != input.UpdatedOn || (this.UpdatedOn != null && !this.UpdatedOn.Equals(input.UpdatedOn))) return false;
            if (this.DueDate != input.DueDate || (this.DueDate != null && !this.DueDate.Equals(input.DueDate))) return false;

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
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.ParentIssueId != null) hashCode = hashCode * 59 + this.ParentIssueId.GetHashCode();
                if (this.ParentIssue != null) hashCode = hashCode * 59 + this.ParentIssue.GetHashCode();
                if (this.Project != null) hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.FindReleaseDev != null) hashCode = hashCode * 59 + this.FindReleaseDev.GetHashCode();
                if (this.DoneRatio != null) hashCode = hashCode * 59 + this.DoneRatio.GetHashCode();
                if (this.ExpectedWorkHours != null) hashCode = hashCode * 59 + this.ExpectedWorkHours.GetHashCode();
                if (this.ActualWorkHours != null) hashCode = hashCode * 59 + this.ActualWorkHours.GetHashCode();
                if (this.Tracker != null) hashCode = hashCode * 59 + this.Tracker.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Position != null) hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Module != null) hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.AssignedTo != null) hashCode = hashCode * 59 + this.AssignedTo.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Developer != null) hashCode = hashCode * 59 + this.Developer.GetHashCode();
                if (this.Closeder != null) hashCode = hashCode * 59 + this.Closeder.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Deleted != null) hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.IsWatcher != null) hashCode = hashCode * 59 + this.IsWatcher.GetHashCode();
                if (this.ClosedFlag != null) hashCode = hashCode * 59 + this.ClosedFlag.GetHashCode();
                if (this.CreatedOn != null) hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.UpdatedOn != null) hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.DueDate != null) hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
