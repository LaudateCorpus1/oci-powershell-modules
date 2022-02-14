/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatasafeService.Requests;
using Oci.DatasafeService.Responses;
using Oci.DatasafeService.Models;

namespace Oci.DatasafeService.Cmdlets
{
    [Cmdlet("Write", "OCIDatasafeSensitiveDataModel")]
    [OutputType(new System.Type[] { typeof(Oci.PSModules.Common.Cmdlets.WorkRequest), typeof(Oci.DatasafeService.Responses.UploadSensitiveDataModelResponse) })]
    public class WriteOCIDatasafeSensitiveDataModel : OCIDataSafeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the sensitive data model.")]
        public string SensitiveDataModelId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details to upload a sensitive data model file.", ParameterSetName = FromStreamSet)]
        public System.IO.Stream UploadSensitiveDataModelDetails { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Use this parameter to provide the file location from where the input stream to be read. Details to upload a sensitive data model file.", ParameterSetName = FromFileSet)]
        public String UploadSensitiveDataModelDetailsFromFile { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the if-match parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UploadSensitiveDataModelRequest request;

            if (ParameterSetName.Equals(FromFileSet))
            {
                UploadSensitiveDataModelDetails = System.IO.File.OpenRead(GetAbsoluteFilePath(UploadSensitiveDataModelDetailsFromFile));
            }
            

            try
            {
                request = new UploadSensitiveDataModelRequest
                {
                    SensitiveDataModelId = SensitiveDataModelId,
                    UploadSensitiveDataModelDetails = UploadSensitiveDataModelDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UploadSensitiveDataModel(request).GetAwaiter().GetResult();
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

        private UploadSensitiveDataModelResponse response;
        private const string FromFileSet = "FromFile";
        private const string FromStreamSet = "FromStream";
    }
}
