/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20160918
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.IdentityService.Requests;
using Oci.IdentityService.Responses;
using Oci.IdentityService.Models;

namespace Oci.IdentityService.Cmdlets
{
    [Cmdlet("Get", "OCIIdentitySmtpCredentialsList")]
    [OutputType(new System.Type[] { typeof(Oci.IdentityService.Models.SmtpCredentialSummary), typeof(Oci.IdentityService.Responses.ListSmtpCredentialsResponse) })]
    public class GetOCIIdentitySmtpCredentialsList : OCIIdentityCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the user.")]
        public string UserId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ListSmtpCredentialsRequest request;

            try
            {
                request = new ListSmtpCredentialsRequest
                {
                    UserId = UserId
                };

                response = client.ListSmtpCredentials(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Items, true);
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

        private ListSmtpCredentialsResponse response;
    }
}
