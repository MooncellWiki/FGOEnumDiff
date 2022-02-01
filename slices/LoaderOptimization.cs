public enum LoaderOptimization // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x47B464 Offset: 0x47B464 VA: 0x47B464
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x47B474 Offset: 0x47B474 VA: 0x47B474
	public const LoaderOptimization DisallowBindings = 4;
}
