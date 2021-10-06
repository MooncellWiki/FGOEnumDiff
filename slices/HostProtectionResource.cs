public enum HostProtectionResource // TypeDefIndex: 803
{
	// Fields
	public int value__; // 0x0
	public const HostProtectionResource None = 0;
	public const HostProtectionResource Synchronization = 1;
	public const HostProtectionResource SharedState = 2;
	public const HostProtectionResource ExternalProcessMgmt = 4;
	public const HostProtectionResource SelfAffectingProcessMgmt = 8;
	public const HostProtectionResource ExternalThreading = 16;
	public const HostProtectionResource SelfAffectingThreading = 32;
	public const HostProtectionResource SecurityInfrastructure = 64;
	public const HostProtectionResource UI = 128;
	public const HostProtectionResource MayLeakOnAbort = 256;
	public const HostProtectionResource All = 511;
}
