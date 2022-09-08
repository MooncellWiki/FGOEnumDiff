internal enum ThreadKinds // TypeDefIndex: 3281
{
	// Fields
	public int value__; // 0x0
	public const ThreadKinds Unknown = 0;
	public const ThreadKinds User = 1;
	public const ThreadKinds System = 2;
	public const ThreadKinds Sync = 4;
	public const ThreadKinds Async = 8;
	public const ThreadKinds Timer = 16;
	public const ThreadKinds CompletionPort = 32;
	public const ThreadKinds Worker = 64;
	public const ThreadKinds Finalization = 128;
	public const ThreadKinds Other = 256;
	public const ThreadKinds OwnerMask = 3;
	public const ThreadKinds SyncMask = 12;
	public const ThreadKinds SourceMask = 496;
	public const ThreadKinds SafeSources = 352;
	public const ThreadKinds ThreadPool = 96;
}
