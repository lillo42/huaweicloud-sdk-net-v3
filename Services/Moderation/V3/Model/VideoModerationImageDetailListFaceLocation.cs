using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 人物位置信息，该数组有四个值，分别代表左上角的坐标和右下角的坐标。例如[207,522,340,567] 207代表的是左上角的坐标 522代表左上角的坐标 340代表的是右下角的坐标 567代表的是右下角的坐标。
    /// </summary>
    public class VideoModerationImageDetailListFaceLocation 
    {

        /// <summary>
        /// 检测出人脸的左上角横坐标。
        /// </summary>
        [JsonProperty("top_left_x", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopLeftX { get; set; }

        /// <summary>
        /// 检测出人脸的左上角纵坐标。
        /// </summary>
        [JsonProperty("top_left_y", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopLeftY { get; set; }

        /// <summary>
        /// 检测出人脸的右下角横坐标。
        /// </summary>
        [JsonProperty("bottom_right_x", NullValueHandling = NullValueHandling.Ignore)]
        public int? BottomRightX { get; set; }

        /// <summary>
        /// 检测出人脸的右下角纵坐标。
        /// </summary>
        [JsonProperty("bottom_right_y", NullValueHandling = NullValueHandling.Ignore)]
        public int? BottomRightY { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoModerationImageDetailListFaceLocation {\n");
            sb.Append("  topLeftX: ").Append(TopLeftX).Append("\n");
            sb.Append("  topLeftY: ").Append(TopLeftY).Append("\n");
            sb.Append("  bottomRightX: ").Append(BottomRightX).Append("\n");
            sb.Append("  bottomRightY: ").Append(BottomRightY).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoModerationImageDetailListFaceLocation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoModerationImageDetailListFaceLocation input)
        {
            if (input == null) return false;
            if (this.TopLeftX != input.TopLeftX || (this.TopLeftX != null && !this.TopLeftX.Equals(input.TopLeftX))) return false;
            if (this.TopLeftY != input.TopLeftY || (this.TopLeftY != null && !this.TopLeftY.Equals(input.TopLeftY))) return false;
            if (this.BottomRightX != input.BottomRightX || (this.BottomRightX != null && !this.BottomRightX.Equals(input.BottomRightX))) return false;
            if (this.BottomRightY != input.BottomRightY || (this.BottomRightY != null && !this.BottomRightY.Equals(input.BottomRightY))) return false;

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
                if (this.TopLeftX != null) hashCode = hashCode * 59 + this.TopLeftX.GetHashCode();
                if (this.TopLeftY != null) hashCode = hashCode * 59 + this.TopLeftY.GetHashCode();
                if (this.BottomRightX != null) hashCode = hashCode * 59 + this.BottomRightX.GetHashCode();
                if (this.BottomRightY != null) hashCode = hashCode * 59 + this.BottomRightY.GetHashCode();
                return hashCode;
            }
        }
    }
}
