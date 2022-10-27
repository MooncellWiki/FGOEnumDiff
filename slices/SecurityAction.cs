public enum SecurityAction // TypeDefIndex: 978
{
	// Fields
	public int value__; // 0x0
	public const SecurityAction Demand = 2;
	public const SecurityAction Assert = 3;
	[ObsoleteAttribute] // RVA: 0xA74290 Offset: 0xA74290 VA: 0xA74290
	public const SecurityAction Deny = 4;
	public const SecurityAction PermitOnly = 5;
	public const SecurityAction LinkDemand = 6;
	public const SecurityAction InheritanceDemand = 7;
	[ObsoleteAttribute] // RVA: 0xA742C8 Offset: 0xA742C8 VA: 0xA742C8
	public const SecurityAction RequestMinimum = 8;
	[ObsoleteAttribute] // RVA: 0xA74300 Offset: 0xA74300 VA: 0xA74300
	public const SecurityAction RequestOptional = 9;
	[ObsoleteAttribute] // RVA: 0xA74338 Offset: 0xA74338 VA: 0xA74338
	public const SecurityAction RequestRefuse = 10;
}
