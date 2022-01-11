/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.AilanguageService.Requests;
using Oci.AilanguageService.Responses;
using Oci.AilanguageService.Models;

namespace Oci.AilanguageService.Cmdlets
{
    [Cmdlet("Invoke", "OCIAilanguageBatchDetectLanguageEntities")]
    [OutputType(new System.Type[] { typeof(Oci.AilanguageService.Models.BatchDetectLanguageEntitiesResult), typeof(Oci.AilanguageService.Responses.BatchDetectLanguageEntitiesResponse) })]
    public class InvokeOCIAilanguageBatchDetectLanguageEntities : OCIAIServiceLanguageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The details to make a Entity detect call.")]
        public BatchDetectLanguageEntitiesDetails BatchDetectLanguageEntitiesDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            BatchDetectLanguageEntitiesRequest request;

            try
            {
                request = new BatchDetectLanguageEntitiesRequest
                {
                    BatchDetectLanguageEntitiesDetails = BatchDetectLanguageEntitiesDetails,
                    OpcRequestId = OpcRequestId
                };

                response = client.BatchDetectLanguageEntities(request).GetAwaiter().GetResult();
                WriteOutput(response, response.BatchDetectLanguageEntitiesResult);
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

        private BatchDetectLanguageEntitiesResponse response;
    }
}
