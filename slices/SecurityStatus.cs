internal enum SecurityStatus // TypeDefIndex: 3200
{
	// Fields
	public int value__; // 0x0
	public const SecurityStatus OK = 0;
	public const SecurityStatus ContinueNeeded = 590610;
	public const SecurityStatus CompleteNeeded = 590611;
	public const SecurityStatus CompAndContinue = 590612;
	public const SecurityStatus ContextExpired = 590615;
	public const SecurityStatus CredentialsNeeded = 590624;
	public const SecurityStatus Renegotiate = 590625;
	public const SecurityStatus OutOfMemory = -2146893056;
	public const SecurityStatus InvalidHandle = -2146893055;
	public const SecurityStatus Unsupported = -2146893054;
	public const SecurityStatus TargetUnknown = -2146893053;
	public const SecurityStatus InternalError = -2146893052;
	public const SecurityStatus PackageNotFound = -2146893051;
	public const SecurityStatus NotOwner = -2146893050;
	public const SecurityStatus CannotInstall = -2146893049;
	public const SecurityStatus InvalidToken = -2146893048;
	public const SecurityStatus CannotPack = -2146893047;
	public const SecurityStatus QopNotSupported = -2146893046;
	public const SecurityStatus NoImpersonation = -2146893045;
	public const SecurityStatus LogonDenied = -2146893044;
	public const SecurityStatus UnknownCredentials = -2146893043;
	public const SecurityStatus NoCredentials = -2146893042;
	public const SecurityStatus MessageAltered = -2146893041;
	public const SecurityStatus OutOfSequence = -2146893040;
	public const SecurityStatus NoAuthenticatingAuthority = -2146893039;
	public const SecurityStatus IncompleteMessage = -2146893032;
	public const SecurityStatus IncompleteCredentials = -2146893024;
	public const SecurityStatus BufferNotEnough = -2146893023;
	public const SecurityStatus WrongPrincipal = -2146893022;
	public const SecurityStatus TimeSkew = -2146893020;
	public const SecurityStatus UntrustedRoot = -2146893019;
	public const SecurityStatus IllegalMessage = -2146893018;
	public const SecurityStatus CertUnknown = -2146893017;
	public const SecurityStatus CertExpired = -2146893016;
	public const SecurityStatus AlgorithmMismatch = -2146893007;
	public const SecurityStatus SecurityQosFailed = -2146893006;
	public const SecurityStatus SmartcardLogonRequired = -2146892994;
	public const SecurityStatus UnsupportedPreauth = -2146892989;
	public const SecurityStatus BadBinding = -2146892986;
}
