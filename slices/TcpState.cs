public enum TcpState // TypeDefIndex: 1444
{
	// Fields
	public int value__; // 0x0
	public const TcpState Unknown = 0;
	public const TcpState Closed = 1;
	public const TcpState Listen = 2;
	public const TcpState SynSent = 3;
	public const TcpState SynReceived = 4;
	public const TcpState Established = 5;
	public const TcpState FinWait1 = 6;
	public const TcpState FinWait2 = 7;
	public const TcpState CloseWait = 8;
	public const TcpState Closing = 9;
	public const TcpState LastAck = 10;
	public const TcpState TimeWait = 11;
	public const TcpState DeleteTcb = 12;
}
