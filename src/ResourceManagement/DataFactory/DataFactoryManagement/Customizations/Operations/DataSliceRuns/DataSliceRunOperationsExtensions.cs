﻿// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    public static class DataSliceRunOperationsExtensions
    {
        /// <summary>
        /// Gets logs for a data slice run
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='dataSliceRunId'>
        /// Required. A unique data slice run instance id.
        /// </param>
        /// <returns>
        /// The data slice run get logs operation response.
        /// </returns>
        public static DataSliceRunGetLogsResponse GetLogs(
            this IDataSliceRunOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string dataSliceRunId)
        {
            return Task.Factory.StartNew(
                s => ((IDataSliceRunOperations)s).GetLogsAsync(
                    resourceGroupName,
                    dataFactoryName,
                    dataSliceRunId),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets logs for a data slice run
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='dataSliceRunId'>
        /// Required. A unique data slice run instance id.
        /// </param>
        /// <returns>
        /// The data slice run get logs operation response.
        /// </returns>
        public static Task<DataSliceRunGetLogsResponse> GetLogsAsync(
            this IDataSliceRunOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string dataSliceRunId)
        {
            return operations.GetLogsAsync(resourceGroupName, dataFactoryName, dataSliceRunId, CancellationToken.None);
        }

        /// <summary>
        /// Gets the first page of data slice run instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. A unique table instance name.
        /// </param>
        /// <param name='dataSliceStartTime'>
        /// Required. The start time of the data slice queried in round-trip
        /// ISO 8601 format.
        /// </param>
        /// <returns>
        /// The List data slice runs operation response.
        /// </returns>
        public static DataSliceRunListResponse List(
            this IDataSliceRunOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            string dataSliceStartTime)
        {
            return Task.Factory.StartNew(
                s => ((IDataSliceRunOperations)s).ListAsync(
                    resourceGroupName,
                    dataFactoryName,
                    tableName,
                    dataSliceStartTime),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the first page of data slice run instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// Required. A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// Required. A unique table instance name.
        /// </param>
        /// <param name='dataSliceStartTime'>
        /// Required. The start time of the data slice queried in round-trip
        /// ISO 8601 format.
        /// </param>
        /// <returns>
        /// The List data slice runs operation response.
        /// </returns>
        public static Task<DataSliceRunListResponse> ListAsync(
            this IDataSliceRunOperations operations,
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            string dataSliceStartTime)
        {
            return operations.ListAsync(
                resourceGroupName,
                dataFactoryName,
                tableName,
                dataSliceStartTime,
                CancellationToken.None);
        }

        /// <summary>
        /// Gets the next page of run instances with the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next data slice runs page.
        /// </param>
        /// <returns>
        /// The List data slice runs operation response.
        /// </returns>
        public static DataSliceRunListResponse ListNext(this IDataSliceRunOperations operations, string nextLink)
        {
            return Task.Factory.StartNew(
                s => ((IDataSliceRunOperations)s).ListNextAsync(nextLink),
                operations,
                CancellationToken.None,
                TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the next page of run instances with the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.DataFactories.Core.IDataSliceRunOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next data slice runs page.
        /// </param>
        /// <returns>
        /// The List data slice runs operation response.
        /// </returns>
        public static Task<DataSliceRunListResponse> ListNextAsync(
            this IDataSliceRunOperations operations,
            string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}