public enum PurchaseBehaviour.Result // TypeDefIndex: 6570
{
	// Fields
	public int value__; // 0x0
	public const PurchaseBehaviour.Result NONE = 0;
	public const PurchaseBehaviour.Result BUSY = 1;
	public const PurchaseBehaviour.Result SUCCESS = 2;
	public const PurchaseBehaviour.Result SUCCESS_WITHOUT_NOTICE = 3;
	public const PurchaseBehaviour.Result WAIT = 4;
	public const PurchaseBehaviour.Result CANCEL = 5;
	public const PurchaseBehaviour.Result ERROR = 6;
	public const PurchaseBehaviour.Result SUSPEND = 7;
	public const PurchaseBehaviour.Result BLOCK = 8;
	public const PurchaseBehaviour.Result LIMIT_OVER = 9;
	public const PurchaseBehaviour.Result INIT_ERROR = 10;
	public const PurchaseBehaviour.Result PRODUCT_NOT_AVAILABLE = 11;
	public const PurchaseBehaviour.Result DUPLICATE_TRANSACTION = 12;
}
