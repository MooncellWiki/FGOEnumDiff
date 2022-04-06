public enum LoaderOptimization // TypeDefIndex: 1008
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x492428 Offset: 0x492428 VA: 0x492428
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x492438 Offset: 0x492438 VA: 0x492438
	public const LoaderOptimization DisallowBindings = 4;
}
