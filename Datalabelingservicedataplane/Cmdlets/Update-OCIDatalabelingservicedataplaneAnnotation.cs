/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20211001
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatalabelingservicedataplaneService.Requests;
using Oci.DatalabelingservicedataplaneService.Responses;
using Oci.DatalabelingservicedataplaneService.Models;

namespace Oci.DatalabelingservicedataplaneService.Cmdlets
{
    [Cmdlet("Update", "OCIDatalabelingservicedataplaneAnnotation")]
    [OutputType(new System.Type[] { typeof(Oci.DatalabelingservicedataplaneService.Models.Annotation), typeof(Oci.DatalabelingservicedataplaneService.Responses.UpdateAnnotationResponse) })]
    public class UpdateOCIDatalabelingservicedataplaneAnnotation : OCIDataLabelingCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"unique Annotation identifier")]
        public string AnnotationId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Information to be updated.")]
        public UpdateAnnotationDetails UpdateAnnotationDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateAnnotationRequest request;

            try
            {
                request = new UpdateAnnotationRequest
                {
                    AnnotationId = AnnotationId,
                    UpdateAnnotationDetails = UpdateAnnotationDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateAnnotation(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Annotation);
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

        private UpdateAnnotationResponse response;
    }
}