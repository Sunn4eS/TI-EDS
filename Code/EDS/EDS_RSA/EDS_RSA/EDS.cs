using System.Numerics;

namespace EDS_RSA;

public class EDS
{
    static readonly long H0 = 100;

    public static long HashFunction(byte[] textBytes, long r)
    {
        if (textBytes == null || textBytes.Length == 0)
            return H0;
        
        long result = MathTools.FastExp(H0 + textBytes[0], 2, r);
        for (int i = 1; i < textBytes.Length; i++)
        {
            result = MathTools.FastExp(result + textBytes[i], 2, r);
        }
        return result;
    }
}