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
    [Cmdlet("Invoke", "OCIAilanguageDetectLanguageEntities")]
    [OutputType(new System.Type[] { typeof(Oci.AilanguageService.Models.DetectLanguageEntitiesResult), typeof(Oci.AilanguageService.Responses.DetectLanguageEntitiesResponse) })]
    public class InvokeOCIAilanguageDetectLanguageEntities : OCIAIServiceLanguageCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The details to make a Entity detect call.")]
        public DetectLanguageEntitiesDetails DetectLanguageEntitiesDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Named Entity Recognition model versions. By default user will get output from V2.1 implementation.")]
        public System.Nullable<Oci.AilanguageService.Models.NerModelVersion> ModelVersion { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"If this parameter is set to true, you only get PII (Personally identifiable information) entities like PhoneNumber, Email, Person, and so on. Default value is false.")]
        public System.Nullable<bool> IsPii { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            DetectLanguageEntitiesRequest request;

            try
            {
                request = new DetectLanguageEntitiesRequest
                {
                    DetectLanguageEntitiesDetails = DetectLanguageEntitiesDetails,
                    OpcRequestId = OpcRequestId,
                    ModelVersion = ModelVersion,
                    IsPii = IsPii
                };

                response = client.DetectLanguageEntities(request).GetAwaiter().GetResult();
                WriteOutput(response, response.DetectLanguageEntitiesResult);
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

        private DetectLanguageEntitiesResponse response;
    }
}
