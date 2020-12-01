/**
 * Copyright (c) 2020, Oracle and/or its affiliates.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */
using System;
using System.Management.Automation;
using Oci.Common;

/// <summary>
/// Gets a Realm object corresponding the Realm ID.
/// </summary>
namespace Oci.PSModules.Common.Cmdlets
{
    [Cmdlet("Get", "OCIRealm")]
    [OutputType(typeof(Realm))]
    public class GetOCIRealm : PSCmdlet
    {
        [Parameter(Mandatory = true, HelpMessage = "Realm Identifier of the realm. eg) oc1")]
        public String RealmId { get; set; }

        protected override void ProcessRecord()
        {
            WriteObject(Realm.ValueOf(RealmId));
        }
    }
}