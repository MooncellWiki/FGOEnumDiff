public enum LoaderOptimization // TypeDefIndex: 1008
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x49C348 Offset: 0x49C348 VA: 0x49C348
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x49C358 Offset: 0x49C358 VA: 0x49C358
	public const LoaderOptimization DisallowBindings = 4;
}
