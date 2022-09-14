public enum SecurityAction // TypeDefIndex: 978
{
	// Fields
	public int value__; // 0x0
	public const SecurityAction Demand = 2;
	public const SecurityAction Assert = 3;
	[ObsoleteAttribute] // RVA: 0x3B744C Offset: 0x3B744C VA: 0x3B744C
	public const SecurityAction Deny = 4;
	public const SecurityAction PermitOnly = 5;
	public const SecurityAction LinkDemand = 6;
	public const SecurityAction InheritanceDemand = 7;
	[ObsoleteAttribute] // RVA: 0x3B7480 Offset: 0x3B7480 VA: 0x3B7480
	public const SecurityAction RequestMinimum = 8;
	[ObsoleteAttribute] // RVA: 0x3B74B4 Offset: 0x3B74B4 VA: 0x3B74B4
	public const SecurityAction RequestOptional = 9;
	[ObsoleteAttribute] // RVA: 0x3B74E8 Offset: 0x3B74E8 VA: 0x3B74E8
	public const SecurityAction RequestRefuse = 10;
}
