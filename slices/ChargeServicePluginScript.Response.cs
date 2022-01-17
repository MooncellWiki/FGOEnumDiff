public enum ChargeServicePluginScript.Response // TypeDefIndex: 3823
{
	// Fields
	public int value__; // 0x0
	public const ChargeServicePluginScript.Response INITIALIZE_TIMEOUT = -10000;
	public const ChargeServicePluginScript.Response BILLING_RESPONSE_RESULT_OK = 0;
	public const ChargeServicePluginScript.Response BILLING_RESPONSE_RESULT_USER_CANCELED = 1;
	public const ChargeServicePluginScript.Response BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE = 3;
	public const ChargeServicePluginScript.Response BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE = 4;
	public const ChargeServicePluginScript.Response BILLING_RESPONSE_RESULT_DEVELOPER_ERROR = 5;
	public const ChargeServicePluginScript.Response BILLING_RESPONSE_RESULT_ERROR = 6;
	public const ChargeServicePluginScript.Response BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED = 7;
	public const ChargeServicePluginScript.Response BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED = 8;
	public const ChargeServicePluginScript.Response IABHELPER_ERROR_BASE = -1000;
	public const ChargeServicePluginScript.Response IABHELPER_REMOTE_EXCEPTION = -1001;
	public const ChargeServicePluginScript.Response IABHELPER_BAD_RESPONSE = -1002;
	public const ChargeServicePluginScript.Response IABHELPER_VERIFICATION_FAILED = -1003;
	public const ChargeServicePluginScript.Response IABHELPER_SEND_INTENT_FAILED = -1004;
	public const ChargeServicePluginScript.Response IABHELPER_USER_CANCELLED = -1005;
	public const ChargeServicePluginScript.Response IABHELPER_UNKNOWN_PURCHASE_RESPONSE = -1006;
	public const ChargeServicePluginScript.Response IABHELPER_MISSING_TOKEN = -1007;
	public const ChargeServicePluginScript.Response IABHELPER_UNKNOWN_ERROR = -1008;
	public const ChargeServicePluginScript.Response IABHELPER_SUBSCRIPTIONS_NOT_AVAILABLE = -1009;
	public const ChargeServicePluginScript.Response IABHELPER_INVALID_CONSUMPTION = -1010;
}
