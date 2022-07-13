public enum LoaderOptimization // TypeDefIndex: 1008
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x4B1BC0 Offset: 0x4B1BC0 VA: 0x4B1BC0
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x4B1BD0 Offset: 0x4B1BD0 VA: 0x4B1BD0
	public const LoaderOptimization DisallowBindings = 4;
}
