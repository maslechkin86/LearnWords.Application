using System.Text;
using System.Security.Cryptography;

namespace LearnWords.Domain {

	public static class HashHelper {

		public static byte[] GetHash(string inputString) {
			HashAlgorithm algorithm = MD5.Create();
			return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
		}

		public static string GetHashString(string inputString) {
			var sb = new StringBuilder();
			foreach (var b in GetHash(inputString)) {
				sb.Append(b.ToString("X2"));
			}
			return sb.ToString();
		}

	}
}
