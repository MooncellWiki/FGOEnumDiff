public enum MessageTypes // TypeDefIndex: 7048
{
	// Fields
	public int value__; // 0x0
	public const MessageTypes Handshake = 0;
	public const MessageTypes Invocation = 1;
	public const MessageTypes StreamItem = 2;
	public const MessageTypes Completion = 3;
	public const MessageTypes StreamInvocation = 4;
	public const MessageTypes CancelInvocation = 5;
	public const MessageTypes Ping = 6;
	public const MessageTypes Close = 7;
}
