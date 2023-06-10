using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculador2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
            limpa(new object(),new EventArgs ());
            


        }
        int correntstate = 1;
        string mathoperador;
        double n1, n2;

        void num(object s, EventArgs e) { 
        
        Button b= (Button)s;string press=b.Text;
            if (this.restext.Text == "0" || correntstate < 0) {
                this.restext.Text = "";
                if (correntstate < 0) correntstate *= -1;
            }
            this.restext.Text += press;

            double num;
            if (double.TryParse(this.restext.Text, out num)) { 
            
            this.restext.Text=num.ToString("N0");
              
                
                if (correntstate == 1){n1 = num; }else { n2 = num; }
                
                    
               
                
            }

        
        }

        void calc(object s, EventArgs e) {
            if (correntstate == 2) {
                Double res = 0;

      
        switch (mathoperador){case "+": res = n1 + n2; break;case "-": res = n2 - n1; break; case "x": res = n1 * n2; break; case "/": res = n1 / n2; break; }


                this.restext.Text = res.ToString("N0");
        //this.restext.Text = res.ToString();
                n1 = res;
                correntstate = -1;
                        
                        
                   
                        
                        
               
                        
            
            
            
            }
        
        }
        void operador(object s, EventArgs e) {
            
            correntstate = -2;
            Button b= (Button)s;
            string press=b.Text;
            mathoperador = press;
        }
        void limpa(object s, EventArgs e)
            
        {

            n1 = 0; n2 = 0; correntstate = 1;
            this.restext.Text = "0";
        }
        
    }
}
