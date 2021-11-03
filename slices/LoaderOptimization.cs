public enum LoaderOptimization // TypeDefIndex: 1017
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x46FCCC Offset: 0x46FCCC VA: 0x46FCCC
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x46FCDC Offset: 0x46FCDC VA: 0x46FCDC
	public const LoaderOptimization DisallowBindings = 4;
}
