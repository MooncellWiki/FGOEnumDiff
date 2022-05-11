public enum LoaderOptimization // TypeDefIndex: 1008
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x49E910 Offset: 0x49E910 VA: 0x49E910
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x49E920 Offset: 0x49E920 VA: 0x49E920
	public const LoaderOptimization DisallowBindings = 4;
}
