private enum MacNetworkChange.NetworkReachabilityFlags // TypeDefIndex: 3674
{
	// Fields
	public int value__; // 0x0
	public const MacNetworkChange.NetworkReachabilityFlags None = 0;
	public const MacNetworkChange.NetworkReachabilityFlags TransientConnection = 1;
	public const MacNetworkChange.NetworkReachabilityFlags Reachable = 2;
	public const MacNetworkChange.NetworkReachabilityFlags ConnectionRequired = 4;
	public const MacNetworkChange.NetworkReachabilityFlags ConnectionOnTraffic = 8;
	public const MacNetworkChange.NetworkReachabilityFlags InterventionRequired = 16;
	public const MacNetworkChange.NetworkReachabilityFlags ConnectionOnDemand = 32;
	public const MacNetworkChange.NetworkReachabilityFlags IsLocalAddress = 65536;
	public const MacNetworkChange.NetworkReachabilityFlags IsDirect = 131072;
	public const MacNetworkChange.NetworkReachabilityFlags IsWWAN = 262144;
	public const MacNetworkChange.NetworkReachabilityFlags ConnectionAutomatic = 8;
}
