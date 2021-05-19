public enum LoaderOptimization // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x432E4C Offset: 0x432E4C VA: 0x432E4C
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x432E5C Offset: 0x432E5C VA: 0x432E5C
	public const LoaderOptimization DisallowBindings = 4;
}
