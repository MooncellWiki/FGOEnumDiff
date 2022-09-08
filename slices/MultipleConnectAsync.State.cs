private enum MultipleConnectAsync.State // TypeDefIndex: 3549
{
	// Fields
	public int value__; // 0x0
	public const MultipleConnectAsync.State NotStarted = 0;
	public const MultipleConnectAsync.State DnsQuery = 1;
	public const MultipleConnectAsync.State ConnectAttempt = 2;
	public const MultipleConnectAsync.State Completed = 3;
	public const MultipleConnectAsync.State Canceled = 4;
}
