public enum GenericUriParserOptions // TypeDefIndex: 2672
{
	// Fields
	public int value__; // 0x0
	public const GenericUriParserOptions Default = 0;
	public const GenericUriParserOptions GenericAuthority = 1;
	public const GenericUriParserOptions AllowEmptyAuthority = 2;
	public const GenericUriParserOptions NoUserInfo = 4;
	public const GenericUriParserOptions NoPort = 8;
	public const GenericUriParserOptions NoQuery = 16;
	public const GenericUriParserOptions NoFragment = 32;
	public const GenericUriParserOptions DontConvertPathBackslashes = 64;
	public const GenericUriParserOptions DontCompressPath = 128;
	public const GenericUriParserOptions DontUnescapePathDotsAndSlashes = 256;
	public const GenericUriParserOptions Idn = 512;
	public const GenericUriParserOptions IriParsing = 1024;
}
