/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20180115
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Oci.DnsService.Requests;
using Oci.DnsService.Responses;
using Oci.DnsService.Models;

namespace Oci.DnsService.Cmdlets
{
    [Cmdlet("Get", "OCIDnsDomainRecords")]
    [OutputType(new System.Type[] { typeof(Oci.DnsService.Models.RecordCollection), typeof(Oci.DnsService.Responses.GetDomainRecordsResponse) })]
    public class GetOCIDnsDomainRecords : OCIDnsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name or OCID of the target zone.")]
        public string ZoneNameOrId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The target fully-qualified domain name (FQDN) within the target zone.")]
        public string Domain { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The `If-None-Match` header field makes the request method conditional on the absence of any current representation of the target resource, when the field-value is `*`, or having a selected representation with an entity-tag that does not match any of those listed in the field-value.")]
        public string IfNoneMatch { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The `If-Modified-Since` header field makes a GET or HEAD request method conditional on the selected representation's modification date being more recent than the date provided in the field-value.  Transfer of the selected representation's data is avoided if that data has not changed.")]
        public string IfModifiedSince { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The maximum number of items to return in a page of the collection.", ParameterSetName = LimitSet)]
        public System.Nullable<long> Limit { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The value of the `opc-next-page` response header from the previous ""List"" call.")]
        public string Page { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The version of the zone for which data is requested.")]
        public string ZoneVersion { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Search by record type. Will match any record whose [type](https://www.iana.org/assignments/dns-parameters/dns-parameters.xhtml#dns-parameters-4) (case-insensitive) equals the provided value.")]
        public string Rtype { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Specifies to operate only on resources that have a matching DNS scope.")]
        public System.Nullable<Oci.DnsService.Models.Scope> Scope { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the view the resource is associated with.")]
        public string ViewId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The field by which to sort records.")]
        public System.Nullable<Oci.DnsService.Requests.GetDomainRecordsRequest.SortByEnum> SortBy { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The order to sort the resources.")]
        public System.Nullable<Oci.DnsService.Models.SortOrder> SortOrder { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the compartment the resource belongs to.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Fetches all pages of results.", ParameterSetName = AllPageSet)]
        public SwitchParameter All { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetDomainRecordsRequest request;

            try
            {
                request = new GetDomainRecordsRequest
                {
                    ZoneNameOrId = ZoneNameOrId,
                    Domain = Domain,
                    IfNoneMatch = IfNoneMatch,
                    IfModifiedSince = IfModifiedSince,
                    OpcRequestId = OpcRequestId,
                    Limit = Limit,
                    Page = Page,
                    ZoneVersion = ZoneVersion,
                    Rtype = Rtype,
                    Scope = Scope,
                    ViewId = ViewId,
                    SortBy = SortBy,
                    SortOrder = SortOrder,
                    CompartmentId = CompartmentId
                };
                IEnumerable<GetDomainRecordsResponse> responses = GetRequestDelegate().Invoke(request);
                foreach (var item in responses)
                {
                    response = item;
                    WriteOutput(response, response.RecordCollection, true);
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
            IEnumerable<GetDomainRecordsResponse> DefaultRequest(GetDomainRecordsRequest request) => Enumerable.Repeat(client.GetDomainRecords(request).GetAwaiter().GetResult(), 1);
            if (ParameterSetName.Equals(AllPageSet))
            {
                return req => client.Paginators.GetDomainRecordsResponseEnumerator(req);
            }
            return DefaultRequest;
        }

        private GetDomainRecordsResponse response;
        private delegate IEnumerable<GetDomainRecordsResponse> RequestDelegate(GetDomainRecordsRequest request);
        private const string AllPageSet = "AllPages";
        private const string LimitSet = "Limit";
    }
}
