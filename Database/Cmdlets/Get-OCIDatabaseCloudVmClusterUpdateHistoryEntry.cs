/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatabaseService.Requests;
using Oci.DatabaseService.Responses;
using Oci.DatabaseService.Models;

namespace Oci.DatabaseService.Cmdlets
{
    [Cmdlet("Get", "OCIDatabaseCloudVmClusterUpdateHistoryEntry")]
    [OutputType(new System.Type[] { typeof(Oci.DatabaseService.Models.UpdateHistoryEntry), typeof(Oci.DatabaseService.Responses.GetCloudVmClusterUpdateHistoryEntryResponse) })]
    public class GetOCIDatabaseCloudVmClusterUpdateHistoryEntry : OCIDatabaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The cloud VM cluster [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).")]
        public string CloudVmClusterId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the maintenance update history entry.")]
        public string UpdateHistoryEntryId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetCloudVmClusterUpdateHistoryEntryRequest request;

            try
            {
                request = new GetCloudVmClusterUpdateHistoryEntryRequest
                {
                    CloudVmClusterId = CloudVmClusterId,
                    UpdateHistoryEntryId = UpdateHistoryEntryId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetCloudVmClusterUpdateHistoryEntry(request).GetAwaiter().GetResult();
                WriteOutput(response, response.UpdateHistoryEntry);
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

        private GetCloudVmClusterUpdateHistoryEntryResponse response;
    }
}