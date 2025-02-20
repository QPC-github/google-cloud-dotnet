﻿// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Storage.v1.Data;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Storage.v1.BucketsResource;

namespace Google.Cloud.Storage.V1
{
    public partial class StorageClientImpl
    {
        /// <inheritdoc />
        public override Policy GetBucketIamPolicy(string bucket, GetBucketIamPolicyOptions options = null) =>
            CreateGetBucketIamPolicyRequest(bucket, options).Execute();

        /// <inheritdoc />
        public override Task<Policy> GetBucketIamPolicyAsync(string bucket, GetBucketIamPolicyOptions options = null, CancellationToken cancellationToken = default) =>
            CreateGetBucketIamPolicyRequest(bucket, options).ExecuteAsync(cancellationToken);

        private GetIamPolicyRequest CreateGetBucketIamPolicyRequest(string bucket, GetBucketIamPolicyOptions options)
        {
            ValidateBucketName(bucket);
            var bucketEntity = new Bucket { Name = bucket };
            var request = Service.Buckets.GetIamPolicy(bucket);
            options?.ModifyRequest(request);
            RetryHandler.MarkAsRetriable(request);
            return request;
        }
    }
}
