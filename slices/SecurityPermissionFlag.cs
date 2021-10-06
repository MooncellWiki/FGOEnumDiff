public enum SecurityPermissionFlag // TypeDefIndex: 822
{
	// Fields
	public int value__; // 0x0
	public const SecurityPermissionFlag NoFlags = 0;
	public const SecurityPermissionFlag Assertion = 1;
	public const SecurityPermissionFlag UnmanagedCode = 2;
	public const SecurityPermissionFlag SkipVerification = 4;
	public const SecurityPermissionFlag Execution = 8;
	public const SecurityPermissionFlag ControlThread = 16;
	public const SecurityPermissionFlag ControlEvidence = 32;
	public const SecurityPermissionFlag ControlPolicy = 64;
	public const SecurityPermissionFlag SerializationFormatter = 128;
	public const SecurityPermissionFlag ControlDomainPolicy = 256;
	public const SecurityPermissionFlag ControlPrincipal = 512;
	public const SecurityPermissionFlag ControlAppDomain = 1024;
	public const SecurityPermissionFlag RemotingConfiguration = 2048;
	public const SecurityPermissionFlag Infrastructure = 4096;
	public const SecurityPermissionFlag BindingRedirects = 8192;
	public const SecurityPermissionFlag AllFlags = 16383;
}
