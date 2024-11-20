// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;
    using Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell;
    using Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Cmdlets;
    using System;

    /// <summary>update a certificate profile.</summary>
    /// <remarks>
    /// [OpenAPI] Get=>GET:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CodeSigning/codeSigningAccounts/{accountName}/certificateProfiles/{profileName}"
    /// [OpenAPI] Create=>PUT:"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CodeSigning/codeSigningAccounts/{accountName}/certificateProfiles/{profileName}"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsData.Update, @"AzCodeSigningCertificateProfile_UpdateViaIdentityCodeSigningAccountExpanded", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Description(@"update a certificate profile.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Generated]
    public partial class UpdateAzCodeSigningCertificateProfile_UpdateViaIdentityCodeSigningAccountExpanded : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IContext
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>A dictionary to carry over additional data for pipeline.</summary>
        private global::System.Collections.Generic.Dictionary<global::System.String,global::System.Object> _extensibleParameters = new System.Collections.Generic.Dictionary<string, object>();

        /// <summary>A buffer to record first returned object in response.</summary>
        private object _firstResponse = null;

        /// <summary>Certificate profile resource.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile _resourceBody = new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.CertificateProfile();

        /// <summary>
        /// A flag to tell whether it is the first returned object in a call. Zero means no response yet. One means 1 returned object.
        /// Two means multiple returned objects in response.
        /// </summary>
        private int _responseSize = 0;

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>Accessor for cancellationTokenSource.</summary>
        public global::System.Threading.CancellationTokenSource CancellationTokenSource { get => _cancellationTokenSource ; set { _cancellationTokenSource = value; } }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.CodeSigningManagementClient Client => Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.ClientAPI;

        /// <summary>Backing field for <see cref="CodeSigningAccountInputObject" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningIdentity _codeSigningAccountInputObject;

        /// <summary>Identity Parameter</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Identity Parameter", ValueFromPipeline = true)]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Path)]
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICodeSigningIdentity CodeSigningAccountInputObject { get => this._codeSigningAccountInputObject; set => this._codeSigningAccountInputObject = value; }

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>Accessor for extensibleParameters.</summary>
        public global::System.Collections.Generic.IDictionary<global::System.String,global::System.Object> ExtensibleParameters { get => _extensibleParameters ; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Identity validation id used for the certificate subject name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Identity validation id used for the certificate subject name.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity validation id used for the certificate subject name.",
        SerializedName = @"identityValidationId",
        PossibleTypes = new [] { typeof(string) })]
        public string IdentityValidationId { get => _resourceBody.IdentityValidationId ?? null; set => _resourceBody.IdentityValidationId = value; }

        /// <summary>
        /// Whether to include L in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Whether to include L in the certificate subject name. Applicable only for private trust, private trust ci profile types")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to include L in the certificate subject name. Applicable only for private trust, private trust ci profile types",
        SerializedName = @"includeCity",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IncludeCity { get => _resourceBody.IncludeCity ?? default(global::System.Management.Automation.SwitchParameter); set => _resourceBody.IncludeCity = value; }

        /// <summary>
        /// Whether to include C in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Whether to include C in the certificate subject name. Applicable only for private trust, private trust ci profile types")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to include C in the certificate subject name. Applicable only for private trust, private trust ci profile types",
        SerializedName = @"includeCountry",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IncludeCountry { get => _resourceBody.IncludeCountry ?? default(global::System.Management.Automation.SwitchParameter); set => _resourceBody.IncludeCountry = value; }

        /// <summary>Whether to include PC in the certificate subject name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Whether to include PC in the certificate subject name.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to include PC in the certificate subject name.",
        SerializedName = @"includePostalCode",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IncludePostalCode { get => _resourceBody.IncludePostalCode ?? default(global::System.Management.Automation.SwitchParameter); set => _resourceBody.IncludePostalCode = value; }

        /// <summary>
        /// Whether to include S in the certificate subject name. Applicable only for private trust, private trust ci profile types
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Whether to include S in the certificate subject name. Applicable only for private trust, private trust ci profile types")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to include S in the certificate subject name. Applicable only for private trust, private trust ci profile types",
        SerializedName = @"includeState",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IncludeState { get => _resourceBody.IncludeState ?? default(global::System.Management.Automation.SwitchParameter); set => _resourceBody.IncludeState = value; }

        /// <summary>Whether to include STREET in the certificate subject name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Whether to include STREET in the certificate subject name.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to include STREET in the certificate subject name.",
        SerializedName = @"includeStreetAddress",
        PossibleTypes = new [] { typeof(global::System.Management.Automation.SwitchParameter) })]
        public global::System.Management.Automation.SwitchParameter IncludeStreetAddress { get => _resourceBody.IncludeStreetAddress ?? default(global::System.Management.Automation.SwitchParameter); set => _resourceBody.IncludeStreetAddress = value; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>Backing field for <see cref="ProfileName" /> property.</summary>
        private string _profileName;

        /// <summary>Certificate profile name.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "Certificate profile name.")]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Certificate profile name.",
        SerializedName = @"profileName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Path)]
        public string ProfileName { get => this._profileName; set => this._profileName = value; }

        /// <summary>Profile type of the certificate.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Profile type of the certificate.")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Body)]
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Profile type of the certificate.",
        SerializedName = @"profileType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PSArgumentCompleterAttribute("PublicTrust", "PrivateTrust", "PrivateTrustCIPolicy", "VBSEnclave", "PublicTrustTest")]
        public string ProfileType { get => _resourceBody.ProfileType ?? null; set => _resourceBody.ProfileType = value; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Category(global::Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile">Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>
        /// a duplicate instance of UpdateAzCodeSigningCertificateProfile_UpdateViaIdentityCodeSigningAccountExpanded
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Cmdlets.UpdateAzCodeSigningCertificateProfile_UpdateViaIdentityCodeSigningAccountExpanded Clone()
        {
            var clone = new UpdateAzCodeSigningCertificateProfile_UpdateViaIdentityCodeSigningAccountExpanded();
            clone.__correlationId = this.__correlationId;
            clone.__processRecordId = this.__processRecordId;
            clone.DefaultProfile = this.DefaultProfile;
            clone.InvocationInformation = this.InvocationInformation;
            clone.Proxy = this.Proxy;
            clone.Pipeline = this.Pipeline;
            clone.AsJob = this.AsJob;
            clone.Break = this.Break;
            clone.ProxyCredential = this.ProxyCredential;
            clone.ProxyUseDefaultCredentials = this.ProxyUseDefaultCredentials;
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            clone._resourceBody = this._resourceBody;
            clone.ProfileName = this.ProfileName;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            if (1 ==_responseSize)
            {
                // Flush buffer
                WriteObject(_firstResponse);
            }
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
            if (telemetryInfo != null)
            {
                telemetryInfo.TryGetValue("ShowSecretsWarning", out var showSecretsWarning);
                telemetryInfo.TryGetValue("SanitizedProperties", out var sanitizedProperties);
                telemetryInfo.TryGetValue("InvocationName", out var invocationName);
                if (showSecretsWarning == "true")
                {
                    if (string.IsNullOrEmpty(sanitizedProperties))
                    {
                        WriteWarning($"The output of cmdlet {invocationName} may compromise security by showing secrets. Learn more at https://go.microsoft.com/fwlink/?linkid=2258844");
                    }
                    else
                    {
                        WriteWarning($"The output of cmdlet {invocationName} may compromise security by showing the following secrets: {sanitizedProperties}. Learn more at https://go.microsoft.com/fwlink/?linkid=2258844");
                    }
                }
            }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.Progress:
                    {
                        var data = messageData();
                        int progress = (int)data.Value;
                        string activityMessage, statusDescription;
                        global::System.Management.Automation.ProgressRecordType recordType;
                        if (progress < 100)
                        {
                            activityMessage = "In progress";
                            statusDescription = "Checking operation status";
                            recordType = System.Management.Automation.ProgressRecordType.Processing;
                        }
                        else
                        {
                            activityMessage = "Completed";
                            statusDescription = "Completed";
                            recordType = System.Management.Automation.ProgressRecordType.Completed;
                        }
                        WriteProgress(new global::System.Management.Automation.ProgressRecord(1, activityMessage, statusDescription)
                        {
                            PercentComplete = progress,
                        RecordType = recordType
                        });
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.DelayBeforePolling:
                    {
                        var data = messageData();
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
                                // do nothing more.
                                data.Cancel();
                                return;
                            }
                        }
                        else
                        {
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                int delay = (int)(response.Headers.RetryAfter?.Delta?.TotalSeconds ?? 30);
                                WriteDebug($"Delaying {delay} seconds before polling.");
                                for (var now = 0; now < delay; ++now)
                                {
                                    WriteProgress(new global::System.Management.Automation.ProgressRecord(1, "In progress", "Checking operation status")
                                    {
                                        PercentComplete = now * 100 / delay
                                    });
                                    await global::System.Threading.Tasks.Task.Delay(1000, token);
                                }
                            }
                        }
                        break;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.Signal(id, token, messageData, (i, t, m) => ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(i, t, () => Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.EventDataConverter.ConvertFrom(m()) as Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.EventData), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'CertificateProfilesCreate' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName, this.ExtensibleParameters);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    if (CodeSigningAccountInputObject?.Id != null)
                    {
                        this.CodeSigningAccountInputObject.Id += $"/certificateProfiles/{(global::System.Uri.EscapeDataString(this.ProfileName.ToString()))}";
                        _resourceBody = await this.Client.CertificateProfilesGetViaIdentityWithResult(CodeSigningAccountInputObject.Id, this, Pipeline);
                        this.Update_resourceBody();
                        await this.Client.CertificateProfilesCreateViaIdentity(CodeSigningAccountInputObject.Id, _resourceBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeUpdate);
                    }
                    else
                    {
                        // try to call with PATH parameters from Input Object
                        if (null == CodeSigningAccountInputObject.SubscriptionId)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("CodeSigningAccountInputObject has null value for CodeSigningAccountInputObject.SubscriptionId"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, CodeSigningAccountInputObject) );
                        }
                        if (null == CodeSigningAccountInputObject.ResourceGroupName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("CodeSigningAccountInputObject has null value for CodeSigningAccountInputObject.ResourceGroupName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, CodeSigningAccountInputObject) );
                        }
                        if (null == CodeSigningAccountInputObject.AccountName)
                        {
                            ThrowTerminatingError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception("CodeSigningAccountInputObject has null value for CodeSigningAccountInputObject.AccountName"),string.Empty, global::System.Management.Automation.ErrorCategory.InvalidArgument, CodeSigningAccountInputObject) );
                        }
                        _resourceBody = await this.Client.CertificateProfilesGetWithResult(CodeSigningAccountInputObject.SubscriptionId ?? null, CodeSigningAccountInputObject.ResourceGroupName ?? null, CodeSigningAccountInputObject.AccountName ?? null, ProfileName, this, Pipeline);
                        this.Update_resourceBody();
                        await this.Client.CertificateProfilesCreate(CodeSigningAccountInputObject.SubscriptionId ?? null, CodeSigningAccountInputObject.ResourceGroupName ?? null, CodeSigningAccountInputObject.AccountName ?? null, ProfileName, _resourceBody, onOk, onDefault, this, Pipeline, Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeCreate|Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.SerializationMode.IncludeUpdate);
                    }
                    await ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { ProfileName=ProfileName})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzCodeSigningCertificateProfile_UpdateViaIdentityCodeSigningAccountExpanded"
        /// /> cmdlet class.
        /// </summary>
        public UpdateAzCodeSigningCertificateProfile_UpdateViaIdentityCodeSigningAccountExpanded()
        {

        }

        private void Update_resourceBody()
        {
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("ProfileType")))
            {
                this.ProfileType = (string)(this.MyInvocation?.BoundParameters["ProfileType"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("IncludeStreetAddress")))
            {
                this.IncludeStreetAddress = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["IncludeStreetAddress"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("IncludeCity")))
            {
                this.IncludeCity = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["IncludeCity"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("IncludeState")))
            {
                this.IncludeState = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["IncludeState"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("IncludeCountry")))
            {
                this.IncludeCountry = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["IncludeCountry"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("IncludePostalCode")))
            {
                this.IncludePostalCode = (global::System.Management.Automation.SwitchParameter)(this.MyInvocation?.BoundParameters["IncludePostalCode"]);
            }
            if ((bool)(true == this.MyInvocation?.BoundParameters.ContainsKey("IdentityValidationId")))
            {
                this.IdentityValidationId = (string)(this.MyInvocation?.BoundParameters["IdentityValidationId"]);
            }
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IErrorResponse>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile">Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, response, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 / application/json
                // (await response) // should be Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICertificateProfile
                var result = (await response);
                if (null != result)
                {
                    if (0 == _responseSize)
                    {
                        _firstResponse = result;
                        _responseSize = 1;
                    }
                    else
                    {
                        if (1 ==_responseSize)
                        {
                            // Flush buffer
                            WriteObject(_firstResponse.AddMultipleTypeNameIntoPSObject());
                        }
                        WriteObject(result.AddMultipleTypeNameIntoPSObject());
                        _responseSize = 2;
                    }
                }
            }
        }
    }
}