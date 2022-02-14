/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20181201
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DatasafeService.Requests;
using Oci.DatasafeService.Responses;
using Oci.DatasafeService.Models;

namespace Oci.DatasafeService.Cmdlets
{
    [Cmdlet("Get", "OCIDatasafeUserAnalyticsList")]
    [OutputType(new System.Type[] { typeof(Oci.DatasafeService.Models.UserAggregation), typeof(Oci.DatasafeService.Responses.ListUserAnalyticsResponse) })]
    public class GetOCIDatasafeUserAnalyticsList : OCIDataSafeCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the user assessment.")]
        public string UserAssessmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Default is false. When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are returned. Depends on the 'accessLevel' setting.")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Valid values are RESTRICTED and ACCESSIBLE. Default is RESTRICTED. Setting this to ACCESSIBLE returns only those compartments for which the user has INSPECT permissions directly or indirectly (permissions can be on a resource in a subcompartment). When set to RESTRICTED permissions are checked and no partial results are displayed.")]
        public System.Nullable<Oci.DatasafeService.Requests.ListUserAnalyticsRequest.AccessLevelEnum> AccessLevel { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of items to return per page in a paginated ""List"" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only items that match the specified user category.")]
        public string UserCategory { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only items that match the specified user key.")]
        public string UserKey { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only items that match the specified account status.")]
        public string AccountStatus { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only items that match the specified authentication type.")]
        public string AuthenticationType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only items that match the specified user name.")]
        public string UserName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return only items related to a specific target OCID.")]
        public string TargetId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return users whose last login time in the database is greater than or equal to the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).

**Example:** 2016-12-19T16:39:57.600Z")]
        public System.Nullable<System.DateTime> TimeLastLoginGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return users whose last login time in the database is less than the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339). **Example:** 2016-12-19T16:39:57.600Z")]
        public System.Nullable<System.DateTime> TimeLastLoginLessThan { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return users whose creation time in the database is greater than or equal to the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339). **Example:** 2016-12-19T16:39:57.600Z")]
        public System.Nullable<System.DateTime> TimeUserCreatedGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return users whose creation time in the database is less than the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339). **Example:** 2016-12-19T16:39:57.600Z")]
        public System.Nullable<System.DateTime> TimeUserCreatedLessThan { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return users whose last password change in the database is greater than or equal to the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).

**Example:** 2016-12-19T16:39:57.600Z")]
        public System.Nullable<System.DateTime> TimePasswordLastChangedGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A filter to return users whose last password change in the database is less than the date and time specified, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).

**Example:** 2016-12-19T16:39:57.600Z")]
        public System.Nullable<System.DateTime> TimePasswordLastChangedLessThan { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The page token representing the page at which to start retrieving results. It is usually retrieved from a previous ""List"" call. For details about how pagination works, see [List Pagination](https://docs.cloud.oracle.com/en-us/iaas/Content/API/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (ASC) or descending (DESC).")]
        public System.Nullable<Oci.DatasafeService.Requests.ListUserAnalyticsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. You can specify only one sort order (sortOrder). The default order for userName is ascending.")]
        public System.Nullable<Oci.DatasafeService.Requests.ListUserAnalyticsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListUserAnalyticsRequest request;

            try
            {
                request = new ListUserAnalyticsRequest
                {
                    UserAssessmentId = UserAssessmentId,
                    CompartmentIdInSubtree = CompartmentIdInSubtree,
                    AccessLevel = AccessLevel,
                    Limit = Limit,
                    UserCategory = UserCategory,
                    UserKey = UserKey,
                    AccountStatus = AccountStatus,
                    AuthenticationType = AuthenticationType,
                    UserName = UserName,
                    TargetId = TargetId,
                    TimeLastLoginGreaterThanOrEqualTo = TimeLastLoginGreaterThanOrEqualTo,
                    TimeLastLoginLessThan = TimeLastLoginLessThan,
                    TimeUserCreatedGreaterThanOrEqualTo = TimeUserCreatedGreaterThanOrEqualTo,
                    TimeUserCreatedLessThan = TimeUserCreatedLessThan,
                    TimePasswordLastChangedGreaterThanOrEqualTo = TimePasswordLastChangedGreaterThanOrEqualTo,
                    TimePasswordLastChangedLessThan = TimePasswordLastChangedLessThan,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListUserAnalyticsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListUserAnalyticsResponse> DefaultRequest(ListUserAnalyticsRequest request) => Enumerable.Repeat(client.ListUserAnalytics(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListUserAnalyticsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListUserAnalyticsResponse response;
        private delegate IEnumerable<ListUserAnalyticsResponse> RequestDelegate(ListUserAnalyticsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
