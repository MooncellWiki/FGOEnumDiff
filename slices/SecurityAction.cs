public enum SecurityAction // TypeDefIndex: 978
{
	// Fields
	public int value__; // 0x0
	public const SecurityAction Demand = 2;
	public const SecurityAction Assert = 3;
	[ObsoleteAttribute] // RVA: 0x3B72A4 Offset: 0x3B72A4 VA: 0x3B72A4
	public const SecurityAction Deny = 4;
	public const SecurityAction PermitOnly = 5;
	public const SecurityAction LinkDemand = 6;
	public const SecurityAction InheritanceDemand = 7;
	[ObsoleteAttribute] // RVA: 0x3B72D8 Offset: 0x3B72D8 VA: 0x3B72D8
	public const SecurityAction RequestMinimum = 8;
	[ObsoleteAttribute] // RVA: 0x3B730C Offset: 0x3B730C VA: 0x3B730C
	public const SecurityAction RequestOptional = 9;
	[ObsoleteAttribute] // RVA: 0x3B7340 Offset: 0x3B7340 VA: 0x3B7340
	public const SecurityAction RequestRefuse = 10;
}
