public enum LoaderOptimization // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x47B5BC Offset: 0x47B5BC VA: 0x47B5BC
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x47B5CC Offset: 0x47B5CC VA: 0x47B5CC
	public const LoaderOptimization DisallowBindings = 4;
}
