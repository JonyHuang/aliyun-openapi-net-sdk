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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.elasticsearch.Transform;
using Aliyun.Acs.elasticsearch.Transform.V20170613;

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
    public class ListInstanceRequest : RoaAcsRequest<ListInstanceResponse>
    {
        public ListInstanceRequest()
            : base("elasticsearch", "2017-06-13", "ListInstance", "elasticsearch", "openAPI")
        {
			UriPattern = "/openapi/instances";
			Method = MethodType.GET;
        }

		private string resourceGroupId;

		private string instanceId;

		private int? size;

		private string esVersion;

		private string description;

		private int? page;

		private string ownerId;

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "resourceGroupId", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "instanceId", value);
			}
		}

		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "size", value.ToString());
			}
		}

		public string EsVersion
		{
			get
			{
				return esVersion;
			}
			set	
			{
				esVersion = value;
				DictionaryUtil.Add(QueryParameters, "esVersion", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "description", value);
			}
		}

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(QueryParameters, "page", value.ToString());
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "ownerId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}