/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180608
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.VaultService.Requests;
using Oci.VaultService.Responses;
using Oci.VaultService.Models;

namespace Oci.VaultService.Cmdlets
{
    [Cmdlet("Get", "OCIVaultSecretVersionsList")]
    [OutputType(new System.Type[] { typeof(Oci.VaultService.Models.SecretVersionSummary), typeof(Oci.VaultService.Responses.ListSecretVersionsResponse) })]
    public class GetOCIVaultSecretVersionsList : OCIVaultsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the secret.")]
        public string SecretId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a paginated ""List"" call.", ParameterSetName = LimitSet)]
        public System.Nullable<int> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique identifier for the request. If provided, the returned request ID will include this value. Otherwise, a random request ID will be generated by the service.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field to sort by. Only one sort order may be provided. Time created is default ordered as descending. Display name is default ordered as ascending.")]
        public System.Nullable<Oci.VaultService.Requests.ListSecretVersionsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The sort order to use, either ascending (`ASC`) or descending (`DESC`).")]
        public System.Nullable<Oci.VaultService.Requests.ListSecretVersionsRequest.SortOrderEnum> SortOrder { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSecretVersionsRequest request;

            try
            {
                request = new ListSecretVersionsRequest
                {
                    SecretId = SecretId,
                    Limit = Limit,
                    Page = Page,
                    OpcRequestId = OpcRequestId,
                    SortBy = SortBy,
                    SortOrder = SortOrder
                };
                IEnumerable<ListSecretVersionsResponse> responses = GetRequestDelegate().Invoke(request);
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
            IEnumerable<ListSecretVersionsResponse> DefaultRequest(ListSecretVersionsRequest request) => Enumerable.Repeat(client.ListSecretVersions(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.ListSecretVersionsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private ListSecretVersionsResponse response;
        private delegate IEnumerable<ListSecretVersionsResponse> RequestDelegate(ListSecretVersionsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
