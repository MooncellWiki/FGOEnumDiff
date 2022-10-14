public enum XmlSchemaDerivationMethod // TypeDefIndex: 2427
{
	// Fields
	public int value__; // 0x0
	[XmlEnumAttribute] // RVA: 0x3CD6B4 Offset: 0x3CD6B4 VA: 0x3CD6B4
	public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnumAttribute] // RVA: 0x3CD6E8 Offset: 0x3CD6E8 VA: 0x3CD6E8
	public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnumAttribute] // RVA: 0x3CD71C Offset: 0x3CD71C VA: 0x3CD71C
	public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnumAttribute] // RVA: 0x3CD750 Offset: 0x3CD750 VA: 0x3CD750
	public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnumAttribute] // RVA: 0x3CD784 Offset: 0x3CD784 VA: 0x3CD784
	public const XmlSchemaDerivationMethod List = 8;
	[XmlEnumAttribute] // RVA: 0x3CD7B8 Offset: 0x3CD7B8 VA: 0x3CD7B8
	public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnumAttribute] // RVA: 0x3CD7EC Offset: 0x3CD7EC VA: 0x3CD7EC
	public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnoreAttribute] // RVA: 0x3CD820 Offset: 0x3CD820 VA: 0x3CD820
	public const XmlSchemaDerivationMethod None = 256;
}
