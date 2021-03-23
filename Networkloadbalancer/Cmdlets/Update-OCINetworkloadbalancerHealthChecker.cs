/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200501
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.NetworkloadbalancerService.Requests;
using Oci.NetworkloadbalancerService.Responses;
using Oci.NetworkloadbalancerService.Models;

namespace Oci.NetworkloadbalancerService.Cmdlets
{
    [Cmdlet("Update", "OCINetworkloadbalancerHealthChecker")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.NetworkloadbalancerService.Responses.UpdateHealthCheckerResponse) })]
    public class UpdateOCINetworkloadbalancerHealthChecker : OCINetworkLoadBalancerCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network load balancer to update.")]
        public string NetworkLoadBalancerId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The health check policy configuration details.")]
        public UpdateHealthCheckerDetails UpdateHealthCheckerDetails { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the backend set associated with the health check policy to be retrieved.

Example: `example_backend_set`")]
        public string BackendSetName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique Oracle-assigned identifier for the request. If you must contact Oracle about a particular request, then provide the request identifier.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so that it can be retried in case of a timeout or server error without risk of rerunning that same action. Retry tokens expire after 24 hours but they can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the current etag value of the resource.")]
        public string IfMatch { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateHealthCheckerRequest request;

            try
            {
                request = new UpdateHealthCheckerRequest
                {
                    NetworkLoadBalancerId = NetworkLoadBalancerId,
                    UpdateHealthCheckerDetails = UpdateHealthCheckerDetails,
                    BackendSetName = BackendSetName,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken,
                    IfMatch = IfMatch
                };

                response = client.UpdateHealthChecker(request).GetAwaiter().GetResult();
                WriteOutput(response, CreateWorkRequestObject(response.OpcWorkRequestId));
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

        private UpdateHealthCheckerResponse response;
    }
}
