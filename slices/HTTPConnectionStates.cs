internal enum HTTPConnectionStates // TypeDefIndex: 4443
{
	// Fields
	public int value__; // 0x0
	public const HTTPConnectionStates Initial = 0;
	public const HTTPConnectionStates Processing = 1;
	public const HTTPConnectionStates Redirected = 2;
	public const HTTPConnectionStates Upgraded = 3;
	public const HTTPConnectionStates WaitForProtocolShutdown = 4;
	public const HTTPConnectionStates WaitForRecycle = 5;
	public const HTTPConnectionStates Free = 6;
	public const HTTPConnectionStates AbortRequested = 7;
	public const HTTPConnectionStates TimedOut = 8;
	public const HTTPConnectionStates Closed = 9;
}
