/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200131
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CloudguardService.Requests;
using Oci.CloudguardService.Responses;
using Oci.CloudguardService.Models;

namespace Oci.CloudguardService.Cmdlets
{
    [Cmdlet("Update", "OCICloudguardResponderRecipe")]
    [OutputType(new System.Type[] { typeof(Oci.CloudguardService.Models.ResponderRecipe), typeof(Oci.CloudguardService.Responses.UpdateResponderRecipeResponse) })]
    public class UpdateOCICloudguardResponderRecipe : OCICloudGuardCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"OCID of ResponderRecipe")]
        public string ResponderRecipeId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The details to be updated.")]
        public UpdateResponderRecipeDetails UpdateResponderRecipeDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For optimistic concurrency control. In the PUT or DELETE call for a resource, set the `if-match` parameter to the value of the etag from a previous GET or POST response for that resource. The resource will be updated or deleted only if the etag you provide matches the resource's current etag value.")]
        public string IfMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            UpdateResponderRecipeRequest request;

            try
            {
                request = new UpdateResponderRecipeRequest
                {
                    ResponderRecipeId = ResponderRecipeId,
                    UpdateResponderRecipeDetails = UpdateResponderRecipeDetails,
                    IfMatch = IfMatch,
                    OpcRequestId = OpcRequestId
                };

                response = client.UpdateResponderRecipe(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ResponderRecipe);
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

        private UpdateResponderRecipeResponse response;
    }
}
