public enum LoaderOptimization // TypeDefIndex: 1008
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x4A1818 Offset: 0x4A1818 VA: 0x4A1818
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x4A1828 Offset: 0x4A1828 VA: 0x4A1828
	public const LoaderOptimization DisallowBindings = 4;
}
