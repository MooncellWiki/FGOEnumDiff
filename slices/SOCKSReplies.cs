internal enum SOCKSReplies // TypeDefIndex: 6992
{
	// Fields
	public byte value__; // 0x0
	public const SOCKSReplies Succeeded = 0;
	public const SOCKSReplies GeneralSOCKSServerFailure = 1;
	public const SOCKSReplies ConnectionNotAllowedByRuleset = 2;
	public const SOCKSReplies NetworkUnreachable = 3;
	public const SOCKSReplies HostUnreachable = 4;
	public const SOCKSReplies ConnectionRefused = 5;
	public const SOCKSReplies TTLExpired = 6;
	public const SOCKSReplies CommandNotSupported = 7;
	public const SOCKSReplies AddressTypeNotSupported = 8;
}
