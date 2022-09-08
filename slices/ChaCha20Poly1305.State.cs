private enum ChaCha20Poly1305.State // TypeDefIndex: 7932
{
	// Fields
	public int value__; // 0x0
	public const ChaCha20Poly1305.State Uninitialized = 0;
	public const ChaCha20Poly1305.State EncInit = 1;
	public const ChaCha20Poly1305.State EncAad = 2;
	public const ChaCha20Poly1305.State EncData = 3;
	public const ChaCha20Poly1305.State EncFinal = 4;
	public const ChaCha20Poly1305.State DecInit = 5;
	public const ChaCha20Poly1305.State DecAad = 6;
	public const ChaCha20Poly1305.State DecData = 7;
	public const ChaCha20Poly1305.State DecFinal = 8;
}
