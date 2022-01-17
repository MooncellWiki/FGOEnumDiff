public enum LoaderOptimization // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x471C94 Offset: 0x471C94 VA: 0x471C94
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x471CA4 Offset: 0x471CA4 VA: 0x471CA4
	public const LoaderOptimization DisallowBindings = 4;
}
