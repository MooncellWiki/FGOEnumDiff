private enum SslClientStream.NegotiateState // TypeDefIndex: 1776
{
	// Fields
	public int value__; // 0x0
	public const SslClientStream.NegotiateState SentClientHello = 0;
	public const SslClientStream.NegotiateState ReceiveClientHelloResponse = 1;
	public const SslClientStream.NegotiateState SentCipherSpec = 2;
	public const SslClientStream.NegotiateState ReceiveCipherSpecResponse = 3;
	public const SslClientStream.NegotiateState SentKeyExchange = 4;
	public const SslClientStream.NegotiateState ReceiveFinishResponse = 5;
	public const SslClientStream.NegotiateState SentFinished = 6;
}
