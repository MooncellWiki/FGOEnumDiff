public enum SecurityAction // TypeDefIndex: 978
{
	// Fields
	public int value__; // 0x0
	public const SecurityAction Demand = 2;
	public const SecurityAction Assert = 3;
	[ObsoleteAttribute] // RVA: 0x67B80C Offset: 0x67B80C VA: 0x67B80C
	public const SecurityAction Deny = 4;
	public const SecurityAction PermitOnly = 5;
	public const SecurityAction LinkDemand = 6;
	public const SecurityAction InheritanceDemand = 7;
	[ObsoleteAttribute] // RVA: 0x67B840 Offset: 0x67B840 VA: 0x67B840
	public const SecurityAction RequestMinimum = 8;
	[ObsoleteAttribute] // RVA: 0x67B874 Offset: 0x67B874 VA: 0x67B874
	public const SecurityAction RequestOptional = 9;
	[ObsoleteAttribute] // RVA: 0x67B8A8 Offset: 0x67B8A8 VA: 0x67B8A8
	public const SecurityAction RequestRefuse = 10;
}
