using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Presenation
    {      public class DoHoa
        {
            public DoHoa(int a, int b)
            {
                Console.SetWindowSize(a, b);
            }
            public void ve(string s, int x, int y)
            {
                Console.SetWindowSize(100, 55);
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            public void ve1(string s, int x, int y)
            {
                Console.SetWindowSize(137, 55);
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
        }
    
}

