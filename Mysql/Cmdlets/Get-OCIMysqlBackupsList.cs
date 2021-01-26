/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190415
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.MysqlService.Requests;
using Oci.MysqlService.Responses;
using Oci.MysqlService.Models;

namespace Oci.MysqlService.Cmdlets
{
    [Cmdlet("Get", "OCIMysqlBackupsList")]
    [OutputType(new System.Type[] { typeof(Oci.MysqlService.Models.BackupSummary), typeof(Oci.MysqlService.Responses.ListBackupsResponse) })]
    public class GetOCIMysqlBackupsList : OCIDbBackupsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The compartment [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Customer-defined unique identifier for the request. If you need to contact Oracle about a specific request, please provide the request ID that you supplied in this header with the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Backup OCID")]
        public string BackupId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Backup Lifecycle State")]
        public System.Nullable<Oci.MysqlService.Models.Backup.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The DB System [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string DbSystemId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only the resource matching the given display name exactly.")]
        public string DisplayName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Backup creationType")]
        public System.Nullable<Oci.MysqlService.Models.Backup.CreationTypeEnum> CreationType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Time fields are default ordered as descending.")]
        public System.Nullable<Oci.MysqlService.Requests.ListBackupsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use (ASC or DESC).")]
        public System.Nullable<Oci.MysqlService.Requests.ListBackupsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated list call. For information about pagination, see [List Pagination](https://docs.cloud.oracle.com/#API/Concepts/usingapi.htm#List_Pagination).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` or `opc-prev-page` response header from the previous list call. For information about pagination, see [List Pagination](https://docs.cloud.oracle.com/#API/Concepts/usingapi.htm#List_Pagination).")]
        public string Page { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListBackupsRequest request;

            try
            {
                request = new ListBackupsRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId,
                    BackupId = BackupId,
                    LifecycleState = LifecycleState,
                    DbSystemId = DbSystemId,
                    DisplayName = DisplayName,
                    CreationType = CreationType,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    Limit = Limit,
                    Page = Page
                };
                IEnumerable<ListBackupsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.Items, true);
                }
                if(!ParameterSetName.Equals(AllPageSet) && response.OpcNextPage != null)
                {
                    WriteWarning("This operation supports pagination and not all resources were returned.  Re-run using the -all option to auto paginate and list all resources.");
                }
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

        private RequestDelegate GetRequestDelegate()
        {
            IEnumerable<ListBackupsResponse> DefaultRequest(ListBackupsRequest request) => Enumerable.Repeat(client.ListBackups(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListBackupsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListBackupsResponse response;
        private delegate IEnumerable<ListBackupsResponse> RequestDelegate(ListBackupsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
