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
    [Cmdlet("Get", "OCIComputeImageCapabilitySchema")]
    [OutputType(new System.Type[] { typeof(Oci.CoreService.Models.ComputeImageCapabilitySchema), typeof(Oci.CoreService.Responses.GetComputeImageCapabilitySchemaResponse) })]
    public class GetOCIComputeImageCapabilitySchema : OCIComputeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The id of the compute image capability schema or the image ocid")]
        public string ComputeImageCapabilitySchemaId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Merge the image capability schema with the global image capability schema")]
        public System.Nullable<bool> IsMergeEnabled { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetComputeImageCapabilitySchemaRequest request;

            try
            {
                request = new GetComputeImageCapabilitySchemaRequest
                {
                    ComputeImageCapabilitySchemaId = ComputeImageCapabilitySchemaId,
                    IsMergeEnabled = IsMergeEnabled
                };

                response = client.GetComputeImageCapabilitySchema(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ComputeImageCapabilitySchema);
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

        private GetComputeImageCapabilitySchemaResponse response;
    }
}
