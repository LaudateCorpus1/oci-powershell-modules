/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CoreService.Requests;
using Oci.CoreService.Responses;
using Oci.CoreService.Models;

namespace Oci.CoreService.Cmdlets
{
    [Cmdlet("Get", "OCIBlockstorageVolumeBackupPolicyAssignment")]
    [OutputType(new System.Type[] { typeof(Oci.CoreService.Models.VolumeBackupPolicyAssignment), typeof(Oci.CoreService.Responses.GetVolumeBackupPolicyAssignmentResponse) })]
    public class GetOCIBlockstorageVolumeBackupPolicyAssignment : OCIBlockstorageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the volume backup policy assignment.")]
        public string PolicyAssignmentId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetVolumeBackupPolicyAssignmentRequest request;

            try
            {
                request = new GetVolumeBackupPolicyAssignmentRequest
                {
                    PolicyAssignmentId = PolicyAssignmentId
                };

                response = client.GetVolumeBackupPolicyAssignment(request).GetAwaiter().GetResult();
                WriteOutput(response, response.VolumeBackupPolicyAssignment);
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

        private GetVolumeBackupPolicyAssignmentResponse response;
    }
}
