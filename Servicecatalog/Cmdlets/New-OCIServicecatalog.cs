/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210527
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.ServicecatalogService.Requests;
using Oci.ServicecatalogService.Responses;
using Oci.ServicecatalogService.Models;

namespace Oci.ServicecatalogService.Cmdlets
{
    [Cmdlet("New", "OCIServicecatalog")]
    [OutputType(new System.Type[] { typeof(Oci.ServicecatalogService.Models.ServiceCatalog), typeof(Oci.ServicecatalogService.Responses.CreateServiceCatalogResponse) })]
    public class NewOCIServicecatalog : OCIServiceCatalogCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The details for creating a service catalog.")]
        public CreateServiceCatalogDetails CreateServiceCatalogDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations (for example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected).")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateServiceCatalogRequest request;

            try
            {
                request = new CreateServiceCatalogRequest
                {
                    CreateServiceCatalogDetails = CreateServiceCatalogDetails,
                    OpcRetryToken = OpcRetryToken,
                    OpcRequestId = OpcRequestId
                };

                response = client.CreateServiceCatalog(request).GetAwaiter().GetResult();
                WriteOutput(response, response.ServiceCatalog);
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

        private CreateServiceCatalogResponse response;
    }
}
