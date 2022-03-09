internal enum HandshakeType // TypeDefIndex: 1927
{
	// Fields
	public byte value__; // 0x0
	public const HandshakeType HelloRequest = 0;
	public const HandshakeType ClientHello = 1;
	public const HandshakeType ServerHello = 2;
	public const HandshakeType Certificate = 11;
	public const HandshakeType ServerKeyExchange = 12;
	public const HandshakeType CertificateRequest = 13;
	public const HandshakeType ServerHelloDone = 14;
	public const HandshakeType CertificateVerify = 15;
	public const HandshakeType ClientKeyExchange = 16;
	public const HandshakeType Finished = 20;
	public const HandshakeType None = 255;
}
