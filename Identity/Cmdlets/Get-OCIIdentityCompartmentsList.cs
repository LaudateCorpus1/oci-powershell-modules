/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;
using Oci.IdentityService.Models;

namespace Oci.IdentityService.Cmdlets
{
    [Cmdlet("Get", "OCIIdentityCompartmentsList")]
    [OutputType(new System.Type[] { typeof(Oci.IdentityService.Models.Compartment), typeof(Oci.IdentityService.Responses.ListCompartmentsResponse) })]
    public class GetOCIIdentityCompartmentsList : OCIIdentityCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment (remember that the tenancy is simply the root compartment).")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated ""List"" call.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Valid values are `ANY` and `ACCESSIBLE`. Default is `ANY`. Setting this to `ACCESSIBLE` returns only those compartments for which the user has INSPECT permissions directly or indirectly (permissions can be on a resource in a subcompartment). For the compartments on which the user indirectly has INSPECT permissions, a restricted set of fields is returned.

When set to `ANY` permissions are not checked.")]
        public System.Nullable<Oci.IdentityService.Requests.ListCompartmentsRequest.AccessLevelEnum> AccessLevel { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Default is false. Can only be set to true when performing ListCompartments on the tenancy (root compartment). When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are returned depending on the the setting of `accessLevel`.")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to only return resources that match the given name exactly.")]
        public string Name { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can provide one sort order (`sortOrder`). Default order for TIMECREATED is descending. Default order for NAME is ascending. The NAME sort order is case sensitive.

**Note:** In general, some ""List"" operations (for example, `ListInstances`) let you optionally filter by Availability Domain if the scope of the resource type is within a single Availability Domain. If you call one of these ""List"" operations without specifying an Availability Domain, the resources are grouped by Availability Domain, then sorted.")]
        public System.Nullable<Oci.IdentityService.Requests.ListCompartmentsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`). The NAME sort order is case sensitive.")]
        public System.Nullable<Oci.IdentityService.Requests.ListCompartmentsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to only return resources that match the given lifecycle state.  The state value is case-insensitive.")]
        public System.Nullable<Oci.IdentityService.Models.Compartment.LifecycleStateEnum> LifecycleState { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListCompartmentsRequest request;

            try
            {
                request = new ListCompartmentsRequest
                {
                    CompartmentId = CompartmentId,
                    Page = Page,
                    Limit = Limit,
                    AccessLevel = AccessLevel,
                    CompartmentIdInSubtree = CompartmentIdInSubtree,
                    Name = Name,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    LifecycleState = LifecycleState
                };
                IEnumerable<ListCompartmentsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListCompartmentsResponse> DefaultRequest(ListCompartmentsRequest request) => Enumerable.Repeat(client.ListCompartments(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListCompartmentsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListCompartmentsResponse response;
        private delegate IEnumerable<ListCompartmentsResponse> RequestDelegate(ListCompartmentsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
