public enum IPStatus // TypeDefIndex: 1365
{
	// Fields
	public int value__; // 0x0
	public const IPStatus Unknown = -1;
	public const IPStatus Success = 0;
	public const IPStatus DestinationNetworkUnreachable = 11002;
	public const IPStatus DestinationHostUnreachable = 11003;
	public const IPStatus DestinationProhibited = 11004;
	public const IPStatus DestinationProtocolUnreachable = 11004;
	public const IPStatus DestinationPortUnreachable = 11005;
	public const IPStatus NoResources = 11006;
	public const IPStatus BadOption = 11007;
	public const IPStatus HardwareError = 11008;
	public const IPStatus PacketTooBig = 11009;
	public const IPStatus TimedOut = 11010;
	public const IPStatus BadRoute = 11012;
	public const IPStatus TtlExpired = 11013;
	public const IPStatus TtlReassemblyTimeExceeded = 11014;
	public const IPStatus ParameterProblem = 11015;
	public const IPStatus SourceQuench = 11016;
	public const IPStatus BadDestination = 11018;
	public const IPStatus DestinationUnreachable = 11040;
	public const IPStatus TimeExceeded = 11041;
	public const IPStatus BadHeader = 11042;
	public const IPStatus UnrecognizedNextHeader = 11043;
	public const IPStatus IcmpError = 11044;
	public const IPStatus DestinationScopeMismatch = 11045;
}
