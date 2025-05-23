using System;
using System.Collections.Generic;
using System.Linq;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2
{
    public class AadRegion
    {
        public static readonly Region CN_NORTH_4 = new Region("cn-north-4",
            "https://aad.myhuaweicloud.com");
        public static readonly Region AP_SOUTHEAST_1 = new Region("ap-southeast-1",
            "https://aad.myhuaweicloud.com");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("AAD");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>
        {
                { "cn-north-4", CN_NORTH_4 },
                { "ap-southeast-1", AP_SOUTHEAST_1 },
        };

        public static Region ValueOf(string regionId)
        {
            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentNullException(regionId);
            }

            var region = Provider.GetRegion(regionId);
            if (region != null)
            {
                return region;
            }

            if (StaticFields.ContainsKey(regionId))
            {
                return StaticFields[regionId];
            }

            throw new ArgumentException($"region id '{regionId}' is not in the following supported regions of service 'AAD': [{string.Join(", ", StaticFields.Keys.OrderBy(key => key))}]");
        }
    }
}