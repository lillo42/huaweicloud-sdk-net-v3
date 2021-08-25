using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SearchFaceByFileRequestBody 
    {

        /// <summary>
        /// 本地图片文件，图片不能超过8MB，建议小于1MB。上传文件时，请求格式为multipart。  必选，与image_url、image_base64、face_id四选一。
        /// </summary>
        [JsonProperty("image_file", NullValueHandling = NullValueHandling.Ignore)]
        public System.IO.Stream ImageFile { get; set; }

        /// <summary>
        /// 返回查询到的最相似的N张人脸，N默认为10。
        /// </summary>
        [JsonProperty("top_n", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopN { get; set; }

        /// <summary>
        /// 人脸相似度阈值，低于这个阈值则不返回，取值范围0~1，一般情况下建议取值0.93，默认为0。
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public double? Threshold { get; set; }

        /// <summary>
        /// 支持字段排序，参考[sort语法](zh-cn_topic_0130807047.xml)。
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

        /// <summary>
        /// 过滤条件，参考[filter语法](zh-cn_topic_0130807048.xml)。
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// 指定返回的自定义字段。
        /// </summary>
        [JsonProperty("return_fields", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnFields { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchFaceByFileRequestBody {\n");
            sb.Append("  imageFile: ").Append(ImageFile).Append("\n");
            sb.Append("  topN: ").Append(TopN).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  returnFields: ").Append(ReturnFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchFaceByFileRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchFaceByFileRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageFile == input.ImageFile ||
                    (this.ImageFile != null &&
                    this.ImageFile.Equals(input.ImageFile))
                ) && 
                (
                    this.TopN == input.TopN ||
                    (this.TopN != null &&
                    this.TopN.Equals(input.TopN))
                ) && 
                (
                    this.Threshold == input.Threshold ||
                    (this.Threshold != null &&
                    this.Threshold.Equals(input.Threshold))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.ReturnFields == input.ReturnFields ||
                    (this.ReturnFields != null &&
                    this.ReturnFields.Equals(input.ReturnFields))
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
                if (this.ImageFile != null)
                    hashCode = hashCode * 59 + this.ImageFile.GetHashCode();
                if (this.TopN != null)
                    hashCode = hashCode * 59 + this.TopN.GetHashCode();
                if (this.Threshold != null)
                    hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.ReturnFields != null)
                    hashCode = hashCode * 59 + this.ReturnFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
