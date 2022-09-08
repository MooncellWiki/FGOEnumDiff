internal enum IgnoreCertProblem // TypeDefIndex: 3207
{
	// Fields
	public int value__; // 0x0
	public const IgnoreCertProblem not_time_valid = 1;
	public const IgnoreCertProblem ctl_not_time_valid = 2;
	public const IgnoreCertProblem not_time_nested = 4;
	public const IgnoreCertProblem invalid_basic_constraints = 8;
	public const IgnoreCertProblem all_not_time_valid = 7;
	public const IgnoreCertProblem allow_unknown_ca = 16;
	public const IgnoreCertProblem wrong_usage = 32;
	public const IgnoreCertProblem invalid_name = 64;
	public const IgnoreCertProblem invalid_policy = 128;
	public const IgnoreCertProblem end_rev_unknown = 256;
	public const IgnoreCertProblem ctl_signer_rev_unknown = 512;
	public const IgnoreCertProblem ca_rev_unknown = 1024;
	public const IgnoreCertProblem root_rev_unknown = 2048;
	public const IgnoreCertProblem all_rev_unknown = 3840;
	public const IgnoreCertProblem none = 4095;
}
