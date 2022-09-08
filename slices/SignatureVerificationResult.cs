public enum SignatureVerificationResult // TypeDefIndex: 4552
{
	// Fields
	public int value__; // 0x0
	public const SignatureVerificationResult AssemblyIdentityMismatch = 1;
	public const SignatureVerificationResult BadDigest = -2146869232;
	public const SignatureVerificationResult BadSignatureFormat = -2146762749;
	public const SignatureVerificationResult BasicConstraintsNotObserved = -2146869223;
	public const SignatureVerificationResult CertificateExpired = -2146762495;
	public const SignatureVerificationResult CertificateExplicitlyDistrusted = -2146762479;
	public const SignatureVerificationResult CertificateMalformed = -2146762488;
	public const SignatureVerificationResult CertificateNotExplicitlyTrusted = -2146762748;
	public const SignatureVerificationResult CertificateRevoked = -2146762484;
	public const SignatureVerificationResult CertificateUsageNotAllowed = -2146762490;
	public const SignatureVerificationResult ContainingSignatureInvalid = 2;
	public const SignatureVerificationResult CouldNotBuildChain = -2146762486;
	public const SignatureVerificationResult GenericTrustFailure = -2146762485;
	public const SignatureVerificationResult InvalidCertificateName = -2146762476;
	public const SignatureVerificationResult InvalidCertificatePolicy = -2146762477;
	public const SignatureVerificationResult InvalidCertificateRole = -2146762493;
	public const SignatureVerificationResult InvalidCertificateSignature = -2146869244;
	public const SignatureVerificationResult InvalidCertificateUsage = -2146762480;
	public const SignatureVerificationResult InvalidCountersignature = -2146869245;
	public const SignatureVerificationResult InvalidSignerCertificate = -2146869246;
	public const SignatureVerificationResult InvalidTimePeriodNesting = -2146762494;
	public const SignatureVerificationResult InvalidTimestamp = -2146869243;
	public const SignatureVerificationResult IssuerChainingError = -2146762489;
	public const SignatureVerificationResult MissingSignature = -2146762496;
	public const SignatureVerificationResult PathLengthConstraintViolated = -2146762492;
	public const SignatureVerificationResult PublicKeyTokenMismatch = 3;
	public const SignatureVerificationResult PublisherMismatch = 4;
	public const SignatureVerificationResult RevocationCheckFailure = -2146762482;
	public const SignatureVerificationResult SystemError = -2146869247;
	public const SignatureVerificationResult UnknownCriticalExtension = -2146762491;
	public const SignatureVerificationResult UnknownTrustProvider = -2146762751;
	public const SignatureVerificationResult UnknownVerificationAction = -2146762750;
	public const SignatureVerificationResult UntrustedCertificationAuthority = -2146762478;
	public const SignatureVerificationResult UntrustedRootCertificate = -2146762487;
	public const SignatureVerificationResult UntrustedTestRootCertificate = -2146762483;
	public const SignatureVerificationResult Valid = 0;
}
