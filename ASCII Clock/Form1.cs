using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII_Clock
{
    public partial class Form1 : Form
    {
        Numbers number = new Numbers();
        public Form1()
        {
            InitializeComponent();
        }
        int hourint ;
        int minute ;
        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer1.Interval = 1000;
           
        }
        private void rend(int time)
        {
            string[] h = displayClock(time);
            for (int i = 0; i < h.Count(); i++)
       
            {
                textBox1.AppendText(h[i] + "\r\n");
            }
            hour[0] = " ";
            hour[1] = " ";
            hour[2] = " ";
            hour[3] = " ";
            hour[4] = " ";       
        }
      
        private string[] displayClock(int number)
        {
            string[] h ={ @"",
                           @"",
                           @"",
                           @"",
                        @"",};

            //

            int result = 0;
            while (number > 0)
            {
                result = result * 10 + number % 10;
                number /= 10;
            }
            //

            int x = 0;
            int n = result;
            while(x<4)
            {
                if (x == 2)
                { instertDots(); 
                }
                if (n != 00)
                {
                    
                    switch (n%10)
                    {
                        case 1:
                            h = hourcomplete(this.number.n1);
                            break;
                        case 2:
                            h = hourcomplete(this.number.n2);
                            break;
                        case 3:
                            h = hourcomplete(this.number.n3);
                            break;
                        case 4:
                            h = hourcomplete(this.number.n4);
                            break;
                        case 5:
                            h = hourcomplete(this.number.n5);
                            break;
                        case 6:
                            h = hourcomplete(this.number.n6);
                            break;
                        case 7:
                            h = hourcomplete(this.number.n7);
                            break;
                        case 8:
                            h = hourcomplete(this.number.n8);
                            break;
                        case 9:
                            h = hourcomplete(this.number.n9);

                            break;
                        case 0:
                            h = hourcomplete(this.number.n0);
                          
                            break;

                    }
                    x++;
                    n = n / 10;
                }
                else
                { 
                  h = hourcomplete(this.number.n0);
                  h = hourcomplete(this.number.n0);
                  x = 2;
                }
            
            }
            return h;
        }
        string[] hour ={ @"",
                           @"",
                           @"",
                           @"",
                         @"",};
        private string[] hourcomplete(string[] a)
        { 
                    hour[0] = hour[0]+  a[0]+"";
                    hour[1] = hour[1] + a[1]+"";
                    hour[2] = hour[2] + a[2]+"";
                    hour[3] = hour[3] + a[3]+"";
                    hour[4] = hour[4] + a[4] + "";
            return hour;
        }

        private void instertDots()
        {
          hour[0] = hour[0] + "  ";
          hour[2] = hour[2] + " °";
          hour[1] = hour[1] + "  ";
          hour[3] = hour[3] + " °";
          hour[4] = hour[4] + "  ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           int hourint = DateTime.Now.Hour;
           int minute = DateTime.Now.Minute;
            textBox1.Text = "";
            int nt = hourint * 100 + minute;
            rend(nt);
        }


    }
}
