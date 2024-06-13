﻿// 
//  Copyright 2024 Huawei Technologies Co.,Ltd.
// 
//  Licensed to the Apache Software Foundation (ASF) under one
//  or more contributor license agreements.  See the NOTICE file
//  distributed with this work for additional information
//  regarding copyright ownership.  The ASF licenses this file
//  to you under the Apache License, Version 2.0 (the
//  "License"); you may not use this file except in compliance
//  with the License.  You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using System;

namespace HuaweiCloud.SDK.Core
{
    public class EqualJitterBackoffStrategy : ExponentialBackoffStrategy
    {
        /// <summary>  
        /// Equal jitter backoff strategy: delay = Exponential/2 + random(0, Exponential/2)
        /// </summary>  
        /// <param name="retries">retry times</param>
        /// <returns>delay milliseconds before next try</returns> 
        public override int CalculateRetryDelayMillis(int retries)
        {
            var halfExpoDelay = base.CalculateRetryDelayMillis(retries) / 2;
            return halfExpoDelay + new Random().Next(1, halfExpoDelay);
        }
    }
}
