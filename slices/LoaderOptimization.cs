public enum LoaderOptimization // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x46EDFC Offset: 0x46EDFC VA: 0x46EDFC
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x46EE0C Offset: 0x46EE0C VA: 0x46EE0C
	public const LoaderOptimization DisallowBindings = 4;
}
