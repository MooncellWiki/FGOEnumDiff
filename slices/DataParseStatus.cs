internal enum DataParseStatus // TypeDefIndex: 3267
{
	// Fields
	public int value__; // 0x0
	public const DataParseStatus NeedMoreData = 0;
	public const DataParseStatus ContinueParsing = 1;
	public const DataParseStatus Done = 2;
	public const DataParseStatus Invalid = 3;
	public const DataParseStatus DataTooBig = 4;
}
