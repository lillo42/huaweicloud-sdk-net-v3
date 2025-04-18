using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListCriteriasResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("search_criterias", NullValueHandling = NullValueHandling.Ignore)]
        public List<GetQuerySearchCriteriasBody> SearchCriterias { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCriteriasResponse {\n");
            sb.Append("  searchCriterias: ").Append(SearchCriterias).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCriteriasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCriteriasResponse input)
        {
            if (input == null) return false;
            if (this.SearchCriterias != input.SearchCriterias || (this.SearchCriterias != null && input.SearchCriterias != null && !this.SearchCriterias.SequenceEqual(input.SearchCriterias))) return false;

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
                if (this.SearchCriterias != null) hashCode = hashCode * 59 + this.SearchCriterias.GetHashCode();
                return hashCode;
            }
        }
    }
}
