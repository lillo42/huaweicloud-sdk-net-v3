using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateGlobalEipSegmentRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("global_eip_segment", NullValueHandling = NullValueHandling.Ignore)]
        public CreateGlobalEipSegmentRequestBodyGlobalEipSegment GlobalEipSegment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGlobalEipSegmentRequestBody {\n");
            sb.Append("  globalEipSegment: ").Append(GlobalEipSegment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateGlobalEipSegmentRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateGlobalEipSegmentRequestBody input)
        {
            if (input == null) return false;
            if (this.GlobalEipSegment != input.GlobalEipSegment || (this.GlobalEipSegment != null && !this.GlobalEipSegment.Equals(input.GlobalEipSegment))) return false;

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
                if (this.GlobalEipSegment != null) hashCode = hashCode * 59 + this.GlobalEipSegment.GetHashCode();
                return hashCode;
            }
        }
    }
}
