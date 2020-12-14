/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20201210
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.RoverService.Requests;
using Oci.RoverService.Responses;
using Oci.RoverService.Models;

namespace Oci.RoverService.Cmdlets
{
    [Cmdlet("Get", "OCIRoverClusterCertificate")]
    [OutputType(new System.Type[] { typeof(Oci.RoverService.Models.RoverClusterCertificate), typeof(Oci.RoverService.Responses.GetRoverClusterCertificateResponse) })]
    public class GetOCIRoverClusterCertificate : OCIRoverClusterCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique RoverCluster identifier")]
        public string RoverClusterId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetRoverClusterCertificateRequest request;

            try
            {
                request = new GetRoverClusterCertificateRequest
                {
                    RoverClusterId = RoverClusterId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetRoverClusterCertificate(request).GetAwaiter().GetResult();
                WriteOutput(response, response.RoverClusterCertificate);
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

        private GetRoverClusterCertificateResponse response;
    }
}
