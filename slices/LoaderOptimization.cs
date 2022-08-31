public enum LoaderOptimization // TypeDefIndex: 1008
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x4BCD88 Offset: 0x4BCD88 VA: 0x4BCD88
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x4BCD98 Offset: 0x4BCD98 VA: 0x4BCD98
	public const LoaderOptimization DisallowBindings = 4;
}
