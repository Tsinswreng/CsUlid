using Tsinswreng.CsTools;
namespace Tsinswreng.CsUlid;

public static class IdTool {
	public static UInt128 NewUlidUInt128() {
		var bytes = Ulid.NewUlid().ToByteArray();
		return ToolUInt128.ByteArrToUInt128(bytes);
	}
}

