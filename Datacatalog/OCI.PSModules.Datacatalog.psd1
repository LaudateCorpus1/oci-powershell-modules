#
# Module manifest for module 'OCI.PSModules.Datacatalog'
#
# Generated by: Oracle Cloud Infrastructure
#
# Generated on: 07/22/2021
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'assemblies/OCI.PSModules.Datacatalog.dll'

# Version number of this module.
ModuleVersion = '18.1.0'

# Supported PSEditions
CompatiblePSEditions = 'Core'

# ID used to uniquely identify this module
GUID = 'f0444859-1d26-4a2d-8bcd-5551939e4f94'

# Author of this module
Author = 'Oracle Cloud Infrastructure'

# Company or vendor of this module
CompanyName = 'Oracle Corporation'

# Copyright statement for this module
Copyright = '(c) Oracle Cloud Infrastructure. All rights reserved.'

# Description of the functionality provided by this module
Description = 'This modules provides Cmdlets for OCI Datacatalog Service'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '6.0'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# DotNetFrameworkVersion = ''

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'OCI.PSModules.Common'; GUID = 'b3061a0d-375b-4099-ae76-f92fb3cdcdae'; RequiredVersion = '18.1.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'assemblies/OCI.DotNetSDK.Datacatalog.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = '*'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Add-OCIDatacatalogDataSelectorPatterns', 
               'Confirm-OCIDatacatalogConnection', 'Confirm-OCIDatacatalogPattern', 
               'DisMount-OCIDatacatalogCatalogPrivateEndpoint', 
               'Export-OCIDatacatalogGlossary', 
               'Get-OCIDatacatalogAggregatedPhysicalEntitiesList', 
               'Get-OCIDatacatalogAttribute', 'Get-OCIDatacatalogAttributesList', 
               'Get-OCIDatacatalogAttributeTag', 
               'Get-OCIDatacatalogAttributeTagsList', 'Get-OCIDatacatalogCatalog', 
               'Get-OCIDatacatalogCatalogPrivateEndpoint', 
               'Get-OCIDatacatalogCatalogPrivateEndpointsList', 
               'Get-OCIDatacatalogCatalogsList', 'Get-OCIDatacatalogConnection', 
               'Get-OCIDatacatalogConnectionsList', 
               'Get-OCIDatacatalogCustomPropertiesList', 
               'Get-OCIDatacatalogCustomProperty', 'Get-OCIDatacatalogDataAsset', 
               'Get-OCIDatacatalogDataAssetsList', 
               'Get-OCIDatacatalogDataAssetTag', 
               'Get-OCIDatacatalogDataAssetTagsList', 
               'Get-OCIDatacatalogDerivedLogicalEntitiesList', 
               'Get-OCIDatacatalogEntitiesList', 'Get-OCIDatacatalogEntity', 
               'Get-OCIDatacatalogEntityTag', 'Get-OCIDatacatalogEntityTagsList', 
               'Get-OCIDatacatalogFolder', 'Get-OCIDatacatalogFoldersList', 
               'Get-OCIDatacatalogFolderTag', 'Get-OCIDatacatalogFolderTagsList', 
               'Get-OCIDatacatalogGlossariesList', 'Get-OCIDatacatalogGlossary', 
               'Get-OCIDatacatalogJob', 'Get-OCIDatacatalogJobDefinition', 
               'Get-OCIDatacatalogJobDefinitionsList', 
               'Get-OCIDatacatalogJobExecution', 
               'Get-OCIDatacatalogJobExecutionsList', 'Get-OCIDatacatalogJobLog', 
               'Get-OCIDatacatalogJobLogsList', 'Get-OCIDatacatalogJobMetrics', 
               'Get-OCIDatacatalogJobMetricsList', 'Get-OCIDatacatalogJobsList', 
               'Get-OCIDatacatalogMetastore', 'Get-OCIDatacatalogMetastoresList', 
               'Get-OCIDatacatalogNamespace', 'Get-OCIDatacatalogNamespacesList', 
               'Get-OCIDatacatalogPattern', 'Get-OCIDatacatalogPatternsList', 
               'Get-OCIDatacatalogRulesList', 'Get-OCIDatacatalogTagsList', 
               'Get-OCIDatacatalogTerm', 'Get-OCIDatacatalogTermRelationship', 
               'Get-OCIDatacatalogTermRelationshipsList', 
               'Get-OCIDatacatalogTermsList', 'Get-OCIDatacatalogType', 
               'Get-OCIDatacatalogTypesList', 'Get-OCIDatacatalogWorkRequest', 
               'Get-OCIDatacatalogWorkRequestErrorsList', 
               'Get-OCIDatacatalogWorkRequestLogsList', 
               'Get-OCIDatacatalogWorkRequestsList', 
               'Import-OCIDatacatalogConnection', 'Import-OCIDatacatalogDataAsset', 
               'Import-OCIDatacatalogGlossary', 
               'Invoke-OCIDatacatalogAssociateCustomProperty', 
               'Invoke-OCIDatacatalogDisassociateCustomProperty', 
               'Invoke-OCIDatacatalogExpandTreeForGlossary', 
               'Invoke-OCIDatacatalogObjectStats', 
               'Invoke-OCIDatacatalogParseConnection', 
               'Invoke-OCIDatacatalogProcessRecommendation', 
               'Invoke-OCIDatacatalogRecommendations', 
               'Invoke-OCIDatacatalogSearchCriteria', 
               'Invoke-OCIDatacatalogSuggestMatches', 
               'Invoke-OCIDatacatalogSynchronousExportDataAsset', 
               'Invoke-OCIDatacatalogTestConnection', 'Invoke-OCIDatacatalogUsers', 
               'Mount-OCIDatacatalogCatalogPrivateEndpoint', 
               'Move-OCIDatacatalogCatalogCompartment', 
               'Move-OCIDatacatalogCatalogPrivateEndpointCompartment', 
               'Move-OCIDatacatalogMetastoreCompartment', 
               'New-OCIDatacatalogAttribute', 'New-OCIDatacatalogAttributeTag', 
               'New-OCIDatacatalogCatalog', 
               'New-OCIDatacatalogCatalogPrivateEndpoint', 
               'New-OCIDatacatalogConnection', 'New-OCIDatacatalogCustomProperty', 
               'New-OCIDatacatalogDataAsset', 'New-OCIDatacatalogDataAssetTag', 
               'New-OCIDatacatalogEntity', 'New-OCIDatacatalogEntityTag', 
               'New-OCIDatacatalogFolder', 'New-OCIDatacatalogFolderTag', 
               'New-OCIDatacatalogGlossary', 'New-OCIDatacatalogJob', 
               'New-OCIDatacatalogJobDefinition', 'New-OCIDatacatalogJobExecution', 
               'New-OCIDatacatalogMetastore', 'New-OCIDatacatalogNamespace', 
               'New-OCIDatacatalogPattern', 'New-OCIDatacatalogTerm', 
               'New-OCIDatacatalogTermRelationship', 
               'Remove-OCIDatacatalogAttribute', 
               'Remove-OCIDatacatalogAttributeTag', 'Remove-OCIDatacatalogCatalog', 
               'Remove-OCIDatacatalogCatalogPrivateEndpoint', 
               'Remove-OCIDatacatalogConnection', 
               'Remove-OCIDatacatalogCustomProperty', 
               'Remove-OCIDatacatalogDataAsset', 
               'Remove-OCIDatacatalogDataAssetTag', 
               'Remove-OCIDatacatalogDataSelectorPatterns', 
               'Remove-OCIDatacatalogEntity', 'Remove-OCIDatacatalogEntityTag', 
               'Remove-OCIDatacatalogFolder', 'Remove-OCIDatacatalogFolderTag', 
               'Remove-OCIDatacatalogGlossary', 'Remove-OCIDatacatalogJob', 
               'Remove-OCIDatacatalogJobDefinition', 
               'Remove-OCIDatacatalogMetastore', 'Remove-OCIDatacatalogNamespace', 
               'Remove-OCIDatacatalogPattern', 'Remove-OCIDatacatalogTerm', 
               'Remove-OCIDatacatalogTermRelationship', 
               'Update-OCIDatacatalogAttribute', 'Update-OCIDatacatalogCatalog', 
               'Update-OCIDatacatalogCatalogPrivateEndpoint', 
               'Update-OCIDatacatalogConnection', 
               'Update-OCIDatacatalogCustomProperty', 
               'Update-OCIDatacatalogDataAsset', 'Update-OCIDatacatalogEntity', 
               'Update-OCIDatacatalogFolder', 'Update-OCIDatacatalogGlossary', 
               'Update-OCIDatacatalogJob', 'Update-OCIDatacatalogJobDefinition', 
               'Update-OCIDatacatalogMetastore', 'Update-OCIDatacatalogNamespace', 
               'Update-OCIDatacatalogPattern', 'Update-OCIDatacatalogTerm', 
               'Update-OCIDatacatalogTermRelationship', 
               'Write-OCIDatacatalogCredentials'

# Variables to export from this module
VariablesToExport = '*'

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = '*'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'PSEdition_Core','Windows','Linux','macOS','Oracle','OCI','Cloud','OracleCloudInfrastructure','Datacatalog'

        # A URL to the license for this module.
        LicenseUri = 'https://github.com/oracle/oci-powershell-modules/blob/master/LICENSE.txt'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/oracle/oci-powershell-modules/'

        # A URL to an icon representing this module.
        IconUri = 'https://github.com/oracle/oci-powershell-modules/blob/master/icon.png'

        # ReleaseNotes of this module
        ReleaseNotes = 'https://github.com/oracle/oci-powershell-modules/blob/master/CHANGELOG.md'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

