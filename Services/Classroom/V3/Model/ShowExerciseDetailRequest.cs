using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowExerciseDetailRequest 
    {

        /// <summary>
        /// 需查询的习题id
        /// </summary>
        [SDKProperty("exercise_id", IsPath = true)]
        [JsonProperty("exercise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowExerciseDetailRequest {\n");
            sb.Append("  exerciseId: ").Append(ExerciseId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowExerciseDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowExerciseDetailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExerciseId == input.ExerciseId ||
                    (this.ExerciseId != null &&
                    this.ExerciseId.Equals(input.ExerciseId))
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
                if (this.ExerciseId != null)
                    hashCode = hashCode * 59 + this.ExerciseId.GetHashCode();
                return hashCode;
            }
        }
    }
}
