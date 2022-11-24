using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchSetRecordSetsStatusResponse : SdkResponse
    {

        /// <summary>
        /// 待删除zone类型，当前仅支持 public 或 private
        /// </summary>
        [JsonProperty("recordsets", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecordsetData> Recordsets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metedata Metadata { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSetRecordSetsStatusResponse {\n");
            sb.Append("  recordsets: ").Append(Recordsets).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSetRecordSetsStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSetRecordSetsStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Recordsets == input.Recordsets ||
                    this.Recordsets != null &&
                    input.Recordsets != null &&
                    this.Recordsets.SequenceEqual(input.Recordsets)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Recordsets != null)
                    hashCode = hashCode * 59 + this.Recordsets.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
