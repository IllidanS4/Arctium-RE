using System;

namespace AuthServer.AuthServer.Packets.BnetHandlers
{
	internal enum BnetErrorCode : uint
	{
		ErrorOk,
		ErrorInternal,
		ErrorTimedOut,
		ErrorDenied,
		ErrorNotExists,
		ErrorNotStarted,
		ErrorInProgress,
		ErrorInvalidArgs,
		ErrorInvalidSubscriber,
		ErrorWaitingForDependency,
		ErrorNoAuth,
		ErrorParentalControlRestriction,
		ErrorNoGameAccount,
		ErrorNotImplemented,
		ErrorObjectRemoved,
		ErrorInvalidEntityId,
		ErrorInvalidEntityAccountId,
		ErrorInvalidEntityGameAccountId,
		ErrorInvalidAgentId = 19u,
		ErrorInvalidTargetId,
		ErrorModuleNotLoaded,
		ErrorModuleNoEntryPoint,
		ErrorModuleSignatureIncorrect,
		ErrorModuleCreateFailed,
		ErrorNoProgram,
		ErrorApiNotReady = 27u,
		ErrorBadVersion,
		ErrorAttributeTooManyAttributesSet,
		ErrorAttributeMaxSizeExceeded,
		ErrorAttributeQuotaExceeded,
		ErrorServerPoolServerDisappeared,
		ErrorServerIsPrivate,
		ErrorDisabled,
		ErrorModuleNotFound = 36u,
		ErrorServerBusy,
		ErrorNoBattletag,
		ErrorIncompleteProfanityFilters,
		ErrorInvalidRegion,
		ErrorExistsAlready,
		ErrorInvalidServerThumbprint,
		ErrorPhoneLock,
		ErrorSquelched,
		ErrorTargetOffline,
		ErrorBadServer,
		ErrorNoCookie,
		ErrorExpiredCookie,
		ErrorTokenNotFound,
		ErrorGameAccountNoTime,
		ErrorGameAccountNoPlan,
		ErrorGameAccountBanned,
		ErrorGameAccountSuspended,
		ErrorGameAccountAlreadySelected,
		ErrorGameAccountCancelled,
		ErrorGameAccountCreationDisabled,
		ErrorGameAccountLocked,
		ErrorSessionDuplicate = 60u,
		ErrorSessionDisconnected,
		ErrorSessionDataChanged,
		ErrorSessionUpdateFailed,
		ErrorSessionNotFound,
		ErrorAdminKick = 70u,
		ErrorUnplannedMaintenance,
		ErrorPlannedMaintenance,
		ErrorServiceFailureAccount,
		ErrorServiceFailureSession,
		ErrorServiceFailureAuth,
		ErrorServiceFailureRisk,
		ErrorBadProgram,
		ErrorBadLocale,
		ErrorBadPlatform,
		ErrorLocaleRestrictedLa = 81u,
		ErrorLocaleRestrictedRu,
		ErrorLocaleRestrictedKo,
		ErrorLocaleRestrictedTw,
		ErrorLocaleRestricted,
		ErrorAccountNeedsMaintenance,
		ErrorModuleApiError,
		ErrorModuleBadCacheHandle,
		ErrorModuleAlreadyLoaded,
		ErrorNetworkBlacklisted,
		ErrorEventProcessorSlow,
		ErrorServerShuttingDown,
		ErrorNetworkNotPrivileged,
		ErrorTooManyOutstandingRequests,
		ErrorNoAccountRegistered,
		ErrorBattlenetAccountBanned,
		ErrorOkDeprecated = 100u,
		ErrorServerInModeZombie,
		ErrorLogonModuleRequired = 500u,
		ErrorLogonModuleNotConfigured,
		ErrorLogonModuleTimeout,
		ErrorLogonAgreementRequired = 510u,
		ErrorLogonAgreementNotConfigured,
		ErrorLogonInvalidServerProof = 520u,
		ErrorLogonWebVerifyTimeout,
		ErrorLogonInvalidAuthToken,
		ErrorChallengeSmsTooSoon = 600u,
		ErrorChallengeSmsThrottled,
		ErrorChallengeSmsTempOutage,
		ErrorChallengeNoChallenge,
		ErrorChallengeNotPicked,
		ErrorChallengeAlreadyPicked,
		ErrorChallengeInProgress,
		ErrorConfigFormatInvalid = 700u,
		ErrorConfigNotFound,
		ErrorConfigRetrieveFailed,
		ErrorNetworkModuleBusy = 1000u,
		ErrorNetworkModuleCantResolveAddress,
		ErrorNetworkModuleConnectionRefused,
		ErrorNetworkModuleInterrupted,
		ErrorNetworkModuleConnectionAborted,
		ErrorNetworkModuleConnectionReset,
		ErrorNetworkModuleBadAddress,
		ErrorNetworkModuleNotReady,
		ErrorNetworkModuleAlreadyConnected,
		ErrorNetworkModuleCantCreateSocket,
		ErrorNetworkModuleNetworkUnreachable,
		ErrorNetworkModuleSocketPermissionDenied,
		ErrorNetworkModuleNotInitialized,
		ErrorNetworkModuleNoSslCertificateForPeer,
		ErrorNetworkModuleNoSslCommonNameForCertificate,
		ErrorNetworkModuleSslCommonNameDoesNotMatchRemoteEndpoint,
		ErrorNetworkModuleSocketClosed,
		ErrorNetworkModuleSslPeerIsNotRegisteredInCertbundle,
		ErrorNetworkModuleSslInitializeLowFirst,
		ErrorNetworkModuleSslCertBundleReadError,
		ErrorNetworkModuleNoCertBundle,
		ErrorNetworkModuleFailedToDownloadCertBundle,
		ErrorNetworkModuleNotReadyToRead,
		ErrorNetworkModuleOpensslX509Ok = 1200u,
		ErrorNetworkModuleOpensslX509UnableToGetIssuerCert,
		ErrorNetworkModuleOpensslX509UnableToGetCrl,
		ErrorNetworkModuleOpensslX509UnableToDecryptCertSignature,
		ErrorNetworkModuleOpensslX509UnableToDecryptCrlSignature,
		ErrorNetworkModuleOpensslX509UnableToDecodeIssuerPublicKey,
		ErrorNetworkModuleOpensslX509CertSignatureFailure,
		ErrorNetworkModuleOpensslX509CrlSignatureFailure,
		ErrorNetworkModuleOpensslX509CertNotYetValid,
		ErrorNetworkModuleOpensslX509CertHasExpired,
		ErrorNetworkModuleOpensslX509CrlNotYetValid,
		ErrorNetworkModuleOpensslX509CrlHasExpired,
		ErrorNetworkModuleOpensslX509ErrorInCertNotBeforeField,
		ErrorNetworkModuleOpensslX509ErrorInCertNotAfterField,
		ErrorNetworkModuleOpensslX509ErrorInCrlLastUpdateField,
		ErrorNetworkModuleOpensslX509ErrorInCrlNextUpdateField,
		ErrorNetworkModuleOpensslX509OutOfMem,
		ErrorNetworkModuleOpensslX509DepthZeroSelfSignedCert,
		ErrorNetworkModuleOpensslX509SelfSignedCertInChain,
		ErrorNetworkModuleOpensslX509UnableToGetIssuerCertLocally,
		ErrorNetworkModuleOpensslX509UnableToVerifyLeafSignature,
		ErrorNetworkModuleOpensslX509CertChainTooLong,
		ErrorNetworkModuleOpensslX509CertRevoked,
		ErrorNetworkModuleOpensslX509InvalidCa,
		ErrorNetworkModuleOpensslX509PathLengthExceeded,
		ErrorNetworkModuleOpensslX509InvalidPurpose,
		ErrorNetworkModuleOpensslX509CertUntrusted,
		ErrorNetworkModuleOpensslX509CertRejected,
		ErrorNetworkModuleOpensslX509SubjectIssuerMismatch,
		ErrorNetworkModuleOpensslX509AkidSkidMismatch,
		ErrorNetworkModuleOpensslX509AkidIssuerSerialMismatch,
		ErrorNetworkModuleOpensslX509KeyusageNoCertsign,
		ErrorNetworkModuleOpensslX509ApplicationVerification,
		ErrorNetworkModuleSchannelCannotFindOsVersion = 1300u,
		ErrorNetworkModuleSchannelOsNotSupported,
		ErrorNetworkModuleSchannelLoadlibraryFail,
		ErrorNetworkModuleSchannelCannotFindInterface,
		ErrorNetworkModuleSchannelInitFail,
		ErrorNetworkModuleSchannelFunctionCallFail,
		ErrorNetworkModuleSchannelX509UnableToGetIssuerCert = 1350u,
		ErrorNetworkModuleSchannelX509TimeInvalid,
		ErrorNetworkModuleSchannelX509SignatureInvalid,
		ErrorNetworkModuleSchannelX509UnableToVerifyLeafSignature,
		ErrorNetworkModuleSchannelX509SelfSignedLeafCertificate,
		ErrorNetworkModuleSchannelX509UnhandledError,
		ErrorNetworkModuleSchannelX509SelfSignedCertInChain,
		ErrorWebsocketHandshake = 1400u,
		ErrorNetworkModuleDurangoUnknown = 1500u,
		ErrorNetworkModuleDurangoMalformedHostName,
		ErrorNetworkModuleDurangoInvalidConnectionResponse,
		ErrorNetworkModuleDurangoInvalidCaCert,
		ErrorRpcWriteFailed = 3000u,
		ErrorRpcServiceNotBound,
		ErrorRpcTooManyRequests,
		ErrorRpcPeerUnknown,
		ErrorRpcPeerUnavailable,
		ErrorRpcPeerDisconnected,
		ErrorRpcRequestTimedOut,
		ErrorRpcConnectionTimedOut,
		ErrorRpcMalformedResponse,
		ErrorRpcAccessDenied,
		ErrorRpcInvalidService,
		ErrorRpcInvalidMethod,
		ErrorRpcInvalidObject,
		ErrorRpcMalformedRequest,
		ErrorRpcQuotaExceeded,
		ErrorRpcNotImplemented,
		ErrorRpcServerError,
		ErrorRpcShutdown,
		ErrorRpcDisconnect,
		ErrorRpcDisconnectIdle,
		ErrorRpcProtocolError,
		ErrorRpcNotReady,
		ErrorRpcForwardFailed,
		ErrorRpcEncryptionFailed,
		ErrorRpcInvalidAddress,
		ErrorRpcMethodDisabled,
		ErrorRpcShardNotFound,
		ErrorRpcInvalidConnectionId,
		ErrorRpcNotConnected,
		ErrorRpcInvalidConnectionState,
		ErrorRpcServiceAlreadyRegistered,
		ErrorPresenceInvalidFieldId = 4000u,
		ErrorPresenceNoValidSubscribers,
		ErrorPresenceAlreadySubscribed,
		ErrorPresenceConsumerNotFound,
		ErrorPresenceConsumerIsNull,
		ErrorPresenceTemporaryOutage,
		ErrorPresenceTooManySubscriptions,
		ErrorPresenceSubscriptionCancelled,
		ErrorPresenceRichPresenceParseError,
		ErrorPresenceRichPresenceXmlError,
		ErrorPresenceRichPresenceLoadError,
		ErrorFriendsTooManySentInvitations = 5001u,
		ErrorFriendsTooManyReceivedInvitations,
		ErrorFriendsFriendshipAlreadyExists,
		ErrorFriendsFriendshipDoesNotExist,
		ErrorFriendsInvitationAlreadyExists,
		ErrorFriendsInvalidInvitation,
		ErrorFriendsAlreadySubscribed,
		ErrorFriendsAccountBlocked = 5009u,
		ErrorFriendsNotSubscribed,
		ErrorFriendsInvalidRoleId,
		ErrorFriendsDisabledRoleId,
		ErrorFriendsNoteMaxSizeExceeded,
		ErrorFriendsUpdateFriendStateFailed,
		ErrorFriendsInviteeAtMaxFriends,
		ErrorFriendsInviterAtMaxFriends,
		ErrorPlatformStorageFileWriteDenied = 6000u,
		ErrorWhisperUndeliverable = 7000u,
		ErrorWhisperMaxSizeExceeded,
		ErrorUserManagerAlreadyBlocked = 8000u,
		ErrorUserManagerNotBlocked,
		ErrorUserManagerCannotBlockSelf,
		ErrorUserManagerAlreadyRegistered,
		ErrorUserManagerNotRegistered,
		ErrorUserManagerTooManyBlockedEntities,
		ErrorUserManagerTooManyIds = 8007u,
		ErrorUserManagerBlockRecordUnavailable = 8015u,
		ErrorUserManagerBlockEntityFailed,
		ErrorUserManagerUnblockEntityFailed,
		ErrorUserManagerCannotBlockFriend = 8019u,
		ErrorSocialNetworkDbException = 9000u,
		ErrorSocialNetworkDenialFromProvider,
		ErrorSocialNetworkInvalidSnsId,
		ErrorSocialNetworkCantSendToProvider,
		ErrorSocialNetworkExCommFailed,
		ErrorSocialNetworkDisabled,
		ErrorSocialNetworkMissingRequestParam,
		ErrorSocialNetworkUnsupportedOauthVersion,
		ErrorChannelFull = 10000u,
		ErrorChannelNoChannel,
		ErrorChannelNotMember,
		ErrorChannelAlreadyMember,
		ErrorChannelNoSuchMember,
		ErrorChannelInvalidChannelId = 10006u,
		ErrorChannelNoSuchInvitation = 10008u,
		ErrorChannelTooManyInvitations,
		ErrorChannelInvitationAlreadyExists,
		ErrorChannelInvalidChannelSize,
		ErrorChannelInvalidRoleId,
		ErrorChannelRoleNotAssignable,
		ErrorChannelInsufficientPrivileges,
		ErrorChannelInsufficientPrivacyLevel,
		ErrorChannelInvalidPrivacyLevel,
		ErrorChannelTooManyChannelsJoined,
		ErrorChannelInvitationAlreadySubscribed,
		ErrorChannelInvalidChannelDelegate,
		ErrorChannelSlotAlreadyReserved,
		ErrorChannelSlotNotReserved,
		ErrorChannelNoReservedSlotsAvailable,
		ErrorChannelInvalidRoleSet,
		ErrorChannelRequireFriendValidation,
		ErrorChannelMemberOffline,
		ErrorChannelReceivedTooManyInvitations,
		ErrorChannelInvitationInvalidGameAccountSelected,
		ErrorChannelUnreachable,
		ErrorChannelInvitationNotSubscribed,
		ErrorChannelInvalidMessageSize,
		ErrorChannelMaxMessageSizeExceeded,
		ErrorChannelConfigNotFound,
		ErrorChannelInvalidChannelType,
		ErrorLocalStorageFileOpenError = 11000u,
		ErrorLocalStorageFileCreateError,
		ErrorLocalStorageFileReadError,
		ErrorLocalStorageFileWriteError,
		ErrorLocalStorageFileDeleteError,
		ErrorLocalStorageFileCopyError,
		ErrorLocalStorageFileDecompressError,
		ErrorLocalStorageFileHashMismatch,
		ErrorLocalStorageFileUsageMismatch,
		ErrorLocalStorageDatabaseInitError,
		ErrorLocalStorageDatabaseNeedsRebuild,
		ErrorLocalStorageDatabaseInsertError,
		ErrorLocalStorageDatabaseLookupError,
		ErrorLocalStorageDatabaseUpdateError,
		ErrorLocalStorageDatabaseDeleteError,
		ErrorLocalStorageDatabaseShrinkError,
		ErrorLocalStorageCacheCrawlError,
		ErrorLocalStorageDatabaseIndexTriggerError,
		ErrorLocalStorageDatabaseRebuildInProgress,
		ErrorLocalStorageOkButNotInCache,
		ErrorLocalStorageDatabaseRebuildInterrupted = 11021u,
		ErrorLocalStorageDatabaseNotInitialized,
		ErrorLocalStorageDirectoryCreateError,
		ErrorLocalStorageFilekeyNotFound,
		ErrorLocalStorageNotAvailableOnServer,
		ErrorRegistryCreateKeyError = 12000u,
		ErrorRegistryOpenKeyError,
		ErrorRegistryReadError,
		ErrorRegistryWriteError,
		ErrorRegistryTypeError,
		ErrorRegistryDeleteError,
		ErrorRegistryEncryptError,
		ErrorRegistryDecryptError,
		ErrorRegistryKeySizeError,
		ErrorRegistryValueSizeError,
		ErrorRegistryNotFound = 12011u,
		ErrorRegistryMalformedString,
		ErrorInterfaceAlreadyConnected = 13000u,
		ErrorInterfaceNotReady,
		ErrorInterfaceOptionKeyTooLarge,
		ErrorInterfaceOptionValueTooLarge,
		ErrorInterfaceOptionKeyInvalidUtf8String,
		ErrorInterfaceOptionValueInvalidUtf8String,
		ErrorHttpCouldntResolve = 14000u,
		ErrorHttpCouldntConnect,
		ErrorHttpTimeout,
		ErrorHttpFailed,
		ErrorHttpMalformedUrl,
		ErrorHttpDownloadAborted,
		ErrorHttpCouldntWriteFile,
		ErrorHttpTooManyRedirects,
		ErrorHttpCouldntOpenFile,
		ErrorHttpCouldntCreateFile,
		ErrorHttpCouldntReadFile,
		ErrorHttpCouldntRenameFile,
		ErrorHttpCouldntCreateDirectory,
		ErrorHttpCurlIsNotReady,
		ErrorHttpCancelled,
		ErrorHttpFileNotFound = 14404u,
		ErrorAccountMissingConfig = 18000u,
		ErrorAccountDataNotFound,
		ErrorAccountAlreadySubscribed,
		ErrorAccountNotSubscribed,
		ErrorAccountFailedToParseTimezoneData,
		ErrorAccountLoadFailed,
		ErrorAccountLoadCancelled,
		ErrorAccountDatabaseInvalidateFailed,
		ErrorAccountCacheInvalidateFailed,
		ErrorAccountSubscriptionPending,
		ErrorAccountUnknownRegion,
		ErrorAccountDataFailedToParse,
		ErrorAccountUnderage,
		ErrorAccountIdentityCheckPending,
		ErrorAccountIdentityUnverified,
		ErrorDatabaseBindingCountMismatch = 19000u,
		ErrorDatabaseBindingParseFail,
		ErrorDatabaseResultsetColumnsMismatch,
		ErrorDatabaseDeadlock,
		ErrorDatabaseDuplicateKey,
		ErrorDatabaseCannotConnect,
		ErrorDatabaseStatementFailed,
		ErrorDatabaseTransactionNotStarted,
		ErrorDatabaseTransactionNotEnded,
		ErrorDatabaseTransactionLeak,
		ErrorDatabaseTransactionStateBad,
		ErrorDatabaseServerGone,
		ErrorDatabaseQueryTimeout,
		ErrorDatabaseBindingNotNullable = 19100u,
		ErrorDatabaseBindingInvalidInteger,
		ErrorDatabaseBindingInvalidFloat,
		ErrorDatabaseBindingInvalidTemporal,
		ErrorDatabaseBindingInvalidProtobuf,
		ErrorPartyInvalidPartyId = 20000u,
		ErrorPartyAlreadyInParty,
		ErrorPartyNotInParty,
		ErrorPartyInvitationUndeliverable,
		ErrorPartyInvitationAlreadyExists,
		ErrorPartyTooManyPartyInvitations,
		ErrorPartyTooManyReceivedInvitations,
		ErrorPartyNoSuchType,
		ErrorGamesNoSuchFactory = 22000u,
		ErrorGamesNoSuchGame,
		ErrorGamesNoSuchRequest,
		ErrorGamesNoSuchPartyMember,
		ErrorResourcesOffline = 23000u,
		ErrorGameServerCreateGameRefused = 24000u,
		ErrorGameServerAddPlayersRefused,
		ErrorGameServerRemovePlayersRefused,
		ErrorGameServerFinishGameRefused,
		ErrorGameServerNoSuchGame,
		ErrorGameServerNoSuchPlayer,
		ErrorGameServerCreateGameRefusedTransient = 24050u,
		ErrorGameServerAddPlayersRefusedTransient,
		ErrorGameServerRemovePlayersRefusedTransient,
		ErrorGameServerFinishGameRefusedTransient,
		ErrorGameServerCreateGameRefusedBusy = 24100u,
		ErrorGameServerAddPlayersRefusedBusy,
		ErrorGameServerRemovePlayersRefusedBusy,
		ErrorGameServerFinishGameRefusedBusy,
		ErrorGameMasterInvalidFactory = 25000u,
		ErrorGameMasterInvalidGame,
		ErrorGameMasterGameFull,
		ErrorGameMasterRegisterFailed,
		ErrorGameMasterNoGameServer,
		ErrorGameMasterNoUtilityServer,
		ErrorGameMasterNoGameVersion,
		ErrorGameMasterGameJoinFailed,
		ErrorGameMasterAlreadyRegistered,
		ErrorGameMasterNoFactory,
		ErrorGameMasterMultipleGameVersions,
		ErrorGameMasterInvalidPlayer,
		ErrorGameMasterInvalidGameRequest,
		ErrorGameMasterInsufficientPrivileges,
		ErrorGameMasterAlreadyInGame,
		ErrorGameMasterInvalidGameServerResponse,
		ErrorGameMasterGameAccountLookupFailed,
		ErrorGameMasterGameEntryCancelled,
		ErrorGameMasterGameEntryAbortedClientDropped,
		ErrorGameMasterGameEntryAbortedByService,
		ErrorGameMasterNoAvailableCapacity,
		ErrorGameMasterInvalidTeamId,
		ErrorGameMasterCreationInProgress,
		ErrorNotificationInvalidClientId = 26000u,
		ErrorNotificationDuplicateName,
		ErrorNotificationNameNotFound,
		ErrorNotificationInvalidServer,
		ErrorNotificationQuotaExceeded,
		ErrorNotificationInvalidNotificationType,
		ErrorNotificationUndeliverable,
		ErrorNotificationUndeliverableTemporary,
		ErrorAchievementsNothingToUpdate = 28000u,
		ErrorAchievementsInvalidParams,
		ErrorAchievementsNotRegistered,
		ErrorAchievementsNotReady,
		ErrorAchievementsFailedToParseStaticData,
		ErrorAchievementsUnknownId,
		ErrorAchievementsMissingSnapshot,
		ErrorAchievementsAlreadyRegistered,
		ErrorAchievementsTooManyRegistrations,
		ErrorAchievementsAlreadyInProgress,
		ErrorAchievementsTemporaryOutage,
		ErrorAchievementsInvalidProgramid,
		ErrorAchievementsMissingRecord,
		ErrorAchievementsRegistrationPending,
		ErrorAchievementsEntityIdNotFound,
		ErrorAchievementsAchievementIdNotFound,
		ErrorAchievementsCriteriaIdNotFound,
		ErrorAchievementsStaticDataMismatch,
		ErrorAchievementsWrongThread,
		ErrorAchievementsCallbackIsNull,
		ErrorAchievementsAutoRegisterPending,
		ErrorAchievementsNotInitialized,
		ErrorAchievementsAchievementIdAlreadyExists,
		ErrorAchievementsFailedToDownloadStaticData,
		ErrorAchievementsStaticDataNotFound,
		ErrorGameUtilityServerVariableRequestRefused = 34001u,
		ErrorGameUtilityServerWrongNumberOfVariablesReturned,
		ErrorGameUtilityServerClientRequestRefused,
		ErrorGameUtilityServerPresenceChannelCreatedRefused,
		ErrorGameUtilityServerVariableRequestRefusedTransient = 34050u,
		ErrorGameUtilityServerClientRequestRefusedTransient,
		ErrorGameUtilityServerPresenceChannelCreatedRefusedTransient,
		ErrorGameUtilityServerServerRequestRefusedTransient,
		ErrorGameUtilityServerVariableRequestRefusedBusy = 34100u,
		ErrorGameUtilityServerClientRequestRefusedBusy,
		ErrorGameUtilityServerPresenceChannelCreatedRefusedBusy,
		ErrorGameUtilityServerServerRequestRefusedBusy,
		ErrorGameUtilityServerNoServer = 34200u,
		ErrorIdentityInsufficientData = 41000u,
		ErrorIdentityTooManyResults,
		ErrorIdentityBadId,
		ErrorIdentityNoAccountBlob,
		ErrorRiskChallengeAction = 42000u,
		ErrorRiskDelayAction,
		ErrorRiskThrottleAction,
		ErrorRiskAccountLocked,
		ErrorRiskCsDenied,
		ErrorRiskDisconnectAccount,
		ErrorRiskCheckSkipped,
		ErrorReportUnavailable = 45000u,
		ErrorReportTooLarge,
		ErrorReportUnknownType,
		ErrorReportAttributeInvalid,
		ErrorReportAttributeQuotaExceeded,
		ErrorReportUnconfirmed,
		ErrorReportNotConnected,
		ErrorReportRejected,
		ErrorReportTooManyRequests,
		ErrorAccountAlreadyRegisterd = 48000u,
		ErrorAccountNotRegistered,
		ErrorAccountRegistrationPending,
		ErrorMemcachedClientNoError = 65536u,
		ErrorMemcachedClientKeyNotFound,
		ErrorMemcachedKeyExists,
		ErrorMemcachedValueToLarge,
		ErrorMemcachedInvalidArgs,
		ErrorMemcachedItemNotStored,
		ErrorMemcachedNonNumericValue,
		ErrorMemcachedWrongServer,
		ErrorMemcachedAuthenticationError,
		ErrorMemcachedAuthenticationContinue,
		ErrorMemcachedUnknownCommand,
		ErrorMemcachedOutOfMemory,
		ErrorMemcachedNotSupported,
		ErrorMemcachedInternalError,
		ErrorMemcachedTemporaryFailure,
		ErrorMemcachedClientAlreadyConnected = 100000u,
		ErrorMemcachedClientBadConfig,
		ErrorMemcachedClientNotConnected,
		ErrorMemcachedClientTimeout,
		ErrorMemcachedClientAborted
	}
}
