using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    class XuLy
    {
        private double hsA;
        private double hsB;
        private double hsC;

        public XuLy(double hsA, double hsB, double hsC)
        {
            this.hsA = hsA;
            this.hsB = hsB;
            this.hsC = hsC;
        }

        public String nghiem()
        {
            String nghiem = "";
            if (hsA != 0)
            {
                double delta = hsB * hsB - 4 * hsA * hsC;
                if (delta > 0)
                {
                    double x1 = (-hsB + Math.Sqrt(delta)) / (2 * hsA);
                    double x2 = (-hsB - Math.Sqrt(delta)) / (2 * hsA);
                    nghiem += "Phương trinh có 2 nghiệm: x1 = " + x1.ToString("#.##") + "; x2 = " + x2.ToString("#.##");
                }
                else if (delta == 0)
                {
                    nghiem += "Phương trình có 1 nghiệm: x = " + (-hsB / (2 * hsA)).ToString("#.##");
                }
                else
                {
                    nghiem += "Phương trình vô nghiệm";
                }
            }
            else
            {
                if (hsB != 0)
                {
                    nghiem += "Phương trinh có nghiệm: x = " + (-hsC / hsB).ToString("#.##");
                }
                else
                {
                    if (hsC != 0)
                    {
                        nghiem += "Phương trình vô nghiệm";
                    }
                    else
                    {
                        nghiem += "Phương trình có vô số nghiệm";
                    }
                }
            }

            return nghiem;
        }
    }
}
