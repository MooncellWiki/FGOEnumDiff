public enum LoaderOptimization // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x47632C Offset: 0x47632C VA: 0x47632C
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x47633C Offset: 0x47633C VA: 0x47633C
	public const LoaderOptimization DisallowBindings = 4;
}
