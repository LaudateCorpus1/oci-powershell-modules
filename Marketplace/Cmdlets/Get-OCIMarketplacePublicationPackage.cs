/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181001
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.MarketplaceService.Requests;
using Oci.MarketplaceService.Responses;
using Oci.MarketplaceService.Models;

namespace Oci.MarketplaceService.Cmdlets
{
    [Cmdlet("Get", "OCIMarketplacePublicationPackage")]
    [OutputType(new System.Type[] { typeof(Oci.MarketplaceService.Models.PublicationPackage), typeof(Oci.MarketplaceService.Responses.GetPublicationPackageResponse) })]
    public class GetOCIMarketplacePublicationPackage : OCIMarketplaceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The unique identifier for the listing.")]
        public string PublicationId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The version of the package. Package versions are unique within a listing.")]
        public string PackageVersion { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetPublicationPackageRequest request;

            try
            {
                request = new GetPublicationPackageRequest
                {
                    PublicationId = PublicationId,
                    PackageVersion = PackageVersion,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetPublicationPackage(request).GetAwaiter().GetResult();
                WriteOutput(response, response.PublicationPackage);
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

        private GetPublicationPackageResponse response;
    }
}
