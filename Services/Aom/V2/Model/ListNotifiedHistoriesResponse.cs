using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListNotifiedHistoriesResponse : SdkResponse
    {

        /// <summary>
        /// 通知历史列表。
        /// </summary>
        [JsonProperty("notified_histories", NullValueHandling = NullValueHandling.Ignore)]
        public List<NotifiedHistoriesResult> NotifiedHistories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNotifiedHistoriesResponse {\n");
            sb.Append("  notifiedHistories: ").Append(NotifiedHistories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNotifiedHistoriesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNotifiedHistoriesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotifiedHistories == input.NotifiedHistories ||
                    this.NotifiedHistories != null &&
                    input.NotifiedHistories != null &&
                    this.NotifiedHistories.SequenceEqual(input.NotifiedHistories)
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
                if (this.NotifiedHistories != null)
                    hashCode = hashCode * 59 + this.NotifiedHistories.GetHashCode();
                return hashCode;
            }
        }
    }
}
