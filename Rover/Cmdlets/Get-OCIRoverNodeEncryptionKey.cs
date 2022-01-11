/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20201210
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.RoverService.Requests;
using Oci.RoverService.Responses;
using Oci.RoverService.Models;

namespace Oci.RoverService.Cmdlets
{
    [Cmdlet("Get", "OCIRoverNodeEncryptionKey")]
    [OutputType(new System.Type[] { typeof(Oci.RoverService.Models.RoverNodeEncryptionKey), typeof(Oci.RoverService.Responses.GetRoverNodeEncryptionKeyResponse) })]
    public class GetOCIRoverNodeEncryptionKey : OCIRoverNodeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Serial number of the rover node.")]
        public string RoverNodeId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetRoverNodeEncryptionKeyRequest request;

            try
            {
                request = new GetRoverNodeEncryptionKeyRequest
                {
                    RoverNodeId = RoverNodeId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetRoverNodeEncryptionKey(request).GetAwaiter().GetResult();
                WriteOutput(response, response.RoverNodeEncryptionKey);
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

        private GetRoverNodeEncryptionKeyResponse response;
    }
}
