public enum LoaderOptimization // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x457D9C Offset: 0x457D9C VA: 0x457D9C
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x457DAC Offset: 0x457DAC VA: 0x457DAC
	public const LoaderOptimization DisallowBindings = 4;
}
