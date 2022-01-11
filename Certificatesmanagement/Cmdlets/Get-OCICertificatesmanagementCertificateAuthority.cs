/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210224
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CertificatesmanagementService.Requests;
using Oci.CertificatesmanagementService.Responses;
using Oci.CertificatesmanagementService.Models;
using Oci.Common.Waiters;

namespace Oci.CertificatesmanagementService.Cmdlets
{
    [Cmdlet("Get", "OCICertificatesmanagementCertificateAuthority", DefaultParameterSetName = Default)]
    [OutputType(new System.Type[] { typeof(Oci.CertificatesmanagementService.Models.CertificateAuthority), typeof(Oci.CertificatesmanagementService.Responses.GetCertificateAuthorityResponse) })]
    public class GetOCICertificatesmanagementCertificateAuthority : OCICertificatesManagementCmdlet
    {
        
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the certificate authority (CA).", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the certificate authority (CA).", ParameterSetName = Default)]
        public string CertificateAuthorityId { get; set; }

        
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.", ParameterSetName = LifecycleStateParamSet)]
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.", ParameterSetName = Default)]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, HelpMessage = @"This operation creates, modifies or deletes a resource that has a defined lifecycle state. Specify this option to perform the action and then wait until the resource reaches a given lifecycle state. Multiple states can be specified, returning on the first state.", ParameterSetName = LifecycleStateParamSet)]
        public Oci.CertificatesmanagementService.Models.CertificateAuthorityLifecycleState[] WaitForLifecycleState { get; set; }

        [Parameter(Mandatory = false, HelpMessage = @"Check every WaitIntervalSeconds to see whether the resource has reached a desired state.", ParameterSetName = LifecycleStateParamSet)]
        public int WaitIntervalSeconds { get; set; } = WAIT_INTERVAL_SECONDS;

        [Parameter(Mandatory = false, HelpMessage = @"Maximum number of attempts to be made until the resource reaches a desired state.", ParameterSetName = LifecycleStateParamSet)]
        public int MaxWaitAttempts { get; set; } = MAX_WAITER_ATTEMPTS;

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetCertificateAuthorityRequest request;

            try
            {
                request = new GetCertificateAuthorityRequest
                {
                    CertificateAuthorityId = CertificateAuthorityId,
                    OpcRequestId = OpcRequestId
                };

                HandleOutput(request);
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

        private void HandleOutput(GetCertificateAuthorityRequest request)
        {
            var waiterConfig = new WaiterConfiguration
            {
                MaxAttempts = MaxWaitAttempts,
                GetNextDelayInSeconds = (_) => WaitIntervalSeconds
            };

            switch (ParameterSetName)
            { 
                case LifecycleStateParamSet:
                    response = client.Waiters.ForCertificateAuthority(request, waiterConfig, WaitForLifecycleState).Execute();
                    break;

                case Default:
                    response = client.GetCertificateAuthority(request).GetAwaiter().GetResult();
                    break;
            }
            WriteOutput(response, response.CertificateAuthority);
        }

        private GetCertificateAuthorityResponse response;
        private const string LifecycleStateParamSet = "LifecycleStateParamSet";
        private const string Default = "Default";
    }
}
