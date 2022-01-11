/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181001
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.MarketplaceService.Requests;
using Oci.MarketplaceService.Responses;
using Oci.MarketplaceService.Models;

namespace Oci.MarketplaceService.Cmdlets
{
    [Cmdlet("Invoke", "OCIMarketplaceSearchListings")]
    [OutputType(new System.Type[] { typeof(Oci.MarketplaceService.Models.ListingSummary), typeof(Oci.MarketplaceService.Responses.SearchListingsResponse) })]
    public class InvokeOCIMarketplaceSearchListings : OCIMarketplaceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Details related to the search query. This parameter also accepts subtypes <Oci.MarketplaceService.Models.StructuredSearchDetails>, <Oci.MarketplaceService.Models.FreeTextSearchDetails> of type <Oci.MarketplaceService.Models.SearchListingsDetails>.")]
        public SearchListingsDetails SearchListingsDetails { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"How many records to return. Specify a value greater than zero and less than or equal to 1000. The default is 30.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            SearchListingsRequest request;

            try
            {
                request = new SearchListingsRequest
                {
                    SearchListingsDetails = SearchListingsDetails,
                    OpcRequestId = OpcRequestId,
                    Page = Page,
                    Limit = Limit
                };
                IEnumerable<SearchListingsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.Items, true);
                }
                if(!ParameterSetName.Equals(AllPageSet) && !ParameterSetName.Equals(LimitSet) && response.OpcNextPage != null)
                {
                    WriteWarning("This operation supports pagination and not all resources were returned. Re-run using the -All option to auto paginate and list all resources.");
                }
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

        private RequestDelegate GetRequestDelegate()
        {
            IEnumerable<SearchListingsResponse> DefaultRequest(SearchListingsRequest request) => Enumerable.Repeat(client.SearchListings(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.SearchListingsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private SearchListingsResponse response;
        private delegate IEnumerable<SearchListingsResponse> RequestDelegate(SearchListingsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
