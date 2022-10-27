public enum SecurityAction // TypeDefIndex: 978
{
	// Fields
	public int value__; // 0x0
	public const SecurityAction Demand = 2;
	public const SecurityAction Assert = 3;
	[ObsoleteAttribute] // RVA: 0xA74270 Offset: 0xA74270 VA: 0xA74270
	public const SecurityAction Deny = 4;
	public const SecurityAction PermitOnly = 5;
	public const SecurityAction LinkDemand = 6;
	public const SecurityAction InheritanceDemand = 7;
	[ObsoleteAttribute] // RVA: 0xA742A8 Offset: 0xA742A8 VA: 0xA742A8
	public const SecurityAction RequestMinimum = 8;
	[ObsoleteAttribute] // RVA: 0xA742E0 Offset: 0xA742E0 VA: 0xA742E0
	public const SecurityAction RequestOptional = 9;
	[ObsoleteAttribute] // RVA: 0xA74318 Offset: 0xA74318 VA: 0xA74318
	public const SecurityAction RequestRefuse = 10;
}
