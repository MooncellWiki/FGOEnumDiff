public enum KeyContainerPermissionFlags // TypeDefIndex: 805
{
	// Fields
	public int value__; // 0x0
	public const KeyContainerPermissionFlags NoFlags = 0;
	public const KeyContainerPermissionFlags Create = 1;
	public const KeyContainerPermissionFlags Open = 2;
	public const KeyContainerPermissionFlags Delete = 4;
	public const KeyContainerPermissionFlags Import = 16;
	public const KeyContainerPermissionFlags Export = 32;
	public const KeyContainerPermissionFlags Sign = 256;
	public const KeyContainerPermissionFlags Decrypt = 512;
	public const KeyContainerPermissionFlags ViewAcl = 4096;
	public const KeyContainerPermissionFlags ChangeAcl = 8192;
	public const KeyContainerPermissionFlags AllFlags = 13111;
}
