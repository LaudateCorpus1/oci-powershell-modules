/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DatascienceService.Requests;
using Oci.DatascienceService.Responses;
using Oci.DatascienceService.Models;

namespace Oci.DatascienceService.Cmdlets
{
    [Cmdlet("Get", "OCIDatascienceModelDeploymentShapesList")]
    [OutputType(new System.Type[] { typeof(Oci.DatascienceService.Models.ModelDeploymentShapeSummary), typeof(Oci.DatascienceService.Responses.ListModelDeploymentShapesResponse) })]
    public class GetOCIDatascienceModelDeploymentShapesList : OCIDataScienceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"<b>Filter</b> results by the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle assigned identifier for the request. If you need to contact Oracle about a particular request, then provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The maximum number of results per page, or items to return in a paginated ""List"" call. 1 is the minimum, 1000 is the maximum. See [List Pagination](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/usingapi.htm#nine).

Example: `500`", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"For list pagination. The value of the `opc-next-page` response header from the previous ""List"" call.

See [List Pagination](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/usingapi.htm#nine).")]
        public string Page { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListModelDeploymentShapesRequest request;

            try
            {
                request = new ListModelDeploymentShapesRequest
                {
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page
                };
                IEnumerable<ListModelDeploymentShapesResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListModelDeploymentShapesResponse> DefaultRequest(ListModelDeploymentShapesRequest request) => Enumerable.Repeat(client.ListModelDeploymentShapes(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListModelDeploymentShapesResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListModelDeploymentShapesResponse response;
        private delegate IEnumerable<ListModelDeploymentShapesResponse> RequestDelegate(ListModelDeploymentShapesRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
