using System.Text;

namespace _04_Calculatrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textResult.Enabled = false;
           
        }

        private void btnEfface_Click(object sender, EventArgs e)
        {
            textCalcul.Clear();
            textResult.Clear();
        }

      

        private void btn_Operator(object sender, EventArgs e)
        {
            Calcul c = new(textCalcul.Text);

            textResult.AppendText(c.GetResult().ToString());
            textResult.AppendText(Environment.NewLine);
        }

        private void btnSimpleKey_Click(object sender, EventArgs e)
        {
            if(sender is not Button btn) return;

            string key = btn.Text;

            //textCalcul.Text = text;

            int currentCursor = textCalcul.SelectionStart;

            textCalcul.Text = textCalcul.Text.Insert(currentCursor, key);
            textCalcul.SelectionStart = currentCursor + 1;
            
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (btnOnOff.Text == "ON")
            {
                btnOnOff.Text = "OFF";
            }
            else
            {
                btnOnOff.Text = "ON";
            }

            

            
                foreach (Control item in groupBox1.Controls)
                {
                    if(item.Name != "btnOnOff")
                    {
                        item.Enabled = !(item.Enabled);
                    }
                }
            

           

        }

        private void btnRetourEfface_Click(object sender, EventArgs e)
        {
            int currentCursor = textCalcul.SelectionStart;

            if(currentCursor > 0)
            {
                StringBuilder str = new(textCalcul.Text);

                str.Remove(currentCursor - 1, 1);

                textCalcul.Text = str.ToString();

                textCalcul.SelectionStart = currentCursor - 1;
            }
        }
    }
}