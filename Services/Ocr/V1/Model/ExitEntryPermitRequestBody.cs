using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExitEntryPermitRequestBody 
    {

        /// <summary>
        /// 与url二选一。 图像数据，base64编码，要求base64编码后大小不超过10M。图片最小边不小于15像素，最长边不超过8192像素。支持JPG/PNG/BMP/TIFF格式。
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一。  图片的url路径，目前支持： - 公网http/https url - OBS提供的url，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权，详情参见[配置OBS访问权限](https://support.huaweicloud.com/intl/en-us/api-ocr/ocr_03_0132.html)。 &gt; 说明： - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 - 请保证被检测图片所在的存储服务稳定可靠，推荐使用OBS服务存储图片数据。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 是否返回头像内容开关，可选值如下所示： - true: 返回身份证头像照片的 base64 编码 - false: 不返回身份证头像照片的 base64 编码 未传入该参数时默认为“false”，即不返回身份证头像照片的 base64 编码。 
        /// </summary>
        [JsonProperty("return_portrait_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitImage { get; set; }

        /// <summary>
        /// 是否返回头像坐标的开关，可选值如下所示： - true: 返回身份证头像的位置坐标 - false: 不返回身份证头像的位置坐标 未传入该参数时默认为“false”，即不返回身份证的头像坐标。 
        /// </summary>
        [JsonProperty("return_portrait_location", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnPortraitLocation { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExitEntryPermitRequestBody {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  returnPortraitImage: ").Append(ReturnPortraitImage).Append("\n");
            sb.Append("  returnPortraitLocation: ").Append(ReturnPortraitLocation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExitEntryPermitRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExitEntryPermitRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ReturnPortraitImage == input.ReturnPortraitImage ||
                    (this.ReturnPortraitImage != null &&
                    this.ReturnPortraitImage.Equals(input.ReturnPortraitImage))
                ) && 
                (
                    this.ReturnPortraitLocation == input.ReturnPortraitLocation ||
                    (this.ReturnPortraitLocation != null &&
                    this.ReturnPortraitLocation.Equals(input.ReturnPortraitLocation))
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
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ReturnPortraitImage != null)
                    hashCode = hashCode * 59 + this.ReturnPortraitImage.GetHashCode();
                if (this.ReturnPortraitLocation != null)
                    hashCode = hashCode * 59 + this.ReturnPortraitLocation.GetHashCode();
                return hashCode;
            }
        }
    }
}
