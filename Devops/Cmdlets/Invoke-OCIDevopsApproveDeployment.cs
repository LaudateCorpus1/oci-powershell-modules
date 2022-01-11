/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210630
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DevopsService.Requests;
using Oci.DevopsService.Responses;
using Oci.DevopsService.Models;

namespace Oci.DevopsService.Cmdlets
{
    [Cmdlet("Invoke", "OCIDevopsApproveDeployment")]
    [OutputType(new System.Type[] { typeof(Oci.DevopsService.Models.Deployment), typeof(Oci.DevopsService.Responses.ApproveDeploymentResponse) })]
    public class InvokeOCIDevopsApproveDeployment : OCIDevopsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique deployment identifier.")]
        public string DeploymentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The stage information for approval.")]
        public ApproveDeploymentDetails ApproveDeploymentDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request.  If you need to contact Oracle about a particular request, provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated earlier due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ApproveDeploymentRequest request;

            try
            {
                request = new ApproveDeploymentRequest
                {
                    DeploymentId = DeploymentId,
                    ApproveDeploymentDetails = ApproveDeploymentDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.ApproveDeployment(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Deployment);
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

        private ApproveDeploymentResponse response;
    }
}
