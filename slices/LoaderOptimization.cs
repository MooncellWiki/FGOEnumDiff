public enum LoaderOptimization // TypeDefIndex: 1007
{
	// Fields
	public int value__; // 0x0
	public const LoaderOptimization NotSpecified = 0;
	public const LoaderOptimization SingleDomain = 1;
	public const LoaderOptimization MultiDomain = 2;
	public const LoaderOptimization MultiDomainHost = 3;
	[ObsoleteAttribute] // RVA: 0x47FABC Offset: 0x47FABC VA: 0x47FABC
	public const LoaderOptimization DomainMask = 3;
	[ObsoleteAttribute] // RVA: 0x47FACC Offset: 0x47FACC VA: 0x47FACC
	public const LoaderOptimization DisallowBindings = 4;
}
