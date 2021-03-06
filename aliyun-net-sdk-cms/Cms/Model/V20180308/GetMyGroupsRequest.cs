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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class GetMyGroupsRequest : RpcAcsRequest<GetMyGroupsResponse>
    {
        public GetMyGroupsRequest()
            : base("Cms", "2018-03-08", "GetMyGroups", "cms", "openAPI")
        {
        }

		private bool? selectContactGroups;

		private string instanceId;

		private long? groupId;

		private string type;

		private string groupName;

		private string bindUrl;

		public bool? SelectContactGroups
		{
			get
			{
				return selectContactGroups;
			}
			set	
			{
				selectContactGroups = value;
				DictionaryUtil.Add(QueryParameters, "SelectContactGroups", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
				DictionaryUtil.Add(QueryParameters, "GroupName", value);
			}
		}

		public string BindUrl
		{
			get
			{
				return bindUrl;
			}
			set	
			{
				bindUrl = value;
				DictionaryUtil.Add(QueryParameters, "BindUrl", value);
			}
		}

        public override GetMyGroupsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetMyGroupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
