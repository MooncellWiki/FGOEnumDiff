public enum IsolatedStorageContainment // TypeDefIndex: 806
{
	// Fields
	public int value__; // 0x0
	public const IsolatedStorageContainment None = 0;
	public const IsolatedStorageContainment DomainIsolationByUser = 16;
	public const IsolatedStorageContainment AssemblyIsolationByUser = 32;
	public const IsolatedStorageContainment DomainIsolationByRoamingUser = 80;
	public const IsolatedStorageContainment AssemblyIsolationByRoamingUser = 96;
	public const IsolatedStorageContainment AdministerIsolatedStorageByUser = 112;
	public const IsolatedStorageContainment UnrestrictedIsolatedStorage = 240;
	public const IsolatedStorageContainment ApplicationIsolationByUser = 21;
	public const IsolatedStorageContainment DomainIsolationByMachine = 48;
	public const IsolatedStorageContainment AssemblyIsolationByMachine = 64;
	public const IsolatedStorageContainment ApplicationIsolationByMachine = 69;
	public const IsolatedStorageContainment ApplicationIsolationByRoamingUser = 101;
}
