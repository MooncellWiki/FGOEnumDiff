public enum NetworkManager.ReadResult // TypeDefIndex: 6547
{
	// Fields
	public int value__; // 0x0
	public const NetworkManager.ReadResult OK = 0;
	public const NetworkManager.ReadResult NONE = 1;
	public const NetworkManager.ReadResult READ_ERROR = 2;
	public const NetworkManager.ReadResult CRYPT_ERROR = 3;
	public const NetworkManager.ReadResult JSON_ERROR = 4;
	public const NetworkManager.ReadResult VERSION_ERROR = 5;
	public const NetworkManager.ReadResult MD5_ERROR = 6;
}
