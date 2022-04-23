using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIxelBattle
{
    public class BasicData
    {
        public string C0 { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string C5 { get; set; }
        public string C6 { get; set; }
        public string C7 { get; set; }
        public string C8 { get; set; }
        public string C9 { get; set; }
        public string Brash { get; set; }

        public BasicData(string C0, string C1, string C2, string C3, string C4, string C5, string C6, string C7, string C8, string C9, string Brash)
        {
            this.C0 = C0;
            this.C1 = C1;
            this.C2 = C2;
            this.C3 = C3;
            this.C4 = C4;
            this.C5 = C5;
            this.C6 = C6;
            this.C7 = C7;
            this.C8 = C8;
            this.C9 = C9;
        }
        public static List<BasicData> BasicSet()
        {
            List<BasicData> BasicSetList = new List<BasicData>()
            {
                //new BasicData("R0", "R1","R2","R3","R4","R5","R6","R7","R8","R9"),
                //new BasicData("R0", "R1","R2","R3","R4","R5","R6","R7","R8","R9"),
                //new BasicData("R0", "R1","R2","R3","R4","R5","R6","R7","R8","R9"),
                //new BasicData("R0", "R1","R2","R3","R4","R5","R6","R7","R8","R9"),
                //new BasicData("R0", "R1","R2","R3","R4","R5","R6","R7","R8","R9"),
                //new BasicData("R0", "R1","R2","R3","R4","R5","R6","R7","R8","R9"),
                //new BasicData("R0", "R1","R2","R3","R4","R5","R6","R7","R8","R9"),
                //new BasicData("R0", "R1","R2","R3","R4","R5","R6","R7","R8","R9"),
                //new BasicData("R0", "R1","R2","R3","R4","R5","R6","R7","R8","R9")
                new BasicData("","","","","","","","","","", "Black"),
                new BasicData("","","","","","","","","","", "Black"),
                new BasicData("","","","","","","","","","", "Black"),
                new BasicData("","","","","","","","","","", "Black"),
                new BasicData("","","","","","","","","","", "Black"),
                new BasicData("","","","","","","","","","", "Black"),
                new BasicData("","","","","","","","","","", "Black"),
                new BasicData("","","","","","","","","","", "Black"),
                new BasicData("","","","","","","","","","", "Black")
            };
            return BasicSetList;
        }
    }
    
}
