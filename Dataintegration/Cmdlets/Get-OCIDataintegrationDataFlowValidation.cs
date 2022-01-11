/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200430
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DataintegrationService.Requests;
using Oci.DataintegrationService.Responses;
using Oci.DataintegrationService.Models;

namespace Oci.DataintegrationService.Cmdlets
{
    [Cmdlet("Get", "OCIDataintegrationDataFlowValidation")]
    [OutputType(new System.Type[] { typeof(Oci.DataintegrationService.Models.DataFlowValidation), typeof(Oci.DataintegrationService.Responses.GetDataFlowValidationResponse) })]
    public class GetOCIDataintegrationDataFlowValidation : OCIDataIntegrationCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The workspace ID.")]
        public string WorkspaceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The key of the dataflow validation.")]
        public string DataFlowValidationKey { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetDataFlowValidationRequest request;

            try
            {
                request = new GetDataFlowValidationRequest
                {
                    WorkspaceId = WorkspaceId,
                    DataFlowValidationKey = DataFlowValidationKey,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetDataFlowValidation(request).GetAwaiter().GetResult();
                WriteOutput(response, response.DataFlowValidation);
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

        private GetDataFlowValidationResponse response;
    }
}
