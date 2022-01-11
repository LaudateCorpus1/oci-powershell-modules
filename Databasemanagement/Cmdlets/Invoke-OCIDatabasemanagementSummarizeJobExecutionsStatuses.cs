/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20201101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatabasemanagementService.Requests;
using Oci.DatabasemanagementService.Responses;
using Oci.DatabasemanagementService.Models;

namespace Oci.DatabasemanagementService.Cmdlets
{
    [Cmdlet("Invoke", "OCIDatabasemanagementSummarizeJobExecutionsStatuses")]
    [OutputType(new System.Type[] { typeof(Oci.DatabasemanagementService.Models.JobExecutionsStatusSummaryCollection), typeof(Oci.DatabasemanagementService.Responses.SummarizeJobExecutionsStatusesResponse) })]
    public class InvokeOCIDatabasemanagementSummarizeJobExecutionsStatuses : OCIDbManagementCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The start time of the time range to retrieve the status summary of job executions in UTC in ISO-8601 format, which is ""yyyy-MM-dd'T'hh:mm:ss.sss'Z'"".")]
        public string StartTime { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The end time of the time range to retrieve the status summary of job executions in UTC in ISO-8601 format, which is ""yyyy-MM-dd'T'hh:mm:ss.sss'Z'"".")]
        public string EndTime { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The identifier of the resource.")]
        public string Id { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database Group.")]
        public string ManagedDatabaseGroupId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Managed Database.")]
        public string ManagedDatabaseId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only resources that match the entire name.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort information by. Only one sortOrder can be used. The default sort order for 'TIMECREATED' is descending and the default sort order for 'NAME' is ascending. The 'NAME' sort order is case-sensitive.")]
        public System.Nullable<Oci.DatabasemanagementService.Requests.SummarizeJobExecutionsStatusesRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The option to sort information in ascending ('ASC') or descending ('DESC') order. Ascending order is the default order.")]
        public System.Nullable<Oci.DatabasemanagementService.Models.SortOrders> SortOrder { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            SummarizeJobExecutionsStatusesRequest request;

            try
            {
                request = new SummarizeJobExecutionsStatusesRequest
                {
                    CompartmentId = CompartmentId,
                    StartTime = StartTime,
                    EndTime = EndTime,
                    OpcRequestId = OpcRequestId,
                    Id = Id,
                    ManagedDatabaseGroupId = ManagedDatabaseGroupId,
                    ManagedDatabaseId = ManagedDatabaseId,
                    Name = Name,
                    SortBy = SortBy,
                    SortOrder = SortOrder
                };

                response = client.SummarizeJobExecutionsStatuses(request).GetAwaiter().GetResult();
                WriteOutput(response, response.JobExecutionsStatusSummaryCollection);
                FinishProcessing(response);
            }
            catch (Exception ex)
            {
                TerminatingErrorDuringExecution(ex);
            }
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
            TerminatingErrorDuringExecution(new OperationCanceledException("Cmdlet execution interrupted"));
        }

        private SummarizeJobExecutionsStatusesResponse response;
    }
}
