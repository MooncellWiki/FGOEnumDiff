public enum PkiStatus // TypeDefIndex: 8770
{
	// Fields
	public int value__; // 0x0
	public const PkiStatus Granted = 0;
	public const PkiStatus GrantedWithMods = 1;
	public const PkiStatus Rejection = 2;
	public const PkiStatus Waiting = 3;
	public const PkiStatus RevocationWarning = 4;
	public const PkiStatus RevocationNotification = 5;
	public const PkiStatus KeyUpdateWarning = 6;
}
