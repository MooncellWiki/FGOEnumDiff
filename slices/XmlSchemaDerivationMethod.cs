public enum XmlSchemaDerivationMethod // TypeDefIndex: 2427
{
	// Fields
	public int value__; // 0x0
	[XmlEnumAttribute] // RVA: 0x3CD6A4 Offset: 0x3CD6A4 VA: 0x3CD6A4
	public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnumAttribute] // RVA: 0x3CD6D8 Offset: 0x3CD6D8 VA: 0x3CD6D8
	public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnumAttribute] // RVA: 0x3CD70C Offset: 0x3CD70C VA: 0x3CD70C
	public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnumAttribute] // RVA: 0x3CD740 Offset: 0x3CD740 VA: 0x3CD740
	public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnumAttribute] // RVA: 0x3CD774 Offset: 0x3CD774 VA: 0x3CD774
	public const XmlSchemaDerivationMethod List = 8;
	[XmlEnumAttribute] // RVA: 0x3CD7A8 Offset: 0x3CD7A8 VA: 0x3CD7A8
	public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnumAttribute] // RVA: 0x3CD7DC Offset: 0x3CD7DC VA: 0x3CD7DC
	public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnoreAttribute] // RVA: 0x3CD810 Offset: 0x3CD810 VA: 0x3CD810
	public const XmlSchemaDerivationMethod None = 256;
}
