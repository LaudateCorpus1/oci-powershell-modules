/*
 * NOTE: Generated using OracleSDKGenerator, API Version: 20190801
 * DO NOT EDIT this file manually.
 *
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

using System;
using System.Management.Automation;
using Oci.OsmanagementService.Requests;
using Oci.OsmanagementService.Responses;
using Oci.OsmanagementService.Models;

namespace Oci.OsmanagementService.Cmdlets
{
    [Cmdlet("Get", "OCIOsmanagementEvent")]
    [OutputType(new System.Type[] { typeof(Oci.OsmanagementService.Models.Event), typeof(Oci.OsmanagementService.Responses.GetEventResponse) })]
    public class GetOCIOsmanagementEvent : OCIEventCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Instance Oracle Cloud identifier (ocid)")]
        public string ManagedInstanceId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"Unique Event identifier (OCID)")]
        public string EventId { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID of the compartment in which to list resources.")]
        public string CompartmentId { get; set; }

        [Parameter(Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = @"The client request ID for tracing.")]
        public string OpcRequestId { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GetEventRequest request;

            try
            {
                request = new GetEventRequest
                {
                    ManagedInstanceId = ManagedInstanceId,
                    EventId = EventId,
                    CompartmentId = CompartmentId,
                    OpcRequestId = OpcRequestId
                };

                response = client.GetEvent(request).GetAwaiter().GetResult();
                WriteOutput(response, response.Event);
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

        private GetEventResponse response;
    }
}
