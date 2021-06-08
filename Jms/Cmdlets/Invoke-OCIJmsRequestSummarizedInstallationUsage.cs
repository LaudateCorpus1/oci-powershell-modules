/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210610
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.JmsService.Requests;
using Oci.JmsService.Responses;
using Oci.JmsService.Models;

namespace Oci.JmsService.Cmdlets
{
    [Cmdlet("Invoke", "OCIJmsRequestSummarizedInstallationUsage")]
    [OutputType(new System.Type[] { typeof(Oci.JmsService.Models.InstallationUsageCollection), typeof(Oci.JmsService.Responses.RequestSummarizedInstallationUsageResponse) })]
    public class InvokeOCIJmsRequestSummarizedInstallationUsage : OCIJavaManagementServiceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Fleet.")]
        public string FleetId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Parameters for filtering Java installation usage.")]
        public RequestSummarizedInstallationUsageDetails RequestSummarizedInstallationUsageDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.")]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. The token is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            RequestSummarizedInstallationUsageRequest request;

            try
            {
                request = new RequestSummarizedInstallationUsageRequest
                {
                    FleetId = FleetId,
                    RequestSummarizedInstallationUsageDetails = RequestSummarizedInstallationUsageDetails,
                    Limit = Limit,
                    Page = Page,
                    OpcRequestId = OpcRequestId
                };

                response = client.RequestSummarizedInstallationUsage(request).GetAwaiter().GetResult();
                WriteOutput(response, response.InstallationUsageCollection);
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

        private RequestSummarizedInstallationUsageResponse response;
    }
}
