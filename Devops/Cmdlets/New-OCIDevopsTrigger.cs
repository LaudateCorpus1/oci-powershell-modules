/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210630
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DevopsService.Requests;
using Oci.DevopsService.Responses;
using Oci.DevopsService.Models;

namespace Oci.DevopsService.Cmdlets
{
    [Cmdlet("New", "OCIDevopsTrigger")]
    [OutputType(new System.Type[] { typeof(Oci.DevopsService.Models.TriggerCreateResult), typeof(Oci.DevopsService.Responses.CreateTriggerResponse) })]
    public class NewOCIDevopsTrigger : OCIDevopsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details for the new trigger. This parameter also accepts subtypes <Oci.DevopsService.Models.CreateGithubTriggerDetails>, <Oci.DevopsService.Models.CreateDevopsCodeRepositoryTriggerDetails>, <Oci.DevopsService.Models.CreateGitlabTriggerDetails> of type <Oci.DevopsService.Models.CreateTriggerDetails>.")]
        public CreateTriggerDetails CreateTriggerDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated earlier due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request.  If you need to contact Oracle about a particular request, provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateTriggerRequest request;

            try
            {
                request = new CreateTriggerRequest
                {
                    CreateTriggerDetails = CreateTriggerDetails,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId
                };

                response = client.CreateTrigger(request).GetAwaiter().GetResult();
                WriteOutput(response, response.TriggerCreateResult);
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

        private CreateTriggerResponse response;
    }
}
