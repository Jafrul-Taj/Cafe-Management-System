using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_CoffeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString();
            lblDate.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            txtAfrican.Text = "0";
            txtAmerican.Text = "0";
            txtAngel.Text = "0";
            txtBlack.Text = "0";
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtIcedLatte.Text = "0";
            txtValeCoffee.Text = "0";
            txtCappucino.Text = "0";
            txtIcedCappucino.Text = "0";
            txtLong.Text = "0";
            txtFlat.Text = "0";
            txtAngel.Text = "0";
            txtKilburn.Text = "0";
            txtStrawberry.Text = "0";
            txtCoffeeCake.Text = "0";
            txtRedValvet.Text = "0";
            txtBlack.Text = "0";
            txtBoston.Text = "0";
            txtLagos.Text = "0";
            txtLagos.Text = "0";
            txtCarlton.Text = "0";
            txtQueen.Text = "0";
            lblServiceCharges.Text = "1.75";
            txtCoffeeCake.Text = "0";
            lblCostCake.Text = "0";
            lblCostDrinks.Text = "0";
            lblTex.Text = "0";
            lblTotal.Text = "0";
            lblSubTotal.Text = "0";
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label25_Click(object sender, EventArgs e)
        {

        }

        private void Label26_Click(object sender, EventArgs e)
        {

        }

        private void Label27_Click(object sender, EventArgs e)
        {

        }

        private void Label28_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Label29_Click(object sender, EventArgs e)
        {

        }

        private void Label30_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label34_Click(object sender, EventArgs e)
        {

        }

        private void Label33_Click(object sender, EventArgs e)
        {

        }

        private void Label32_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exti_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtAfrican.Text = "0";
            txtAmerican.Text = "0";
            txtAngel.Text = "0";
            txtBlack.Text = "0";
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtIcedLatte.Text = "0";
            txtValeCoffee.Text = "0";
            txtCappucino.Text = "0";
            txtIcedCappucino.Text = "0";
            txtKilburn.Text = "0";
            txtLong.Text = "0";
            txtFlat.Text = "0";
            txtAngel.Text = "0";
            txtStrawberry.Text = "0";
            txtCoffeeCake.Text = "0";
            txtRedValvet.Text = "0";
            txtBlack.Text = "0";
            txtBoston.Text = "0";
            txtLagos.Text = "0";
            txtLagos.Text = "0";
            txtCarlton.Text = "0";
            txtQueen.Text = "0";
            lblServiceCharges.Text = "1.75";
            lblCostDrinks.Text = "0";
            txtCoffeeCake.Text = "0";
            lblCostCake.Text = "0";

            cffLatte.Checked = false;
            cffEspresso.Checked = false;
            cffIcedLatte.Checked = false;
            cffValeCoffee.Checked = false;
            cffCappuccino.Checked = false;
            cffAfricanCaffee.Checked = false;
            cffIcedCappucino.Checked = false;
            cffFlatWhite.Checked = false;
            cffAfricanCaffee.Checked = false;
            cffLongBlack.Checked = false;
            chkCoffee.Checked = false;
            chkRedValvet.Checked = false;
            chkBlackForest.Checked = false;
            chkBostonCream.Checked = false;
            chkLagosChocolate.Checked = false;
            chkKilburnChocolate.Checked = false;
            chkCarltonHillChocolate.Checked = false;
            chkQueenPark.Checked = false;
            chkStrawberryShortcake.Checked = false;
            chkAngel.Checked = false;
        }

        private void Recite_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
            rtfReceipt.AppendText(Environment.NewLine);
          //  rtfReceipt.AppendText("-------------------------------------------------" +Environment.NewLine);
            rtfReceipt.AppendText("\t" + "Just Do Cafe" + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Latte \t\t\t\t\t" + txtLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Espresso \t\t\t\t" + txtEspresso.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Latte \t\t\t\t" + txtIcedLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Vale Coffee \t\t\t\t" + txtValeCoffee.Text + Environment.NewLine);
            rtfReceipt.AppendText("Cappuccino \t\t\t\t" + txtCappucino.Text + Environment.NewLine);
            rtfReceipt.AppendText("African Coffee \t\t\t" + txtAfrican.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Cappuccino \t\t\t" + txtIcedCappucino.Text + Environment.NewLine);

            rtfReceipt.AppendText("Coffee Cake \t\t\t\t" + txtCoffeeCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Red Valvet Cake \t\t\t" + txtRedValvet.Text + Environment.NewLine);
            rtfReceipt.AppendText("Black Forest Cake \t\t\t" + txtBlack.Text + Environment.NewLine);
            rtfReceipt.AppendText("Boston Cream Cake \t\t\t" + txtBoston.Text + Environment.NewLine);
            rtfReceipt.AppendText("Lagos Chocolate Cake \t\t" + txtLagos.Text + Environment.NewLine);
            rtfReceipt.AppendText("Kilburn Chocolate Cake \t\t" + txtKilburn.Text + Environment.NewLine);
            rtfReceipt.AppendText("Carlton Hill Chocolate Cake \t" + txtCarlton.Text + Environment.NewLine);
            rtfReceipt.AppendText("Queen's Park Chocolate Cake \t" + txtQueen.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Service Charges \t\t\t" + lblServiceCharges.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Tex \t\t\t\t\t" + lblTex.Text + Environment.NewLine);
            rtfReceipt.AppendText("SubTotal\t\t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("--------------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTime.Text + "-------------------" + lblDate.Text+ Environment.NewLine);
        }

        private void Total_Click(object sender, EventArgs e)
        {
            List<double> coffee = new List<double>();
            List<double> cake = new List<double>();
            
            double latte = 1.20,espres= 1.29,ilatte=1.50,vale=1.45, afcoffee=1.50,amcoffee=1.45,capp=1.70,flat=1.10,longB=1.25;
            double cCake = 1.30, rVel = 1.20, bFor = 1.30, cBos = 1.90, clag = 1.50, cKilb = 1.40, cCorl = 1.30, cQeen = 1.10, 
                straw = 1.25, angel = 1.35;

            //Coffee;
            latte = Convert.ToDouble(txtLatte.Text) * latte;
            espres = Convert.ToDouble(txtEspresso.Text) * espres;
            ilatte = Convert.ToDouble(txtIcedLatte.Text) * ilatte;
            vale = Convert.ToDouble(txtValeCoffee.Text) * vale;
            afcoffee = Convert.ToDouble(txtAfrican.Text) * afcoffee;
            amcoffee = Convert.ToDouble(txtAmerican.Text) * amcoffee;
            capp = Convert.ToDouble(txtCappucino.Text) * capp;
            flat = Convert.ToDouble(txtFlat.Text) * flat;
            longB = Convert.ToDouble(txtLong.Text) * longB;

            coffee.Add(latte);
            coffee.Add(espres);
            coffee.Add(ilatte);
            coffee.Add(afcoffee);
            coffee.Add(amcoffee);
            coffee.Add(capp);
            coffee.Add(flat);
            coffee.Add(longB);
            coffee.Add(vale);

            ////cake
            //double cCake = 1.30, rVel = 1.20, bFor = 1.30, cBos = 1.90, clag = 1.50, cKilb = 1.40, cCorl = 1.30, cQeen = 1.10,
            //   straw = 1.25, angel = 1.35;

            cCake = Convert.ToDouble(txtCoffeeCake.Text) * cCake;
            rVel = Convert.ToDouble(txtRedValvet.Text) * rVel;
            bFor = Convert.ToDouble(txtBlack.Text) * bFor;
            cBos = Convert.ToDouble(txtBoston.Text) * cBos;
            clag = Convert.ToDouble(txtLagos.Text) * clag;
            cKilb = Convert.ToDouble(txtKilburn.Text) * cKilb;
            cCorl = Convert.ToDouble(txtLagos.Text) * cCorl;
            cQeen = Convert.ToDouble(txtQueen.Text) * cQeen;
            straw = Convert.ToDouble(txtStrawberry.Text) * straw;
            angel = Convert.ToDouble(txtAngel.Text) * angel;

            cake.Add(cCake);
            cake.Add(rVel);
            cake.Add(bFor);
            cake.Add(cBos);
            cake.Add(clag);
            cake.Add(cKilb);
            cake.Add(cCorl);
            cake.Add(cCorl);
            cake.Add(cQeen);
            cake.Add(straw);
            cake.Add(angel);

            double CostOfDrinks = 0;
            double CostOfCake = 0;

            foreach(var c in coffee)
            {
                CostOfDrinks += c;
            }
            CostOfDrinks = Math.Round(CostOfDrinks, 2);
            lblCostDrinks.Text = CostOfDrinks.ToString();

            foreach (var c in cake)
            {
                CostOfCake += c;
            }
            CostOfCake = Math.Round(CostOfCake, 2);
            lblCostCake.Text = CostOfCake.ToString();

            double tex = (CostOfCake + CostOfDrinks) * .15;
            tex = Math.Round(tex, 2);
            lblTex.Text = tex.ToString();
            double total = CostOfDrinks + CostOfDrinks + Convert.ToDouble(lblServiceCharges.Text) + tex ;
            double subtotal = CostOfDrinks + CostOfDrinks + Convert.ToDouble(lblServiceCharges.Text);

            lblTotal.Text = total.ToString();
            lblSubTotal.Text = subtotal.ToString();

        }

        private void ChkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if(cffLatte.Checked==true)
            {
                txtLatte.Enabled = true;
            }
            // if(cffLatte.Checked==false)
            else
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }

        private void ChkIcedLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (cffIcedLatte.Checked == true)
                txtIcedLatte.Enabled = true;

            //if(cffIcedLatte.Checked = false)
            else
            {
                txtIcedLatte.Enabled = false;
                txtIcedLatte.Text = "0";
            }
        }

        private void ChkValeCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (cffValeCoffee.Checked == true)
                txtValeCoffee.Enabled = true;
            else
            {
                txtValeCoffee.Enabled = false;
                txtValeCoffee.Text = "0";
            }
        }

        private void ChkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (cffCappuccino.Checked == true)
                txtCappucino.Enabled = true;

            else
            {
                txtCappucino.Enabled = false;
                txtCappucino.Text = "0";
            }
        }

        private void ChkAfrican_CheckedChanged(object sender, EventArgs e)
        {
            if (cffAfricanCaffee.Checked == true)
                txtAfrican.Enabled = true;

            else
            {
                txtAfrican.Enabled = false;
                txtAfrican.Text = "0";
            }
        }

        private void ChkIcedCappucino_CheckedChanged(object sender, EventArgs e)
        {
            if (cffIcedCappucino.Checked == true)
                txtIcedCappucino.Enabled = true;

            else
            {
                txtIcedCappucino.Enabled = false;
                txtIcedCappucino.Text = "0";
            }
        }

        private void ChkFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (cffFlatWhite.Checked)
                txtFlat.Enabled = true;

            else
            {
                txtFlat.Enabled = false;
                txtFlat.Text = "0";
            }
        }

        private void ChkAmrican_CheckedChanged(object sender, EventArgs e)
        {
            if (cffAmericanCaffee.Checked)
                txtAmerican.Enabled = true;

            else
            {
                txtAmerican.Enabled = false;
                txtAmerican.Text = "0";
            }
        }

        private void ChkLong_CheckedChanged(object sender, EventArgs e)
        {
            if (cffLongBlack.Checked)
                txtLong.Enabled = true;
            else
            {
                txtLong.Enabled = false;
                txtLong.Text = "0";
            }
        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked)
                txtCoffeeCake.Enabled = true;

            else
            {
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.Text = "0";
            }
        }

        private void chkRedValvet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedValvet.Checked)
                txtRedValvet.Enabled = true;

            else
            {
                txtRedValvet.Enabled = false;
                txtRedValvet.Text = "0";
            }
        }

        private void ChkBlackForest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackForest.Checked)
                txtBlack.Enabled = true;
            else
            {
                txtBlack.Enabled = false;
                txtBlack.Text = "0";
            }
        }

        private void ChkBoston_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBostonCream.Checked)
                txtBoston.Enabled = true;

            else
            {
                txtBoston.Enabled = false;
                txtBoston.Text = "0";
            }
        }

        private void chkLagos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLagosChocolate.Checked)
                txtLagos.Enabled = true;

            else
            {
                txtLagos.Enabled = false;
                txtLagos.Text = "0";
            }
        }

        private void chkKilburn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKilburnChocolate.Checked)
                txtKilburn.Enabled = true;

            else
            {
                txtKilburn.Enabled = false;
                txtKilburn.Text = "0";
            }
        }

        private void chkCarlton_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarltonHillChocolate.Checked)
                txtCarlton.Enabled = true;
            else
            {
                txtCarlton.Enabled = false;
                txtCarlton.Text = "0";
            }
        }

        private void chkQueen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQueenPark.Checked)
                txtQueen.Enabled = true;

            else
            {
                txtQueen.Enabled = false;
                txtQueen.Text = "0";
            }
        }

        private void chkStrawberry_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStrawberryShortcake.Checked == true)
                txtStrawberry.Enabled = true;

            // if (chkStrawberryShortcake.Checked == false)
            else
            {
                txtStrawberry.Enabled = false;
                txtStrawberry.Text = "0";
            }
                
        }

        private void chkAngel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAngel.Checked == true)
                txtAngel.Enabled = true;

            //  if (chkAngel.Checked == false)
            else
            {
                txtAngel.Enabled = false;
                txtAngel.Text = "0";
            }
                
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (cffEspresso.Checked)
                txtEspresso.Enabled = true;

            else
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void txtLatte_click(object sender, EventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();
        }

        private void txtEspresso_click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
        }

        private void txtIcedLatte_click(object sender, EventArgs e)
        {
            txtIcedLatte.Text = "";
            txtIcedLatte.Focus();
        }

        private void txtVale_click(object sender, EventArgs e)
        {
            txtValeCoffee.Text = "";
            txtValeCoffee.Focus();
        }

        private void txtCappuccino_click(object sender, EventArgs e)
        {
            txtCappucino.Text = "";
            txtCappucino.Focus();
        }

        private void txtAfrican_click(object sender, EventArgs e)
        {
            txtAfrican.Text = "";
            txtAfrican.Focus();
        }

        private void txtIcedCappuccino_click(object sender, EventArgs e)
        {
            txtIcedCappucino.Text = "";
            txtIcedCappucino.Focus();
        }

        private void txtFlat_click(object sender, EventArgs e)
        {
            txtFlat.Text = "";
            txtFlat.Focus();
        }

        private void txtAmerican_click(object sender, EventArgs e)
        {
            txtAmerican.Text = "";
            txtAmerican.Focus();
        }

        private void txtLong_click(object sender, EventArgs e)
        {
            txtLong.Text = "";
            txtLong.Focus();
        }

        private void txtCoffeeCake_click(object sender, EventArgs e)
        {
            txtCoffeeCake.Text = "";
            txtCoffeeCake.Focus();
        }

        private void txtRed_click(object sender, EventArgs e)
        {
            txtRedValvet.Text = "";
            txtRedValvet.Focus();
        }

        private void txtBlack_click(object sender, EventArgs e)
        {
            txtBlack.Text = "";
            txtBlack.Focus();
        }

        private void txtBoston_click(object sender, EventArgs e)
        {
            txtBoston.Text = "";
            txtBoston.Focus();
        }

        private void txtLagos_click(object sender, EventArgs e)
        {
            txtLagos.Text = "";
            txtLagos.Focus();
        }

        private void TxtKilburn(object sender, EventArgs e)
        {
            txtKilburn.Text = "";
            txtKilburn.Focus();
        }

        private void txtCarlton_click(object sender, EventArgs e)
        {
            txtCarlton.Text = "";
            txtCarlton.Focus();
        }

        private void txtQueen_click(object sender, EventArgs e)
        {
            txtQueen.Text = "";
            txtQueen.Focus();
        }

        private void txtStrawberry_click(object sender, EventArgs e)
        {
            txtStrawberry.Text = "";
            txtStrawberry.Focus();
        }

        private void txtAngel_click(object sender, EventArgs e)
        {
            txtAngel.Text = "";
            txtAngel.Focus();
        }

        private void TxtAngel_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtStrawberry_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtQueen_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCarlton_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtKilburn_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString();
            // lblDate.Text = DateTime.Now.ToLongTimeString();
            //timer1.Start();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void PrintToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void CutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void PasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);

        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }
    }
}
