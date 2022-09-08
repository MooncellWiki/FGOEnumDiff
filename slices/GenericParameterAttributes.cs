public enum GenericParameterAttributes // TypeDefIndex: 544
{
	// Fields
	public int value__; // 0x0
	public const GenericParameterAttributes None = 0;
	public const GenericParameterAttributes VarianceMask = 3;
	public const GenericParameterAttributes Covariant = 1;
	public const GenericParameterAttributes Contravariant = 2;
	public const GenericParameterAttributes SpecialConstraintMask = 28;
	public const GenericParameterAttributes ReferenceTypeConstraint = 4;
	public const GenericParameterAttributes NotNullableValueTypeConstraint = 8;
	public const GenericParameterAttributes DefaultConstructorConstraint = 16;
}
