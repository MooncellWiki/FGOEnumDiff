internal enum ReadState // TypeDefIndex: 1627
{
	// Fields
	public int value__; // 0x0
	public const ReadState None = 0;
	public const ReadState Status = 1;
	public const ReadState Headers = 2;
	public const ReadState Content = 3;
}
