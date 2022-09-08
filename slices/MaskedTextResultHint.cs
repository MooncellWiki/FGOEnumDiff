public enum MaskedTextResultHint // TypeDefIndex: 2912
{
	// Fields
	public int value__; // 0x0
	public const MaskedTextResultHint Unknown = 0;
	public const MaskedTextResultHint CharacterEscaped = 1;
	public const MaskedTextResultHint NoEffect = 2;
	public const MaskedTextResultHint SideEffect = 3;
	public const MaskedTextResultHint Success = 4;
	public const MaskedTextResultHint AsciiCharacterExpected = -1;
	public const MaskedTextResultHint AlphanumericCharacterExpected = -2;
	public const MaskedTextResultHint DigitExpected = -3;
	public const MaskedTextResultHint LetterExpected = -4;
	public const MaskedTextResultHint SignedDigitExpected = -5;
	public const MaskedTextResultHint InvalidInput = -51;
	public const MaskedTextResultHint PromptCharNotAllowed = -52;
	public const MaskedTextResultHint UnavailableEditPosition = -53;
	public const MaskedTextResultHint NonEditPosition = -54;
	public const MaskedTextResultHint PositionOutOfRange = -55;
}
