/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ObjectstorageService.Requests;
using Oci.ObjectstorageService.Responses;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Cmdlets
{
    [Cmdlet("Get", "OCIObjectstorageNamespace")]
    [OutputType(new System.Type[] { typeof(string), typeof(Oci.ObjectstorageService.Responses.GetNamespaceResponse) })]
    public class GetOCIObjectstorageNamespace : OCIObjectStorageCmdlet
    {
        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcClientRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"This is an optional field representing either the tenancy [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) or the compartment [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) within the tenancy whose Object Storage namespace is to be retrieved.")]
        public string CompartmentId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetNamespaceRequest request;

            try
            {
                request = new GetNamespaceRequest
                {
                    OpcClientRequestId = OpcClientRequestId,
                    CompartmentId = CompartmentId
                };

                response = client.GetNamespace(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Value);
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

        private GetNamespaceResponse response;
    }
}
