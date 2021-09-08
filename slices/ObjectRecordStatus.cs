internal enum ObjectRecordStatus // TypeDefIndex: 674
{
	// Fields
	public byte value__; // 0x0
	public const ObjectRecordStatus Unregistered = 0;
	public const ObjectRecordStatus ReferenceUnsolved = 1;
	public const ObjectRecordStatus ReferenceSolvingDelayed = 2;
	public const ObjectRecordStatus ReferenceSolved = 3;
}
