/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20180510;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
    public class DescribeCdnCertificateDetailRequest : RpcAcsRequest<DescribeCdnCertificateDetailResponse>
    {
        public DescribeCdnCertificateDetailRequest()
            : base("Cdn", "2018-05-10", "DescribeCdnCertificateDetail")
        {
        }

		private string securityToken;

		private string certName;

		private string action;

		private long? ownerId;

		private string accessKeyId;

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string CertName
		{
			get
			{
				return certName;
			}
			set	
			{
				certName = value;
				DictionaryUtil.Add(QueryParameters, "CertName", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override DescribeCdnCertificateDetailResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeCdnCertificateDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}