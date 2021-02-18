using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADFGVX
{
    public partial class Form1 : Form
    {
        private string alphabet = "abcdefghijklmnopqrstuvwxyz0123456789".ToUpper();
        List<TextBox> ADFGVXTextBoxes { get; set; } = new List<TextBox>();
        List<TextBox> ADFGXTextBoxes { get; set; } = new List<TextBox>();
        List<Cell> MatriceADFGVX { get; set; } = new List<Cell>();
        List<Cell> MatriceADFGX { get; set; } = new List<Cell>();
        List<Cell> EncMatrice { get; set; } = new List<Cell>();
        List<Cell> DecMatrice { get; set; } = new List<Cell>();
        public string ADFGXLang = "cs";
        public string FillADFGVX { get; set; }
        public string FillADFGX { get; set; }
        public string OpenMessage { get; set; }
        public string FormattedMessage { get; set; }
        public string FractionatedMessage { get; set; }
        private string KeyToEnc { get; set; }
        private string KeyToDec { get; set; }
        private string EncryptedMessage { get; set; }
        public Form1()
        {
            InitializeComponent();

            ADFGXTextBoxes.Add(adfgx11);
            ADFGXTextBoxes.Add(adfgx12);
            ADFGXTextBoxes.Add(adfgx13);
            ADFGXTextBoxes.Add(adfgx14);
            ADFGXTextBoxes.Add(adfgx15);
            ADFGXTextBoxes.Add(adfgx21);
            ADFGXTextBoxes.Add(adfgx22);
            ADFGXTextBoxes.Add(adfgx23);
            ADFGXTextBoxes.Add(adfgx24);
            ADFGXTextBoxes.Add(adfgx25);
            ADFGXTextBoxes.Add(adfgx31);
            ADFGXTextBoxes.Add(adfgx32);
            ADFGXTextBoxes.Add(adfgx33);
            ADFGXTextBoxes.Add(adfgx34);
            ADFGXTextBoxes.Add(adfgx35);
            ADFGXTextBoxes.Add(adfgx41);
            ADFGXTextBoxes.Add(adfgx42);
            ADFGXTextBoxes.Add(adfgx43);
            ADFGXTextBoxes.Add(adfgx44);
            ADFGXTextBoxes.Add(adfgx45);
            ADFGXTextBoxes.Add(adfgx51);
            ADFGXTextBoxes.Add(adfgx52);
            ADFGXTextBoxes.Add(adfgx53);
            ADFGXTextBoxes.Add(adfgx54);
            ADFGXTextBoxes.Add(adfgx55);


            ADFGVXTextBoxes.Add(adfgvx11);
            ADFGVXTextBoxes.Add(adfgvx12);
            ADFGVXTextBoxes.Add(adfgvx13);
            ADFGVXTextBoxes.Add(adfgvx14);
            ADFGVXTextBoxes.Add(adfgvx15);
            ADFGVXTextBoxes.Add(adfgvx16);
            ADFGVXTextBoxes.Add(adfgvx21);
            ADFGVXTextBoxes.Add(adfgvx22);
            ADFGVXTextBoxes.Add(adfgvx23);
            ADFGVXTextBoxes.Add(adfgvx24);
            ADFGVXTextBoxes.Add(adfgvx25);
            ADFGVXTextBoxes.Add(adfgvx26);
            ADFGVXTextBoxes.Add(adfgvx31);
            ADFGVXTextBoxes.Add(adfgvx32);
            ADFGVXTextBoxes.Add(adfgvx33);
            ADFGVXTextBoxes.Add(adfgvx34);
            ADFGVXTextBoxes.Add(adfgvx35);
            ADFGVXTextBoxes.Add(adfgvx36);
            ADFGVXTextBoxes.Add(adfgvx41);
            ADFGVXTextBoxes.Add(adfgvx42);
            ADFGVXTextBoxes.Add(adfgvx43);
            ADFGVXTextBoxes.Add(adfgvx44);
            ADFGVXTextBoxes.Add(adfgvx45);
            ADFGVXTextBoxes.Add(adfgvx46);
            ADFGVXTextBoxes.Add(adfgvx51);
            ADFGVXTextBoxes.Add(adfgvx52);
            ADFGVXTextBoxes.Add(adfgvx53);
            ADFGVXTextBoxes.Add(adfgvx54);
            ADFGVXTextBoxes.Add(adfgvx55);
            ADFGVXTextBoxes.Add(adfgvx56);
            ADFGVXTextBoxes.Add(adfgvx61);
            ADFGVXTextBoxes.Add(adfgvx62);
            ADFGVXTextBoxes.Add(adfgvx63);
            ADFGVXTextBoxes.Add(adfgvx64);
            ADFGVXTextBoxes.Add(adfgvx65);
            ADFGVXTextBoxes.Add(adfgvx66);

            foreach(var p in ADFGVXTextBoxes)
            {
                p.Enabled = false;
            }
            foreach(var p in ADFGXTextBoxes)
            {
                p.Enabled = false;
            }

            radioButton3.Checked = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Text = alphabet;
            label1.Visible = false;
            label2.Visible = false;

            FillADFGVX = textBox1.Text.ToUpper();
            FillADFGX = textBox2.Text.ToUpper();

        }

        private string MixedAlphabetADFGVX()
        {
            return MixIt(alphabet);
        }
        private string MixedAlphabetADFGXcs()
        {
            return MixIt(alphabet.Replace("0123456789", "").Replace("W", ""));
        }
        private string MixedAlphabetADFGXen()
        {
            return MixIt(alphabet.Replace("0123456789", "").Replace("J", ""));
        }

        private string MixIt(string alpha)
        {
            char[] array = alpha.ToCharArray();
            Random rnd = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
            button5.Visible = false;

            foreach (var p in ADFGVXTextBoxes) p.Enabled = false;
            string mixed = MixedAlphabetADFGVX();

            MatriceADFGVX = Cell.CreateMatrice(mixed);

            for (int i = 0; i < mixed.Length && i < ADFGVXTextBoxes.Count(); i++)
            {
                ADFGVXTextBoxes[i].Text = mixed[i].ToString();
            }

            if(richTextBox2.Text != null && richTextBox2.Text.Length > 0 && richTextBox5.Text != null && richTextBox5.Text.Length > 0 && FormattedMessage.Length > 0)
            {
                string dumb = String.Empty;
                for(int i = 0; i < FormattedMessage.Length; i++)
                {
                    var cell = MatriceADFGVX.FirstOrDefault(x => x.letter == FormattedMessage[i]);
                    dumb += cell.RowLetterV.ToString() + cell.ColumnLetterV.ToString();
                }
                FractionatedMessage = dumb;
            }
            richTextBox3.Text = SpacingByTwo(FractionatedMessage);
        }

        private string SpacingByTwo(string text)
        {
            if (text != null && text.Length > 1)
            {
                for (int i = 2; i <= text.Length; i += 2)
                {
                    text = text.Insert(i, " ");
                    i++;
                }
                return text;
            }
            return text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label2.Visible = false;
            button6.Visible = false;

            foreach (var p in ADFGXTextBoxes) p.Enabled = false;
            string mixed = ADFGXLang == "cs" ? MixedAlphabetADFGXcs() : MixedAlphabetADFGXen();
            MatriceADFGX = Cell.CreateMatrice(mixed);
            for (int i = 0; i < mixed.Length && i < ADFGXTextBoxes.Count(); i++)
            {
                ADFGXTextBoxes[i].Text = mixed[i].ToString();
            }
            if (FormattedMessage.Length > 0)
            {
                string dumb = String.Empty;
                for (int i = 0; i < FormattedMessage.Length; i++)
                {
                    var cell = MatriceADFGX.FirstOrDefault(x => x.letter == FormattedMessage[i]);
                    dumb += cell.RowLetter.ToString() + cell.ColumnLetter.ToString();
                }
                FractionatedMessage = dumb;
            }
            richTextBox8.Text = SpacingByTwo(FractionatedMessage);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ADFGXLang = "cs";
            label2.Text = ADFGXLang == "cs"
                        ? alphabet.Replace("0123456789", "").Replace("W", "")
                        : alphabet.Replace("0123456789", "").Replace("J", "");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ADFGXLang = "en";
            label2.Text = ADFGXLang == "cs"
                        ? alphabet.Replace("0123456789", "").Replace("W", "")
                        : alphabet.Replace("0123456789", "").Replace("J", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var p in ADFGVXTextBoxes)
            {
                p.Text = String.Empty;
                p.MaxLength = 1;
            }
            textBox1.Text = "";
            FillADFGVX = "";
            textBox1.Visible = true;
            label1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Visible)
            {
                textBox1.Text = textBox1.Text.ToUpper();
                if (textBox1.Text.Length < FillADFGVX.Length)
                {
                    string deleted = textBox1.Text.Length > 0
                                    ? FillADFGVX.Replace(textBox1.Text, "")
                                    : textBox1.Text;
                    label1.Text += deleted == "" ? FillADFGVX : deleted;
                    FillADFGVX = textBox1.Text;
                }
                string last = textBox1.Text.Length > 1
                            ? textBox1.Text.ToUpper().Replace(FillADFGVX, "")
                            : textBox1.Text;
                if (!alphabet.Contains(last))
                {
                    textBox1.Text = FillADFGVX;
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.SelectionLength = 0;
                    return;
                }
                if (FillADFGVX.Contains(last))
                {
                    textBox1.Text = FillADFGVX;
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.SelectionLength = 0;
                    return;
                }
                FillADFGVX = textBox1.Text;
                label1.Text = label1.Text.Replace(last, "");
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.SelectionLength = 0;
                if (label1.Text == "") button5.Visible = true;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string alpha = ADFGXLang == "cs"
                         ? alphabet.Replace("0123456789", "").Replace("W", "")
                         : alphabet.Replace("0123456789", "").Replace("J", "");
            if (textBox2.Visible)
            {
                textBox2.Text = textBox2.Text.ToUpper();
                if (textBox2.Text.Length < FillADFGX.Length)
                {
                    string deleted = textBox2.Text.Length > 0
                                    ? FillADFGX.Replace(textBox2.Text, "")
                                    : textBox2.Text;
                    label2.Text += deleted == "" ? FillADFGX : deleted;
                    FillADFGX = textBox2.Text;
                }
                string last = textBox2.Text.Length > 1
                            ? textBox2.Text.ToUpper().Replace(FillADFGX, "")
                            : textBox2.Text;
                if (!alpha.Contains(last))
                {
                    textBox2.Text = FillADFGX;
                    textBox2.SelectionStart = textBox2.Text.Length;
                    textBox2.SelectionLength = 0;
                    return;
                }
                if (FillADFGX.Contains(last))
                {
                    textBox2.Text = FillADFGX;
                    textBox2.SelectionStart = textBox2.Text.Length;
                    textBox2.SelectionLength = 0;
                    return;
                }
                FillADFGX = textBox2.Text;
                label2.Text = label2.Text.Replace(last, "");
                textBox2.SelectionStart = textBox2.Text.Length;
                textBox2.SelectionLength = 0;

                if (label2.Text == "") button6.Visible = true;
            }
        }
        private void adfgvx12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(var p in ADFGXTextBoxes)
            {
                p.Text = String.Empty;
                p.MaxLength = 1;
            }
            textBox2.Text = "";
            FillADFGX = "";
            textBox2.Visible = true;
            label2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;
            button5.Visible = false;

            for (int i = 0; i < ADFGVXTextBoxes.Count() && i < FillADFGVX.Length; i++)
            {
                ADFGVXTextBoxes[i].Text = FillADFGVX[i].ToString();
            }

            MatriceADFGVX = Cell.CreateMatrice(FillADFGVX);

            if (richTextBox2.Text != null && richTextBox2.Text.Length > 0 && richTextBox5.Text != null && richTextBox5.Text.Length > 0 && FormattedMessage.Length > 0)
            {
                string dumb = String.Empty;
                for (int i = 0; i < FormattedMessage.Length; i++)
                {
                    var cell = MatriceADFGVX.FirstOrDefault(x => x.letter == FormattedMessage[i]);
                    dumb += cell.RowLetterV.ToString() + cell.ColumnLetterV.ToString();
                }
                FractionatedMessage = dumb;
            }
            richTextBox3.Text = SpacingByTwo(FractionatedMessage);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label2.Visible = false;
            button6.Visible = false;

            for (int i = 0; i < ADFGXTextBoxes.Count() && i < FillADFGX.Length; i++)
            {
                ADFGXTextBoxes[i].Text = FillADFGX[i].ToString();
            }

            MatriceADFGX = Cell.CreateMatrice(FillADFGX);

            if (FormattedMessage.Length > 0)
            {
                string dumb = String.Empty;
                for (int i = 0; i < FormattedMessage.Length; i++)
                {
                    var cell = MatriceADFGX.FirstOrDefault(x => x.letter == FormattedMessage[i]);
                    dumb += cell.RowLetter.ToString() + cell.ColumnLetter.ToString();
                }
                FractionatedMessage = dumb;
            }
            richTextBox8.Text = SpacingByTwo(FractionatedMessage);
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            string alph = alphabet + " ";
            richTextBox2.Text = richTextBox2.Text.ToUpper();
            
            if(!IsInAlphabet(richTextBox2.Text, alph))
            {
                richTextBox2.Text = richTextBox2.Text.Remove(richTextBox2.Text.Length - 1, 1);
            }

            OpenMessage = richTextBox2.Text;
            FormattedMessage = richTextBox5.Text = richTextBox2.Text.Replace(" ", "XMEZERAX");
            richTextBox2.SelectionStart = richTextBox2.Text.Length;
            richTextBox2.SelectionLength = 0;
        }

        private bool IsInAlphabet(string message, string alph)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if (alph.Contains(message[i]))
                {
                    continue;
                }
                return false;
            }

            return true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (KeyToEnc != null && KeyToEnc.Length > 0 && FractionatedMessage != null & FractionatedMessage.Length > 0)
            {
                richTextBox4.Text = EncryptedMessage = Encrypt();
                
            }
        }

        private string Encrypt()
        {
            EncMatrice = Cell.EncryptionMatrice(KeyToEnc, FractionatedMessage);
            string alphabeticalOrderKey = String.Concat(KeyToEnc.OrderBy(c => c));
            string encryptedMessage = String.Empty;

            for (int i = 0; i < alphabeticalOrderKey.Length; i++)
            {
                var matrice = EncMatrice.Where(x => x.KeyLetter == alphabeticalOrderKey[i]).ToList();
                foreach(var p in matrice)
                {
                    encryptedMessage += p.letter.ToString();
                }
                encryptedMessage += " ";
            }

            return encryptedMessage;
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            string alph = alphabet.Replace("0123456789", "");
            textBox3.Text = textBox3.Text.ToUpper();

            if (!IsInAlphabet(textBox3.Text, alph))
            {
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1, 1);
            }

            if (textBox3.Text.Length > 1)
            {
                if (KeyToEnc != null && KeyToEnc.Contains(textBox3.Text.Replace(KeyToEnc, "")))
                {
                    textBox3.Text = KeyToEnc;
                }
            }

            KeyToEnc = textBox3.Text;
            textBox3.SelectionStart = textBox3.Text.Length;
            textBox3.SelectionLength = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox6.Text = Decrypt();
        }

        private string Decrypt()
        {
            DecMatrice = Cell.DecryptionMatrice(KeyToDec, EncryptedMessage);
            string tmpMessage = String.Empty;
            var matrice = DecMatrice;

            while (matrice.Count > 0)
            {
                for (int i = 0; i < KeyToDec.Length; i++)
                {
                    var cell = matrice.FirstOrDefault(x => x.KeyLetter == KeyToDec[i]);
                    if (cell != null) tmpMessage += cell.letter;
                    matrice.Remove(cell);
                }
            }

            string openText = String.Empty;

            for(int j = 0; j < tmpMessage.Length; j += 2)
            {
                openText += MatriceADFGVX.FirstOrDefault(x => x.RowLetterV == tmpMessage[j] && x.ColumnLetterV == tmpMessage[j + 1]).letter.ToString();
            }

            return openText.Replace("XMEZERAX", " ");
        }

        private string RedundantDecrypt()
        {
            DecMatrice = Cell.DecryptionMatrice(KeyToDec, EncryptedMessage);
            string tmpMessage = String.Empty;
            var matrice = DecMatrice;

            while (matrice.Count > 0)
            {
                for (int i = 0; i < KeyToDec.Length; i++)
                {
                    var cell = matrice.FirstOrDefault(x => x.KeyLetter == KeyToDec[i]);
                    if (cell != null) tmpMessage += cell.letter;
                    matrice.Remove(cell);
                }
            }

            string openText = String.Empty;

            for (int j = 0; j < tmpMessage.Length; j += 2)
            {
                openText += MatriceADFGX.FirstOrDefault(x => x.RowLetter == tmpMessage[j] && x.ColumnLetter == tmpMessage[j + 1]).letter.ToString();
            }

            return openText.Replace("XMEZERAX", " ")
                           .Replace("XJEDNAX", "1")
                           .Replace("XDVAX", "2")
                           .Replace("XTRIX", "3")
                           .Replace("XCTYRIX", "4")
                           .Replace("XPETX", "5")
                           .Replace("XSESTX", "6")
                           .Replace("XSEDMX", "7")
                           .Replace("XOSMX", "8")
                           .Replace("XDEVETX", "9")
                           .Replace("XNULAX", "0");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string alph = alphabet.Replace("0123456789", "");
            textBox4.Text = textBox4.Text.ToUpper();

            if (!IsInAlphabet(textBox4.Text, alph))
            {
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1, 1);
            }

            if (textBox4.Text.Length > 1)
            {
                if (KeyToDec != null && KeyToDec.Contains(textBox4.Text.Replace(KeyToDec, "")))
                {
                    textBox4.Text = KeyToDec;
                }
            }
            KeyToDec = textBox4.Text;
            textBox4.SelectionStart = textBox4.Text.Length;
            textBox4.SelectionLength = 0;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string alph = alphabet + " ";
            string replaceMe = ADFGXLang == "cs" ? "W" : "J";
            string withThis = ADFGXLang == "cs" ? "V" : "I";
            richTextBox1.Text = richTextBox1.Text.ToUpper();

            if (!IsInAlphabet(richTextBox1.Text, alph))
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1, 1);
            }

            OpenMessage = richTextBox1.Text;
            FormattedMessage = richTextBox7.Text = richTextBox1.Text
                                                               .Replace(" ", "XMEZERAX")
                                                               .Replace("1", "XJEDNAX")
                                                               .Replace("2", "XDVAX")
                                                               .Replace("3", "XTRIX")
                                                               .Replace("4", "XCTYRIX")
                                                               .Replace("5", "XPETX")
                                                               .Replace("6", "XSESTX")
                                                               .Replace("7", "XSEDMX")
                                                               .Replace("8", "XOSMX")
                                                               .Replace("9", "XDEVETX")
                                                               .Replace("0", "XNULAX")
                                                               .Replace(replaceMe, withThis);
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.SelectionLength = 0;
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string alph = alphabet.Replace("0123456789", "");
            textBox6.Text = textBox6.Text.ToUpper();

            if (!IsInAlphabet(textBox6.Text, alph))
            {
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1, 1);
            }

            if (textBox6.Text.Length > 1)
            {
                if (KeyToEnc != null && KeyToEnc.Contains(textBox6.Text.Replace(KeyToEnc, "")))
                {
                    textBox6.Text = KeyToEnc;
                }
            }

            KeyToEnc = textBox6.Text;
            textBox6.SelectionStart = textBox6.Text.Length;
            textBox6.SelectionLength = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (KeyToEnc != null && KeyToEnc.Length > 0 && FractionatedMessage != null & FractionatedMessage.Length > 0)
            {
                richTextBox10.Text = EncryptedMessage = Encrypt();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string alph = alphabet.Replace("0123456789", "");
            textBox5.Text = textBox5.Text.ToUpper();

            if (!IsInAlphabet(textBox5.Text, alph))
            {
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1, 1);
            }

            if (textBox5.Text.Length > 1)
            {
                if (KeyToDec != null && KeyToDec.Contains(textBox5.Text.Replace(KeyToDec, "")))
                {
                    textBox5.Text = KeyToDec;
                }
            }
            KeyToDec = textBox5.Text;
            textBox5.SelectionStart = textBox5.Text.Length;
            textBox5.SelectionLength = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox9.Text = RedundantDecrypt();
        }
    }
}
