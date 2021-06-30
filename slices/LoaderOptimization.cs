public enum LoaderOptimization // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x433EAC Offset: 0x433EAC VA: 0x433EAC
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x433EBC Offset: 0x433EBC VA: 0x433EBC
	public const LoaderOptimization DisallowBindings = 4;
}
