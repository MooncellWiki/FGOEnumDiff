internal enum MethodFlags // TypeDefIndex: 641
{
	// Fields
	public int value__; // 0x0
	public const MethodFlags NoArguments = 1;
	public const MethodFlags PrimitiveArguments = 2;
	public const MethodFlags ArgumentsInSimpleArray = 4;
	public const MethodFlags ArgumentsInMultiArray = 8;
	public const MethodFlags ExcludeLogicalCallContext = 16;
	public const MethodFlags IncludesLogicalCallContext = 64;
	public const MethodFlags IncludesSignature = 128;
	public const MethodFlags FormatMask = 15;
	public const MethodFlags GenericArguments = 32768;
	public const MethodFlags NeedsInfoArrayMask = 32972;
}
