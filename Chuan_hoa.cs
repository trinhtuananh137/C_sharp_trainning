using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Train
{
    class program
    {
        static void Main(string[] args)
        {
            string name = "Trinh Tuan Anh";
            int i;
            Console.Write("Hay nhap ten cua ban: "); name = Console.ReadLine();
            name = name.Trim();
            do
            {
                i = name.IndexOf("  ");
                if (i != -1) name = name.Replace("  ", " ");
            } while (i != -1);
            string[] mang = name.Split();
            for (int j = 0; j < mang.Length; j++)
            {
                string str = mang[j].Substring(0, 1);
                string _str = str.ToUpper();
                mang[j] = mang[j].Replace(str, _str);
            }
            name = null;
            foreach (string element in mang)
            {
                name = name +" "+ element;
            }
            name = name.Trim();
            Console.WriteLine("Ten cua ban sau khi chuan hoa:" + name);
        }
    }
}
