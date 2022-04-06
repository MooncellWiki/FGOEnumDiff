public enum PurchaseFailureReason // TypeDefIndex: 2981
{
	// Fields
	public int value__; // 0x0
	public const PurchaseFailureReason PurchasingUnavailable = 0;
	public const PurchaseFailureReason ExistingPurchasePending = 1;
	public const PurchaseFailureReason ProductUnavailable = 2;
	public const PurchaseFailureReason SignatureInvalid = 3;
	public const PurchaseFailureReason UserCancelled = 4;
	public const PurchaseFailureReason PaymentDeclined = 5;
	public const PurchaseFailureReason DuplicateTransaction = 6;
	public const PurchaseFailureReason Unknown = 7;
}
