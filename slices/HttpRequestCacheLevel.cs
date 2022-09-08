public enum HttpRequestCacheLevel // TypeDefIndex: 3738
{
	// Fields
	public int value__; // 0x0
	public const HttpRequestCacheLevel Default = 0;
	public const HttpRequestCacheLevel BypassCache = 1;
	public const HttpRequestCacheLevel CacheOnly = 2;
	public const HttpRequestCacheLevel CacheIfAvailable = 3;
	public const HttpRequestCacheLevel Revalidate = 4;
	public const HttpRequestCacheLevel Reload = 5;
	public const HttpRequestCacheLevel NoCacheNoStore = 6;
	public const HttpRequestCacheLevel CacheOrNextCacheOnly = 7;
	public const HttpRequestCacheLevel Refresh = 8;
}
