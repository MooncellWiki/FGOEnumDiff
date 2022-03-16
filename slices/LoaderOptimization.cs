public enum LoaderOptimization // TypeDefIndex: 1008
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x4908F0 Offset: 0x4908F0 VA: 0x4908F0
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x490900 Offset: 0x490900 VA: 0x490900
	public const LoaderOptimization DisallowBindings = 4;
}
