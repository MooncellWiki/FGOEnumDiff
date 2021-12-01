public enum LoaderOptimization // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x4767EC Offset: 0x4767EC VA: 0x4767EC
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x4767FC Offset: 0x4767FC VA: 0x4767FC
	public const LoaderOptimization DisallowBindings = 4;
}
