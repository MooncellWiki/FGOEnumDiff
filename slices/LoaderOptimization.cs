public enum LoaderOptimization // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x3FD1BC Offset: 0x3FD1BC VA: 0x3FD1BC
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x3FD1CC Offset: 0x3FD1CC VA: 0x3FD1CC
	public const LoaderOptimization DisallowBindings = 4;
}
