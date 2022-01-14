/*
 * NOTE: Generated using OracleSDKGenerator, API Version: v1
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.IdentitydataplaneService.Requests;
using Oci.IdentitydataplaneService.Responses;
using Oci.IdentitydataplaneService.Models;

namespace Oci.IdentitydataplaneService.Cmdlets
{
    [Cmdlet("New", "OCIIdentitydataplaneScopedAccessToken")]
    [OutputType(new System.Type[] { typeof(Oci.IdentitydataplaneService.Models.SecurityToken), typeof(Oci.IdentitydataplaneService.Responses.GenerateScopedAccessTokenResponse) })]
    public class NewOCIIdentitydataplaneScopedAccessToken : OCIDataplaneCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Scoped Access token request")]
        public GenerateScopedAccessTokenDetails GenerateScopedAccessTokenDetails { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GenerateScopedAccessTokenRequest request;

            try
            {
                request = new GenerateScopedAccessTokenRequest
                {
                    GenerateScopedAccessTokenDetails = GenerateScopedAccessTokenDetails
                };

                response = client.GenerateScopedAccessToken(request).GetAwaiter().GetResult();
                WriteOutput(response, response.SecurityToken);
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

        private GenerateScopedAccessTokenResponse response;
    }
}