public enum HTTPConnectionStates // TypeDefIndex: 8948
{
	// Fields
	public int value__; // 0x0
	public const HTTPConnectionStates Initial = 0;
	public const HTTPConnectionStates Processing = 1;
	public const HTTPConnectionStates WaitForProtocolShutdown = 2;
	public const HTTPConnectionStates Recycle = 3;
	public const HTTPConnectionStates Free = 4;
	public const HTTPConnectionStates Closed = 5;
	public const HTTPConnectionStates ClosedResendRequest = 6;
}
