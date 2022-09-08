internal enum WebParseErrorCode // TypeDefIndex: 3270
{
	// Fields
	public int value__; // 0x0
	public const WebParseErrorCode Generic = 0;
	public const WebParseErrorCode InvalidHeaderName = 1;
	public const WebParseErrorCode InvalidContentLength = 2;
	public const WebParseErrorCode IncompleteHeaderLine = 3;
	public const WebParseErrorCode CrLfError = 4;
	public const WebParseErrorCode InvalidChunkFormat = 5;
	public const WebParseErrorCode UnexpectedServerResponse = 6;
}
