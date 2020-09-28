/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20200131
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.CloudguardService.Requests;
using Oci.CloudguardService.Responses;
using Oci.CloudguardService.Models;

namespace Oci.CloudguardService.Cmdlets
{
    [Cmdlet("Get", "OCICloudguardProblemsList")]
    [OutputType(new System.Type[] { typeof(Oci.CloudguardService.Models.ProblemCollection), typeof(Oci.CloudguardService.Responses.ListProblemsResponse) })]
    public class GetOCICloudguardProblemsList : OCICloudGuardCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Start time for a filter. If start time is not specified, start time will be set to today's current time - 30 days.")]
        public System.Nullable<System.DateTime> TimeLastDetectedGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"End time for a filter. If end time is not specified, end time will be set to today's current time.")]
        public System.Nullable<System.DateTime> TimeLastDetectedLessThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Start time for a filter. If start time is not specified, start time will be set to today's current time - 30 days.")]
        public System.Nullable<System.DateTime> TimeFirstDetectedGreaterThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"End time for a filter. If end time is not specified, end time will be set to today's current time.")]
        public System.Nullable<System.DateTime> TimeFirstDetectedLessThanOrEqualTo { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field life cycle state. Only one state can be provided. Default value for state is active. If no value is specified state is active.")]
        public System.Nullable<Oci.CloudguardService.Models.ProblemLifecycleDetail> LifecycleDetail { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field life cycle state. Only one state can be provided. Default value for state is active. If no value is specified state is active.")]
        public System.Nullable<Oci.CloudguardService.Models.ProblemLifecycleState> LifecycleState { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"OCI Monitoring region.This property corresponds to Region parameter in the API.")]
        public string CloudguardRegion { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Risk level of the Problem.")]
        public string RiskLevel { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Resource Type associated with the resource.")]
        public string ResourceType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"City of the problem.")]
        public string City { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"State of the problem.")]
        public string State { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Country of the problem.")]
        public string Country { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Label associated with the Problem.")]
        public string Label { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Comma seperated list of detector rule ids to be passed in to match against Problems.")]
        public System.Collections.Generic.List<string> DetectorRuleIdList { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to list the Problems by Detector Type. Valid values are IAAS_ACTIVITY_DETECTOR and IAAS_CONFIGURATION_DETECTOR")]
        public System.Nullable<Oci.CloudguardService.Models.DetectorEnum> DetectorType { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the target in which to list resources.")]
        public string TargetId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Default is false. When set to true, the hierarchy of compartments is traversed and all compartments and subcompartments in the tenancy are returned depending on the the setting of `accessLevel`.")]
        public System.Nullable<bool> CompartmentIdInSubtree { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Valid values are `RESTRICTED` and `ACCESSIBLE`. Default is `RESTRICTED`. Setting this to `ACCESSIBLE` returns only those compartments for which the user has INSPECT permissions directly or indirectly (permissions can be on a resource in a subcompartment). When set to `RESTRICTED` permissions are checked and no partial results are displayed.")]
        public System.Nullable<Oci.CloudguardService.Requests.ListProblemsRequest.AccessLevelEnum> AccessLevel { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the resource associated with the problem.")]
        public string ResourceId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either 'asc' or 'desc'.")]
        public System.Nullable<Oci.CloudguardService.Models.SortOrders> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Default order for riskLevel, timeLastDetected and resourceName is descending. Default order for riskLevel and resourceName is ascending. If no value is specified timeLastDetected is default.")]
        public System.Nullable<Oci.CloudguardService.Requests.ListProblemsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListProblemsRequest request;

            try
            {
                request = new ListProblemsRequest
                {
                    CompartmentId = CompartmentId,
                    TimeLastDetectedGreaterThanOrEqualTo = TimeLastDetectedGreaterThanOrEqualTo,
                    TimeLastDetectedLessThanOrEqualTo = TimeLastDetectedLessThanOrEqualTo,
                    TimeFirstDetectedGreaterThanOrEqualTo = TimeFirstDetectedGreaterThanOrEqualTo,
                    TimeFirstDetectedLessThanOrEqualTo = TimeFirstDetectedLessThanOrEqualTo,
                    LifecycleDetail = LifecycleDetail,
                    LifecycleState = LifecycleState,
                    Region = CloudguardRegion,
                    RiskLevel = RiskLevel,
                    ResourceType = ResourceType,
                    City = City,
                    State = State,
                    Country = Country,
                    Label = Label,
                    DetectorRuleIdList = DetectorRuleIdList,
                    DetectorType = DetectorType,
                    TargetId = TargetId,
                    CompartmentIdInSubtree = CompartmentIdInSubtree,
                    AccessLevel = AccessLevel,
                    ResourceId = ResourceId,
                    Limit = Limit,
                    Page = Page,
                    SortOrder = SortOrder,
                    SortBy = SortBy,
                    OpcRequestId = OpcRequestId
                };
                IEnumerable<ListProblemsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.ProblemCollection, true);
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
            IEnumerable<ListProblemsResponse> DefaultRequest(ListProblemsRequest request) => Enumerable.Repeat(client.ListProblems(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListProblemsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListProblemsResponse response;
        private delegate IEnumerable<ListProblemsResponse> RequestDelegate(ListProblemsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}