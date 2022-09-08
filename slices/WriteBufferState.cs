internal enum WriteBufferState // TypeDefIndex: 3268
{
	// Fields
	public int value__; // 0x0
	public const WriteBufferState Disabled = 0;
	public const WriteBufferState Headers = 1;
	public const WriteBufferState Buffer = 2;
	public const WriteBufferState Playback = 3;
}
