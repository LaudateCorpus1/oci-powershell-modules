/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190325
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatacatalogService.Requests;
using Oci.DatacatalogService.Responses;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Cmdlets
{
    [Cmdlet("New", "OCIDatacatalogEntity")]
    [OutputType(new System.Type[] { typeof(Oci.DatacatalogService.Models.Entity), typeof(Oci.DatacatalogService.Responses.CreateEntityResponse) })]
    public class NewOCIDatacatalogEntity : OCIDataCatalogCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique catalog identifier.")]
        public string CatalogId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique data asset key.")]
        public string DataAssetKey { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The information used to create the data entity.")]
        public CreateEntityDetails CreateEntityDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateEntityRequest request;

            try
            {
                request = new CreateEntityRequest
                {
                    CatalogId = CatalogId,
                    DataAssetKey = DataAssetKey,
                    CreateEntityDetails = CreateEntityDetails,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken
                };

                response = client.CreateEntity(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Entity);
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

        private CreateEntityResponse response;
    }
}
