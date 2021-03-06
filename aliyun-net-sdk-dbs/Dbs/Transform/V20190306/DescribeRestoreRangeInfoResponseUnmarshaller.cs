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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Dbs.Model.V20190306;

namespace Aliyun.Acs.Dbs.Transform.V20190306
{
    public class DescribeRestoreRangeInfoResponseUnmarshaller
    {
        public static DescribeRestoreRangeInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRestoreRangeInfoResponse describeRestoreRangeInfoResponse = new DescribeRestoreRangeInfoResponse();

			describeRestoreRangeInfoResponse.HttpResponse = context.HttpResponse;
			describeRestoreRangeInfoResponse.Success = context.BooleanValue("DescribeRestoreRangeInfo.Success");
			describeRestoreRangeInfoResponse.ErrCode = context.StringValue("DescribeRestoreRangeInfo.ErrCode");
			describeRestoreRangeInfoResponse.ErrMessage = context.StringValue("DescribeRestoreRangeInfo.ErrMessage");
			describeRestoreRangeInfoResponse.HttpStatusCode = context.IntegerValue("DescribeRestoreRangeInfo.HttpStatusCode");
			describeRestoreRangeInfoResponse.RequestId = context.StringValue("DescribeRestoreRangeInfo.RequestId");

			List<DescribeRestoreRangeInfoResponse.DescribeRestoreRangeInfo_DBSRecoverRange> describeRestoreRangeInfoResponse_items = new List<DescribeRestoreRangeInfoResponse.DescribeRestoreRangeInfo_DBSRecoverRange>();
			for (int i = 0; i < context.Length("DescribeRestoreRangeInfo.Items.Length"); i++) {
				DescribeRestoreRangeInfoResponse.DescribeRestoreRangeInfo_DBSRecoverRange dBSRecoverRange = new DescribeRestoreRangeInfoResponse.DescribeRestoreRangeInfo_DBSRecoverRange();
				dBSRecoverRange.SourceEndpointInstanceType = context.StringValue("DescribeRestoreRangeInfo.Items["+ i +"].SourceEndpointInstanceType");
				dBSRecoverRange.SourceEndpointInstanceID = context.StringValue("DescribeRestoreRangeInfo.Items["+ i +"].SourceEndpointInstanceID");
				dBSRecoverRange.BeginTimestampForRestore = context.LongValue("DescribeRestoreRangeInfo.Items["+ i +"].BeginTimestampForRestore");
				dBSRecoverRange.EndTimestampForRestore = context.LongValue("DescribeRestoreRangeInfo.Items["+ i +"].EndTimestampForRestore");
				dBSRecoverRange.RangeType = context.StringValue("DescribeRestoreRangeInfo.Items["+ i +"].RangeType");

				List<DescribeRestoreRangeInfoResponse.DescribeRestoreRangeInfo_DBSRecoverRange.DescribeRestoreRangeInfo_FullBackupDetail> dBSRecoverRange_fullBackupList = new List<DescribeRestoreRangeInfoResponse.DescribeRestoreRangeInfo_DBSRecoverRange.DescribeRestoreRangeInfo_FullBackupDetail>();
				for (int j = 0; j < context.Length("DescribeRestoreRangeInfo.Items["+ i +"].FullBackupList.Length"); j++) {
					DescribeRestoreRangeInfoResponse.DescribeRestoreRangeInfo_DBSRecoverRange.DescribeRestoreRangeInfo_FullBackupDetail fullBackupDetail = new DescribeRestoreRangeInfoResponse.DescribeRestoreRangeInfo_DBSRecoverRange.DescribeRestoreRangeInfo_FullBackupDetail();
					fullBackupDetail.BackupSetId = context.StringValue("DescribeRestoreRangeInfo.Items["+ i +"].FullBackupList["+ j +"].BackupSetId");
					fullBackupDetail.StartTime = context.LongValue("DescribeRestoreRangeInfo.Items["+ i +"].FullBackupList["+ j +"].StartTime");
					fullBackupDetail.EndTime = context.LongValue("DescribeRestoreRangeInfo.Items["+ i +"].FullBackupList["+ j +"].EndTime");

					dBSRecoverRange_fullBackupList.Add(fullBackupDetail);
				}
				dBSRecoverRange.FullBackupList = dBSRecoverRange_fullBackupList;

				describeRestoreRangeInfoResponse_items.Add(dBSRecoverRange);
			}
			describeRestoreRangeInfoResponse.Items = describeRestoreRangeInfoResponse_items;
        
			return describeRestoreRangeInfoResponse;
        }
    }
}
