using System;

namespace ViLibrary
{
    public class lib1
    {
        static public string stpow(string k, int b)
        {
            string k1 = k;
            for (int s = 0; s < b - 1; s++)
            {
                k = k + k1;
            }
            return (k);
        }
        static public string rev(string a)
        {
            string l = "";
            for (int s = a.Length - 1; s > -1; s--)
            {
                l = l + a[s] + "";
            }
            return (l);
        }
        static public string remov(string y, string u)
        {
            for (int s = 0; s < y.Length; s++)
            {
                y = y.Replace(u, "");
            }
            return (y);
        }
        static public int leng(string f)
        {
            int x = f.Length;
            return (x);
        }
    }
}

