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
    [Cmdlet("Get", "OCIIdentityUserGroupMembershipsList")]
    [OutputType(new System.Type[] { typeof(Oci.IdentityService.Models.UserGroupMembership), typeof(Oci.IdentityService.Responses.ListUserGroupMembershipsResponse) })]
    public class GetOCIIdentityUserGroupMembershipsList : OCIIdentityCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment (remember that the tenancy is simply the root compartment).")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the user.")]
        public string UserId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the group.")]
        public string GroupId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated ""List"" call.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListUserGroupMembershipsRequest request;

            try
            {
                request = new ListUserGroupMembershipsRequest
                {
                    CompartmentId = CompartmentId,
                    UserId = UserId,
                    GroupId = GroupId,
                    Page = Page,
                    Limit = Limit
                };
                IEnumerable<ListUserGroupMembershipsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListUserGroupMembershipsResponse> DefaultRequest(ListUserGroupMembershipsRequest request) => Enumerable.Repeat(client.ListUserGroupMemberships(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListUserGroupMembershipsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListUserGroupMembershipsResponse response;
        private delegate IEnumerable<ListUserGroupMembershipsResponse> RequestDelegate(ListUserGroupMembershipsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
