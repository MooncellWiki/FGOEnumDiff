public enum ReportFilterType // TypeDefIndex: 3760
{
	// Fields
	public int value__; // 0x0
	[TooltipAttribute] // RVA: 0x4F79F8 Offset: 0x4F79F8 VA: 0x4F79F8
	public const ReportFilterType None = 0;
	[TooltipAttribute] // RVA: 0x4F7A40 Offset: 0x4F7A40 VA: 0x4F7A40
	public const ReportFilterType Message = 1;
	[TooltipAttribute] // RVA: 0x4F7A84 Offset: 0x4F7A84 VA: 0x4F7A84
	public const ReportFilterType Exception = 2;
	[TooltipAttribute] // RVA: 0x4F7AC4 Offset: 0x4F7AC4 VA: 0x4F7AC4
	public const ReportFilterType UnhandledException = 4;
	[TooltipAttribute] // RVA: 0x4F7B0C Offset: 0x4F7B0C VA: 0x4F7B0C
	public const ReportFilterType Hang = 8;
	[TooltipAttribute] // RVA: 0x4F7B44 Offset: 0x4F7B44 VA: 0x4F7B44
	public const ReportFilterType Error = 16;
}
