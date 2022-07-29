public enum LoaderOptimization // TypeDefIndex: 1008
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x4B8350 Offset: 0x4B8350 VA: 0x4B8350
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x4B8360 Offset: 0x4B8360 VA: 0x4B8360
	public const LoaderOptimization DisallowBindings = 4;
}
