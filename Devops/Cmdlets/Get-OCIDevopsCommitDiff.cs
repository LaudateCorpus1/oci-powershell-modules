/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210630
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DevopsService.Requests;
using Oci.DevopsService.Responses;
using Oci.DevopsService.Models;

namespace Oci.DevopsService.Cmdlets
{
    [Cmdlet("Get", "OCIDevopsCommitDiff")]
    [OutputType(new System.Type[] { typeof(Oci.DevopsService.Models.DiffResponse), typeof(Oci.DevopsService.Responses.GetCommitDiffResponse) })]
    public class GetOCIDevopsCommitDiff : OCIDevopsCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"unique Repository identifier.")]
        public string RepositoryId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The commit or ref name where changes are coming from")]
        public string TargetVersion { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The commit or ref name to compare changes against. If baseVersion is not provided, the diff will be gone against an empty tree.")]
        public string BaseVersion { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"boolean for whether to use merge base or most recent revision")]
        public System.Nullable<bool> IsComparisonFromMergeBase { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request.  If you need to contact Oracle about a particular request, provide the request ID.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetCommitDiffRequest request;

            try
            {
                request = new GetCommitDiffRequest
                {
                    RepositoryId = RepositoryId,
                    TargetVersion = TargetVersion,
                    BaseVersion = BaseVersion,
                    IsComparisonFromMergeBase = IsComparisonFromMergeBase,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetCommitDiff(request).GetAwaiter().GetResult();
                WriteOutput(response, response.DiffResponse);
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

        private GetCommitDiffResponse response;
    }
}
