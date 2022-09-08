public enum MiniDumpType // TypeDefIndex: 6843
{
	// Fields
	public uint value__; // 0x0
	public const MiniDumpType None = 524286;
	public const MiniDumpType Normal = 0;
	public const MiniDumpType WithDataSegs = 1;
	public const MiniDumpType WithFullMemory = 2;
	public const MiniDumpType WithHandleData = 4;
	public const MiniDumpType FilterMemory = 8;
	public const MiniDumpType ScanMemory = 16;
	public const MiniDumpType WithUnloadedModules = 32;
	public const MiniDumpType WithIndirectlyReferencedMemory = 64;
	public const MiniDumpType FilterModulePaths = 128;
	public const MiniDumpType WithProcessThreadData = 256;
	public const MiniDumpType WithPrivateReadWriteMemory = 512;
	public const MiniDumpType WithoutOptionalData = 1024;
	public const MiniDumpType WithFullMemoryInfo = 2048;
	public const MiniDumpType WithThreadInfo = 4096;
	public const MiniDumpType WithCodeSegs = 8192;
	public const MiniDumpType WithoutAuxiliaryState = 16384;
	public const MiniDumpType WithFullAuxiliaryState = 32768;
	public const MiniDumpType WithPrivateWriteCopyMemory = 65536;
	public const MiniDumpType IgnoreInaccessibleMemory = 131072;
	public const MiniDumpType ValidTypeFlags = 262143;
}
