internal enum BufferType // TypeDefIndex: 3205
{
	// Fields
	public int value__; // 0x0
	public const BufferType Empty = 0;
	public const BufferType Data = 1;
	public const BufferType Token = 2;
	public const BufferType Parameters = 3;
	public const BufferType Missing = 4;
	public const BufferType Extra = 5;
	public const BufferType Trailer = 6;
	public const BufferType Header = 7;
	public const BufferType Padding = 9;
	public const BufferType Stream = 10;
	public const BufferType ChannelBindings = 14;
	public const BufferType TargetHost = 16;
	public const BufferType ReadOnlyFlag = -2147483648;
	public const BufferType ReadOnlyWithChecksum = 268435456;
}
