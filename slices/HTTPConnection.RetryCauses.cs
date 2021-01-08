private enum HTTPConnection.RetryCauses // TypeDefIndex: 4082
{
	// Fields
	public int value__; // 0x0
	public const HTTPConnection.RetryCauses None = 0;
	public const HTTPConnection.RetryCauses Reconnect = 1;
	public const HTTPConnection.RetryCauses Authenticate = 2;
	public const HTTPConnection.RetryCauses ProxyAuthenticate = 3;
}
