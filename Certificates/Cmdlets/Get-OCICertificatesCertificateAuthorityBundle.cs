/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20210224
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.CertificatesService.Requests;
using Oci.CertificatesService.Responses;
using Oci.CertificatesService.Models;

namespace Oci.CertificatesService.Cmdlets
{
    [Cmdlet("Get", "OCICertificatesCertificateAuthorityBundle")]
    [OutputType(new System.Type[] { typeof(Oci.CertificatesService.Models.CertificateAuthorityBundle), typeof(Oci.CertificatesService.Responses.GetCertificateAuthorityBundleResponse) })]
    public class GetOCICertificatesCertificateAuthorityBundle : OCICertificatesCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The OCID of the certificate authority (CA).")]
        public string CertificateAuthorityId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The version number of the certificate authority (CA).")]
        public System.Nullable<long> VersionNumber { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The name of the certificate authority (CA). (This might be referred to as the name of the CA version, as every CA consists of at least one version.) Names are unique across versions of a given CA.")]
        public string CertificateAuthorityVersionName { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The rotation state of the certificate version.")]
        public System.Nullable<Oci.CertificatesService.Requests.GetCertificateAuthorityBundleRequest.StageEnum> Stage { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetCertificateAuthorityBundleRequest request;

            try
            {
                request = new GetCertificateAuthorityBundleRequest
                {
                    CertificateAuthorityId = CertificateAuthorityId,
                    OpcRequestId = OpcRequestId,
                    VersionNumber = VersionNumber,
                    CertificateAuthorityVersionName = CertificateAuthorityVersionName,
                    Stage = Stage
                };

                response = client.GetCertificateAuthorityBundle(request).GetAwaiter().GetResult();
                WriteOutput(response, response.CertificateAuthorityBundle);
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

        private GetCertificateAuthorityBundleResponse response;
    }
}
