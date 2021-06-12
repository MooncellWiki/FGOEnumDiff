public enum HTTPRequestStates // TypeDefIndex: 4096
{
	// Fields
	public int value__; // 0x0
	public const HTTPRequestStates Initial = 0;
	public const HTTPRequestStates Queued = 1;
	public const HTTPRequestStates Processing = 2;
	public const HTTPRequestStates Finished = 3;
	public const HTTPRequestStates Error = 4;
	public const HTTPRequestStates Aborted = 5;
	public const HTTPRequestStates ConnectionTimedOut = 6;
	public const HTTPRequestStates TimedOut = 7;
}
