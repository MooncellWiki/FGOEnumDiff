private enum ChunkStream.State // TypeDefIndex: 1521
{
	// Fields
	public int value__; // 0x0
	public const ChunkStream.State None = 0;
	public const ChunkStream.State Body = 1;
	public const ChunkStream.State BodyFinished = 2;
	public const ChunkStream.State Trailer = 3;
}
