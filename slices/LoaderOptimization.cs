public enum LoaderOptimization // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x484F24 Offset: 0x484F24 VA: 0x484F24
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x484F34 Offset: 0x484F34 VA: 0x484F34
	public const LoaderOptimization DisallowBindings = 4;
}
