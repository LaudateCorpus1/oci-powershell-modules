/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.LimitsService.Requests;
using Oci.LimitsService.Responses;
using Oci.LimitsService.Models;

namespace Oci.LimitsService.Cmdlets
{
    [Cmdlet("Get", "OCILimitsQuotasList")]
    [OutputType(new System.Type[] { typeof(Oci.LimitsService.Models.QuotaSummary), typeof(Oci.LimitsService.Responses.ListQuotasResponse) })]
    public class GetOCILimitsQuotasList : OCIQuotasCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the parent compartment (remember that the tenancy is simply the root compartment).")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated ""List"" call.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"name")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Filters returned quotas based on whether the given state.")]
        public System.Nullable<Oci.LimitsService.Requests.ListQuotasRequest.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' or 'desc'. By default it will be ascending.")]
        public System.Nullable<Oci.LimitsService.Requests.ListQuotasRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Time created is default ordered as descending. Display name is default ordered as ascending.")]
        public System.Nullable<Oci.LimitsService.Requests.ListQuotasRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListQuotasRequest request;

            try
            {
                request = new ListQuotasRequest
                {
                    CompartmentId = CompartmentId,
                    Page = Page,
                    Limit = Limit,
                    Name = Name,
                    LifecycleState = LifecycleState,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListQuotasResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.Items, true);
                }
                if(!ParameterSetName.Equals(AllPageSet) && response.OpcNextPage != null)
                {
                    WriteWarning("This operation supports pagination and not all resources were returned.  Re-run using the -all option to auto paginate and list all resources.");
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
            IEnumerable<ListQuotasResponse> DefaultRequest(ListQuotasRequest request) => Enumerable.Repeat(client.ListQuotas(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListQuotasResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListQuotasResponse response;
        private delegate IEnumerable<ListQuotasResponse> RequestDelegate(ListQuotasRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
