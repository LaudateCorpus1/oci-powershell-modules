/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190101
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.DatascienceService.Requests;
using Oci.DatascienceService.Responses;
using Oci.DatascienceService.Models;

namespace Oci.DatascienceService.Cmdlets
{
    [Cmdlet("New", "OCIDatascienceJobArtifact")]
    [OutputType(new System.Type[] { typeof(void), typeof(Oci.DatascienceService.Responses.CreateJobArtifactResponse) })]
    public class NewOCIDatascienceJobArtifact : OCIDataScienceCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the job.")]
        public string JobId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The content length of the body.")]
        public System.Nullable<long> ContentLength { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The job artifact to upload.", ParameterSetName = FromStreamSet)]
        public System.IO.Stream JobArtifact { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Use this parameter to provide the file location from where the input stream to be read. The job artifact to upload.", ParameterSetName = FromFileSet)]
        public String JobArtifactFromFile { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Oracle assigned identifier for the request. If you need to contact Oracle about a particular request, then provide the request ID.")]
        public string OpcRequestId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"A token that uniquely identifies a request so it can be retried in case of a timeout or server error without risk of executing that same action again. Retry tokens expire after 24 hours, but can be invalidated before then due to conflicting operations. For example, if a resource has been deleted and purged from the system, then a retry of the original creation request might be rejected.")]
        public string OpcRetryToken { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"This header allows you to specify a filename during upload. This file name is used to dispose of the file contents while downloading the file. If this optional field is not populated in the request, then the OCID of the model is used for the file name when downloading. Example: `{""Content-Disposition"": ""attachment""            ""filename""=""model.tar.gz""            ""Content-Length"": ""2347""            ""Content-Type"": ""application/gzip""}`")]
        public string ContentDisposition { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            CreateJobArtifactRequest request;

            if (ParameterSetName.Equals(FromFileSet))
            {
                JobArtifact = System.IO.File.OpenRead(GetAbsoluteFilePath(JobArtifactFromFile));
            }
            

            try
            {
                request = new CreateJobArtifactRequest
                {
                    JobId = JobId,
                    ContentLength = ContentLength,
                    JobArtifact = JobArtifact,
                    OpcRequestId = OpcRequestId,
                    OpcRetryToken = OpcRetryToken,
                    ContentDisposition = ContentDisposition
                };

                response = client.CreateJobArtifact(request).GetAwaiter().GetResult();
                WriteOutput(response);
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

        private CreateJobArtifactResponse response;
        private const string FromFileSet = "FromFile";
        private const string FromStreamSet = "FromStream";
    }
}
