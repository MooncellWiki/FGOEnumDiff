public enum SecurityAction // TypeDefIndex: 978
{
	// Fields
	public int value__; // 0x0
	public const SecurityAction Demand = 2;
	public const SecurityAction Assert = 3;
	[ObsoleteAttribute] // RVA: 0x67B82C Offset: 0x67B82C VA: 0x67B82C
	public const SecurityAction Deny = 4;
	public const SecurityAction PermitOnly = 5;
	public const SecurityAction LinkDemand = 6;
	public const SecurityAction InheritanceDemand = 7;
	[ObsoleteAttribute] // RVA: 0x67B860 Offset: 0x67B860 VA: 0x67B860
	public const SecurityAction RequestMinimum = 8;
	[ObsoleteAttribute] // RVA: 0x67B894 Offset: 0x67B894 VA: 0x67B894
	public const SecurityAction RequestOptional = 9;
	[ObsoleteAttribute] // RVA: 0x67B8C8 Offset: 0x67B8C8 VA: 0x67B8C8
	public const SecurityAction RequestRefuse = 10;
}
