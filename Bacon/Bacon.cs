using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Bacon
{
    public partial class Bacon : Form
    {

       
        string Mask_text_default = "Фрэнсис Бэкон — английский философ, историк, политический деятель, основоположник эмпиризма. В 1584 году в возрасте 23 лет был избран в парламент. С 1617 года лорд-хранитель печати, затем — лорд-канцлер; барон Веруламский и виконт Сент-Олбанский. В 1621 году привлечён к суду по обвинению во взяточничестве, осуждён и отстранён от всех должностей. В дальнейшем был помилован королём, но не вернулся на государственную службу и последние годы жизни посвятил научной и литературной работе.";
        string Mask_text;
        public Bacon()
        {
            Mask_text = Mask_text_default;
            InitializeComponent();

        }

        private void Code_Click(object sender, EventArgs e)
        {
               T_encoded.Text = Bacon_encode(T_decoded.Text.ToString());
        }
        private string Bacon_encode (string input)
    {
        input = input.ToLower();
            input=input.Trim();

        string s_out;
        s_out = "";
           char[] c_in=new char[input.Length];
            c_in = input.ToCharArray();
            int i = 0;
            foreach (char c in c_in)
            {
                if (c == 'a') s_out += "AAAAA";
                else if (c == 'b') s_out += "AAAAB";
                else if (c == 'c') s_out += "AAABA";
                else if (c == 'd') s_out += "AAABB";
                else if (c == 'e') s_out += "AABAA";
                else if (c == 'f') s_out += "AABAB";
                else if (c == 'g') s_out += "AABBA";
                else if (c == 'h') s_out += "AABBB";
                else if (c == 'i') s_out += "ABAAA";
                else if (c == 'j') s_out += "ABAAB";
                else if (c == 'k') s_out += "ABABA";
                else if (c == 'l') s_out += "ABABB";
                else if (c == 'm') s_out += "ABBAA";
                else if (c == 'n') s_out += "ABBAB";
                else if (c == 'o') s_out += "ABBBA";
                else if (c == 'p') s_out += "ABBBB";
                else if (c == 'q') s_out += "BAAAA";
                else if (c == 'r') s_out += "BAAAB";
                else if (c == 's') s_out += "BAABA";
                else if (c == 't') s_out += "BAABB";
                else if (c == 'u') s_out += "BABAA";
                else if (c == 'v') s_out += "BABAB";
                else if (c == 'w') s_out += "BABBA";
                else if (c == 'x') s_out += "BABBB";
                else if (c == 'y') s_out += "BBAAA";
                else if (c == 'z') s_out += "BBAAB";
                else if (c == ' ') s_out += "BBBBB";
                else if (c == ',') s_out += "BBBAB";
                else if (c == '.') s_out += "BBBAA";
                if (i % 5 == 0)
                    i++;
                    s_out += " "; 
            }
            return s_out;
    }
        private string Bacon_decode(string input)
        {
           string s_out = "Error";
            try
            {
                input = input.ToUpper();
                input = input.Trim();
                while (input.Contains(" "))
                {
                    input = input.Replace(" ", "");
                }
                s_out = "";
                string s = "";
                for (int i = 0; i < input.Length; i += 5)
                {
                    s = input.Substring(i, 5);
                    input.Remove(1, 5);
                    if (s == "AAAAA") s_out += "a";
                    else if (s == "AAAAB") s_out += "b";
                    else if (s == "AAABA") s_out += "c";
                    else if (s == "AAABB") s_out += "d";
                    else if (s == "AABAA") s_out += "e";
                    else if (s == "AABAB") s_out += "f";
                    else if (s == "AABBA") s_out += "g";
                    else if (s == "AABBB") s_out += "h";
                    else if (s == "ABAAA") s_out += "i";
                    else if (s == "ABAAB") s_out += "j";
                    else if (s == "ABABA") s_out += "k";
                    else if (s == "ABABB") s_out += "l";
                    else if (s == "ABBAA") s_out += "m";
                    else if (s == "ABBAB") s_out += "n";
                    else if (s == "ABBBA") s_out += "o";
                    else if (s == "ABBBB") s_out += "p";
                    else if (s == "BAAAA") s_out += "q";
                    else if (s == "BAAAB") s_out += "r";
                    else if (s == "BAABA") s_out += "s";
                    else if (s == "BAABB") s_out += "t";
                    else if (s == "BABAA") s_out += "u";
                    else if (s == "BABAB") s_out += "v";
                    else if (s == "BABBA") s_out += "w";
                    else if (s == "BABBB") s_out += "x";
                    else if (s == "BBAAA") s_out += "y";
                    else if (s == "BBAAB") s_out += "z";
                    else if (s == "BBBBB") s_out += " ";
                    else if (s == "BBBAB") s_out += ",";
                    else if (s == "BBBAA") s_out += ".";

                }
            }
            catch { }
                return s_out;           
        }        
        private void Decode_Click(object sender, EventArgs e)
        {
            T_decoded.Text = Bacon_decode(T_encoded.Text.ToString());

        }
        private string Mask_Encoding(string input, string text)
        {
            try
            {
                string dict = "abcdefghijklmnopqrstuvwxyzабвгджзийклмнопрстуфхцчшщэюя";
                dict += dict.ToUpper();
                text = text.ToLower();
                while (input.Contains(" "))
                {
                    input = input.Replace(" ", "");
                }
                int j = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    string s = "";
                    if (input[i] == 'B')
                    {
                        bool replaced = false;
                        while (replaced == false)
                        {
                            if (dict.Contains(text[j]))
                            {
                                s = text[j].ToString().ToUpper();
                                text = text.Remove(j, 1);
                                text = text.Insert(j, s);
                                j++;
                                replaced = true;
                            }
                            else
                                j++;
                        }
                    }
                    else
                    {
                        bool replaced = false;
                        while (replaced == false)
                        {
                            if (dict.Contains(text[j]))
                            {
                                j++;
                                replaced = true;
                            }
                            else
                                j++;
                        }
                    }
                    if (i == (input.Length - 1))
                        text = text.Substring(0, j);
                }
            }

            catch
            { 

            } 
            return text;
        }
        private string Mask_decoding(string text)
        {
            string output = "Error";
            try
            {
                
                output = "";
                string dictLow = "abcdefghijklmnopqrstuvwxyzабвгджзийклмнопрстуфхцчшщэюя";
                string dictUp = dictLow.ToUpper();

                int j = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (dictUp.Contains(text[i].ToString()))
                    {
                        output += "B";
                        j++;
                    }
                    if (dictLow.Contains(text[i].ToString()))
                    {
                        output += "A";
                        j++;
                    }
                    if (j % 5 == 0)
                        output += " ";
                }
            }
            catch 
            {
            }
                return output;
        }
       
                
        
        private void Mask_Click(object sender, EventArgs e)
        {

            T_Mask.Text = Mask_text;
            T_Mask.Text=Mask_Encoding(T_encoded.Text.ToString(),T_Mask.Text.ToString());
            
        }
        private void Demask_Click(object sender, EventArgs e)
        {
            T_encoded.Text=Mask_decoding(T_Mask.Text.ToString());
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Form a=new About_Form();
            a.Show();
        }

        

        private void расшифрованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_Decode h = new Help_Decode();
            h.Show();
        }

        private void шифрованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help_Encode h = new Help_Encode();
            h.Show();
        }

       

        private void T_Mask_TextChanged(object sender, EventArgs e)
        {
            Mask_text = T_Mask.Text.ToString();
        }

        private void восстановитьСтарыйТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
           T_Mask.Text= Mask_text = Mask_text_default;
        }

       

        
    }
    
}
