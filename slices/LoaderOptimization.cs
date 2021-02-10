public enum LoaderOptimization // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x429898 Offset: 0x429898 VA: 0x429898
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x4298A8 Offset: 0x4298A8 VA: 0x4298A8
	public const LoaderOptimization DisallowBindings = 4;
}
