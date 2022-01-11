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
    [Cmdlet("Get", "OCIComputeAppCatalogListingAgreements")]
    [OutputType(new System.Type[] { typeof(Oci.CoreService.Models.AppCatalogListingResourceVersionAgreements), typeof(Oci.CoreService.Responses.GetAppCatalogListingAgreementsResponse) })]
    public class GetOCIComputeAppCatalogListingAgreements : OCIComputeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the listing.")]
        public string ListingId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Listing Resource Version.")]
        public string ResourceVersion { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetAppCatalogListingAgreementsRequest request;

            try
            {
                request = new GetAppCatalogListingAgreementsRequest
                {
                    ListingId = ListingId,
                    ResourceVersion = ResourceVersion
                };

                response = client.GetAppCatalogListingAgreements(request).GetAwaiter().GetResult();
                WriteOutput(response, response.AppCatalogListingResourceVersionAgreements);
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

        private GetAppCatalogListingAgreementsResponse response;
    }
}
