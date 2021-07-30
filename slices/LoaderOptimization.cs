public enum LoaderOptimization // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x45E77C Offset: 0x45E77C VA: 0x45E77C
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x45E78C Offset: 0x45E78C VA: 0x45E78C
	public const LoaderOptimization DisallowBindings = 4;
}
