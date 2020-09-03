// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IManagedDeviceRequestBuilder.
    /// </summary>
    public partial interface IManagedDeviceRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IManagedDeviceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IManagedDeviceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for DeviceCompliancePolicyStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeviceCompliancePolicyStatesCollectionRequestBuilder"/>.</returns>
        IManagedDeviceDeviceCompliancePolicyStatesCollectionRequestBuilder DeviceCompliancePolicyStates { get; }

        /// <summary>
        /// Gets the request builder for DeviceConfigurationStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder"/>.</returns>
        IManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder DeviceConfigurationStates { get; }

        /// <summary>
        /// Gets the request builder for DeviceCategory.
        /// </summary>
        /// <returns>The <see cref="IDeviceCategoryRequestBuilder"/>.</returns>
        IDeviceCategoryRequestBuilder DeviceCategory { get; }
    
        /// <summary>
        /// Gets the request builder for ManagedDeviceBypassActivationLock.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceBypassActivationLockRequestBuilder"/>.</returns>
        IManagedDeviceBypassActivationLockRequestBuilder BypassActivationLock();

        /// <summary>
        /// Gets the request builder for ManagedDeviceCleanWindowsDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceCleanWindowsDeviceRequestBuilder"/>.</returns>
        IManagedDeviceCleanWindowsDeviceRequestBuilder CleanWindowsDevice(
            bool keepUserData);

        /// <summary>
        /// Gets the request builder for ManagedDeviceDeleteUserFromSharedAppleDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeleteUserFromSharedAppleDeviceRequestBuilder"/>.</returns>
        IManagedDeviceDeleteUserFromSharedAppleDeviceRequestBuilder DeleteUserFromSharedAppleDevice(
            string userPrincipalName = null);

        /// <summary>
        /// Gets the request builder for ManagedDeviceDisableLostMode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDisableLostModeRequestBuilder"/>.</returns>
        IManagedDeviceDisableLostModeRequestBuilder DisableLostMode();

        /// <summary>
        /// Gets the request builder for ManagedDeviceLocateDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceLocateDeviceRequestBuilder"/>.</returns>
        IManagedDeviceLocateDeviceRequestBuilder LocateDevice();

        /// <summary>
        /// Gets the request builder for ManagedDeviceLogoutSharedAppleDeviceActiveUser.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceLogoutSharedAppleDeviceActiveUserRequestBuilder"/>.</returns>
        IManagedDeviceLogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRebootNow.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRebootNowRequestBuilder"/>.</returns>
        IManagedDeviceRebootNowRequestBuilder RebootNow();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRecoverPasscode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRecoverPasscodeRequestBuilder"/>.</returns>
        IManagedDeviceRecoverPasscodeRequestBuilder RecoverPasscode();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRemoteLock.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRemoteLockRequestBuilder"/>.</returns>
        IManagedDeviceRemoteLockRequestBuilder RemoteLock();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRequestRemoteAssistance.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRequestRemoteAssistanceRequestBuilder"/>.</returns>
        IManagedDeviceRequestRemoteAssistanceRequestBuilder RequestRemoteAssistance();

        /// <summary>
        /// Gets the request builder for ManagedDeviceResetPasscode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceResetPasscodeRequestBuilder"/>.</returns>
        IManagedDeviceResetPasscodeRequestBuilder ResetPasscode();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRetire.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRetireRequestBuilder"/>.</returns>
        IManagedDeviceRetireRequestBuilder Retire();

        /// <summary>
        /// Gets the request builder for ManagedDeviceShutDown.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceShutDownRequestBuilder"/>.</returns>
        IManagedDeviceShutDownRequestBuilder ShutDown();

        /// <summary>
        /// Gets the request builder for ManagedDeviceSyncDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceSyncDeviceRequestBuilder"/>.</returns>
        IManagedDeviceSyncDeviceRequestBuilder SyncDevice();

        /// <summary>
        /// Gets the request builder for ManagedDeviceUpdateWindowsDeviceAccount.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceUpdateWindowsDeviceAccountRequestBuilder"/>.</returns>
        IManagedDeviceUpdateWindowsDeviceAccountRequestBuilder UpdateWindowsDeviceAccount(
            UpdateWindowsDeviceAccountActionParameter updateWindowsDeviceAccountActionParameter = null);

        /// <summary>
        /// Gets the request builder for ManagedDeviceWindowsDefenderScan.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceWindowsDefenderScanRequestBuilder"/>.</returns>
        IManagedDeviceWindowsDefenderScanRequestBuilder WindowsDefenderScan(
            bool quickScan);

        /// <summary>
        /// Gets the request builder for ManagedDeviceWindowsDefenderUpdateSignatures.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceWindowsDefenderUpdateSignaturesRequestBuilder"/>.</returns>
        IManagedDeviceWindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures();

        /// <summary>
        /// Gets the request builder for ManagedDeviceWipe.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceWipeRequestBuilder"/>.</returns>
        IManagedDeviceWipeRequestBuilder Wipe(
            bool? keepEnrollmentData = null,
            bool? keepUserData = null,
            string macOsUnlockCode = null);
    
    }
}
