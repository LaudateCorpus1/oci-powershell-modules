/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190331
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.AnalyticsService.Requests;
using Oci.AnalyticsService.Responses;
using Oci.AnalyticsService.Models;

namespace Oci.AnalyticsService.Cmdlets
{
    [Cmdlet("Get", "OCIAnalyticsPrivateAccessChannel")]
    [OutputType(new System.Type[] { typeof(Oci.AnalyticsService.Models.PrivateAccessChannel), typeof(Oci.AnalyticsService.Responses.GetPrivateAccessChannelResponse) })]
    public class GetOCIAnalyticsPrivateAccessChannel : OCIAnalyticsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique identifier key of the Private Access Channel.")]
        public string PrivateAccessChannelKey { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the AnalyticsInstance.")]
        public string AnalyticsInstanceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetPrivateAccessChannelRequest request;

            try
            {
                request = new GetPrivateAccessChannelRequest
                {
                    PrivateAccessChannelKey = PrivateAccessChannelKey,
                    AnalyticsInstanceId = AnalyticsInstanceId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetPrivateAccessChannel(request).GetAwaiter().GetResult();
                WriteOutput(response, response.PrivateAccessChannel);
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

        private GetPrivateAccessChannelResponse response;
    }
}
