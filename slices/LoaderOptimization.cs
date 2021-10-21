public enum LoaderOptimization // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x468894 Offset: 0x468894 VA: 0x468894
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x4688A4 Offset: 0x4688A4 VA: 0x4688A4
	public const LoaderOptimization DisallowBindings = 4;
}
