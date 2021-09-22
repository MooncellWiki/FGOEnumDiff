public enum LoaderOptimization // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x467444 Offset: 0x467444 VA: 0x467444
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x467454 Offset: 0x467454 VA: 0x467454
	public const LoaderOptimization DisallowBindings = 4;
}
