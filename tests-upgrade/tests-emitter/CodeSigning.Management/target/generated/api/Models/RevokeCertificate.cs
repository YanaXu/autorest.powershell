// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>Defines the certificate revocation properties.</summary>
    public partial class RevokeCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevokeCertificate,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.IRevokeCertificateInternal
    {

        /// <summary>Backing field for <see cref="EffectiveAt" /> property.</summary>
        private global::System.DateTime _effectiveAt;

        /// <summary>The timestamp when the revocation is effective.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public global::System.DateTime EffectiveAt { get => this._effectiveAt; set => this._effectiveAt = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>Reason for the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Backing field for <see cref="Remark" /> property.</summary>
        private string _remark;

        /// <summary>Remarks for the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Remark { get => this._remark; set => this._remark = value; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Serial number of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Backing field for <see cref="Thumbprint" /> property.</summary>
        private string _thumbprint;

        /// <summary>Thumbprint of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Thumbprint { get => this._thumbprint; set => this._thumbprint = value; }

        /// <summary>Creates an new <see cref="RevokeCertificate" /> instance.</summary>
        public RevokeCertificate()
        {

        }
    }
    /// Defines the certificate revocation properties.
    public partial interface IRevokeCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IJsonSerializable
    {
        /// <summary>The timestamp when the revocation is effective.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The timestamp when the revocation is effective.",
        SerializedName = @"effectiveAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime EffectiveAt { get; set; }
        /// <summary>Reason for the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Reason for the revocation.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(string) })]
        string Reason { get; set; }
        /// <summary>Remarks for the revocation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Remarks for the revocation.",
        SerializedName = @"remarks",
        PossibleTypes = new [] { typeof(string) })]
        string Remark { get; set; }
        /// <summary>Serial number of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Serial number of the certificate.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }
        /// <summary>Thumbprint of the certificate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Thumbprint of the certificate.",
        SerializedName = @"thumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string Thumbprint { get; set; }

    }
    /// Defines the certificate revocation properties.
    internal partial interface IRevokeCertificateInternal

    {
        /// <summary>The timestamp when the revocation is effective.</summary>
        global::System.DateTime EffectiveAt { get; set; }
        /// <summary>Reason for the revocation.</summary>
        string Reason { get; set; }
        /// <summary>Remarks for the revocation.</summary>
        string Remark { get; set; }
        /// <summary>Serial number of the certificate.</summary>
        string SerialNumber { get; set; }
        /// <summary>Thumbprint of the certificate.</summary>
        string Thumbprint { get; set; }

    }
}