public enum ConnectionStates // TypeDefIndex: 7003
{
	// Fields
	public int value__; // 0x0
	public const ConnectionStates Initial = 0;
	public const ConnectionStates Authenticating = 1;
	public const ConnectionStates Negotiating = 2;
	public const ConnectionStates Redirected = 3;
	public const ConnectionStates Reconnecting = 4;
	public const ConnectionStates Connected = 5;
	public const ConnectionStates CloseInitiated = 6;
	public const ConnectionStates Closed = 7;
}
