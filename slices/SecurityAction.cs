public enum SecurityAction // TypeDefIndex: 978
{
	// Fields
	public int value__; // 0x0
	public const SecurityAction Demand = 2;
	public const SecurityAction Assert = 3;
	[ObsoleteAttribute] // RVA: 0x3B4F8C Offset: 0x3B4F8C VA: 0x3B4F8C
	public const SecurityAction Deny = 4;
	public const SecurityAction PermitOnly = 5;
	public const SecurityAction LinkDemand = 6;
	public const SecurityAction InheritanceDemand = 7;
	[ObsoleteAttribute] // RVA: 0x3B4FC0 Offset: 0x3B4FC0 VA: 0x3B4FC0
	public const SecurityAction RequestMinimum = 8;
	[ObsoleteAttribute] // RVA: 0x3B4FF4 Offset: 0x3B4FF4 VA: 0x3B4FF4
	public const SecurityAction RequestOptional = 9;
	[ObsoleteAttribute] // RVA: 0x3B5028 Offset: 0x3B5028 VA: 0x3B5028
	public const SecurityAction RequestRefuse = 10;
}
