/*
 * NOTE: Generated using OracleSDKGenerator, API Version: release
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.KeymanagementService.Requests;
using Oci.KeymanagementService.Responses;
using Oci.KeymanagementService.Models;

namespace Oci.KeymanagementService.Cmdlets
{
    [Cmdlet("Get", "OCIKeymanagementVaultUsage")]
    [OutputType(new System.Type[] { typeof(Oci.KeymanagementService.Models.VaultUsage), typeof(Oci.KeymanagementService.Responses.GetVaultUsageResponse) })]
    public class GetOCIKeymanagementVaultUsage : OCIKmsVaultCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the vault.")]
        public string VaultId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetVaultUsageRequest request;

            try
            {
                request = new GetVaultUsageRequest
                {
                    VaultId = VaultId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetVaultUsage(request).GetAwaiter().GetResult();
                WriteOutput(response, response.VaultUsage);
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

        private GetVaultUsageResponse response;
    }
}
