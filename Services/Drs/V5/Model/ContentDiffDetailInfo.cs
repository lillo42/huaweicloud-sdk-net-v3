using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 内容对比不一致数据的详情。
    /// </summary>
    public class ContentDiffDetailInfo 
    {

        /// <summary>
        /// 数量。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }

        /// <summary>
        /// 对比不一致详情：只有源库存在。
        /// </summary>
        [JsonProperty("target_meta_is_null", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetMetaIsNull { get; set; }

        /// <summary>
        /// 对比不一致详情：只有目标库存在。
        /// </summary>
        [JsonProperty("source_meta_is_null", NullValueHandling = NullValueHandling.Ignore)]
        public long? SourceMetaIsNull { get; set; }

        /// <summary>
        /// 对比不一致详情：源和目标端均存在。
        /// </summary>
        [JsonProperty("source_target_meta_not_null", NullValueHandling = NullValueHandling.Ignore)]
        public long? SourceTargetMetaNotNull { get; set; }

        /// <summary>
        /// 信息列表。
        /// </summary>
        [JsonProperty("contents_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContentDiffDetailVO> ContentsInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentDiffDetailInfo {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  targetMetaIsNull: ").Append(TargetMetaIsNull).Append("\n");
            sb.Append("  sourceMetaIsNull: ").Append(SourceMetaIsNull).Append("\n");
            sb.Append("  sourceTargetMetaNotNull: ").Append(SourceTargetMetaNotNull).Append("\n");
            sb.Append("  contentsInfos: ").Append(ContentsInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContentDiffDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContentDiffDetailInfo input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.TargetMetaIsNull != input.TargetMetaIsNull || (this.TargetMetaIsNull != null && !this.TargetMetaIsNull.Equals(input.TargetMetaIsNull))) return false;
            if (this.SourceMetaIsNull != input.SourceMetaIsNull || (this.SourceMetaIsNull != null && !this.SourceMetaIsNull.Equals(input.SourceMetaIsNull))) return false;
            if (this.SourceTargetMetaNotNull != input.SourceTargetMetaNotNull || (this.SourceTargetMetaNotNull != null && !this.SourceTargetMetaNotNull.Equals(input.SourceTargetMetaNotNull))) return false;
            if (this.ContentsInfos != input.ContentsInfos || (this.ContentsInfos != null && input.ContentsInfos != null && !this.ContentsInfos.SequenceEqual(input.ContentsInfos))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.TargetMetaIsNull != null) hashCode = hashCode * 59 + this.TargetMetaIsNull.GetHashCode();
                if (this.SourceMetaIsNull != null) hashCode = hashCode * 59 + this.SourceMetaIsNull.GetHashCode();
                if (this.SourceTargetMetaNotNull != null) hashCode = hashCode * 59 + this.SourceTargetMetaNotNull.GetHashCode();
                if (this.ContentsInfos != null) hashCode = hashCode * 59 + this.ContentsInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
