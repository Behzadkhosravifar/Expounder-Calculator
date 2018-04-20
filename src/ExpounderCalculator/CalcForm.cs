/*                                                      
                                                         Expounder Calculator
                                            This Program Created by Mr. Behzad Khosravifar
                                             Created Date : 1388/8/01 --- 23 oct(10) 2009
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExpounderCalculator
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }
        
        public static Boolean AllEventResult = true; // give information for what opened the AllEvent Form or SavedEvent Form
        public static string AllEvent = string.Empty; // Send All Event information to Form EventViewer by it
        public int indexOfFirstWord;
        public char FirstWordCH = ' '; // if the FirstWord not save in VarName, before save , copy in FirstWordCH
        public char[] ReadCh;
        public static char[] VarName;
        public static float[] VarValue;
        public static int indexOfVar = 0;
        public string AlphaEN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public char[] BigEn;
        public char[] AlphaNUM = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
        public char[] AlphaPRAGMATIC = { '+', '-', '/', '*' };
        public bool FirstWord = false; // if First Character's Of the Last Line was a Word (Example: A) --> FirstWordTF = true
        public string strFinal = string.Empty; // The All Word or Number After the FirstWord or Equal '=' Fix & Copy to strFinal
        public int bafferIndexNegative = -1;
        private string[] bufferCoteishen; // for save answer of every line qoustion in between " "

        bool Tabkey = false;
        private void rtxtForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessExpounder();
            }
            else if (e.KeyCode == Keys.Tab)
                Tabkey = true;
        }

        private void ProcessExpounder()
        {
            strFinal = string.Empty;
            indexOfFirstWord = -1;
            FirstWord = false;
            bool ShownEqual = false;
            if (rtxtForm.Text == string.Empty)
                return;
            
            ReadCh = rtxtForm.Lines.Last().ToCharArray();
            for (int i = 0; i < ReadCh.Length; i++) 
            {
                if (ReadCh[i] == ' ') continue;
                else if(ReadCh[i] == '"')
                {
                   
                }
                else if (ReadCh[i] == '=')
                {
                    ShownEqual = true;
                    FirstEqual(i+1);
                    break;
                }
                else
                {
                    bool Find = false;
                    foreach (char match in BigEn)
                        if (ReadCh[i] == match)
                        {
                            Find = true;
                            if (FirstWord)
                            {
                                rtxtForm.AppendText("\nSyntax Error");
                                return;
                            }
                            else
                            {
                                FirstWord = true;
                                for (int j = 0; j < indexOfVar; j++) 
                                    if (VarName[j] == match)
                                    {
                                        indexOfFirstWord = j;
                                        break;
                                    }
                                if (indexOfFirstWord == -1)
                                {
                                    FirstWordCH = match;
                                    break;
                                }
                                break;
                            }
                        }
                    if (!Find)
                    {
                        rtxtForm.AppendText("\nSyntax Error");
                        return;
                    }
                }
            }
            if (!ShownEqual)
            {
                if (!FirstWord) return;
                else
                {
                    if (indexOfFirstWord == -1) rtxtForm.AppendText("\nNot Value");
                    else rtxtForm.AppendText("\n" + VarValue[indexOfFirstWord].ToString());
                }
            }
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            VarName = new char[26];
            VarValue = new float[26];
            for (int i = 0; i < 26; i++)
                VarValue[i] = 0;
            BigEn = AlphaEN.ToCharArray();
            rtxtForm.Focus();
            rtxtForm.Select();
        }

        public bool ForwardEqual = false;
        public bool FirstAfterEqual = false;
        public int Negativism = 1;
        private bool searchMulDiv(int index, char per , bool back)
        {
            if(back)
                for (int i = index - 1; i > 0; i--)
                {
                    if (ReadCh[i] == ' ') continue;
                    if (ReadCh[i] == per)
                    {
                        bafferIndexNegative = i;
                        return true;
                    }
                    else break;
                }
            else
                for (int i = index + 1; i < ReadCh.Length; i++)
                {
                    if (ReadCh[i] == ' ') continue;
                    if (ReadCh[i] == per)
                    {
                        bafferIndexNegative = i;
                        return true;
                    }
                    else break;
                }
            bafferIndexNegative = -1;
            return false;
        }
        private void FirstEqual(int index) // if First Character was '='
        {
            Negativism = 1;
            Loop:
            ForwardEqual = false;
            FirstAfterEqual = false;
            for (; index < ReadCh.Length; index++) 
            {
                if (ReadCh[index] == ' ') continue;
                else
                {
                    foreach(char en in BigEn) // Find Word Big EN in Forward continue of inFix
                        if (en == ReadCh[index])
                        {
                            for (int j = 0; j < indexOfVar; j++)
                                if (VarName[j] == en)
                                {
                                    if (VarValue[j] < 0)
                                    {
                                        if (searchMulDiv(index, '-', true)) // FOR example A=-1 , A=-A ==> A=1
                                        {
                                            // "A=-2"  --->  "=1--A" --->(Combine to) "=1+A"  ---> output "-1"
                                            if (searchMulDiv(bafferIndexNegative, '-', true))
                                                strFinal += ("0" + VarValue[j].ToString());
                                            else // "A=-2"  --->   "=1-A"   --->  output "3"
                                                strFinal += "0+" + (VarValue[j] * (-1)).ToString();

                                            ForwardEqual = true;
                                            break;
                                        }                                        
                                        else if (searchMulDiv(index, '*', true) || searchMulDiv(index, '/', true))
                                        {
                                            strFinal += (VarValue[j] * (-1)).ToString();
                                            Negativism *= (-1);
                                        }
                                        
                                        else
                                            strFinal += "0" + VarValue[j].ToString();
                                    }
                                    else
                                        strFinal += VarValue[j].ToString();
                                    ForwardEqual = true;
                                    break;
                                }
                            if (!ForwardEqual)
                            {
                                strFinal += "0";
                                ForwardEqual = true;
                            }
                            break;
                        }
                    if (ForwardEqual) break;
                    else // Find Number 0~9 in Forward continue of infix
                    {
                        bool FindNUM = false;
                        if (!FirstAfterEqual)
                            if (ReadCh[index] == '-')
                            {
                                if (searchMulDiv(index, '*', true) || searchMulDiv(index, '/', true))
                                {
                                    if (!(searchMulDiv(index, '-', false)))
                                        Negativism *= (-1);
                                    else
                                    {
                                        rtxtForm.AppendText("\nSyntax Error");
                                        return;
                                    }
                                }
                                else
                                    strFinal += "0-";

                                FirstAfterEqual = true;
                                continue;
                            }
                    ReadLoop:
                        foreach (char num in AlphaNUM)
                            if (num == ReadCh[index])
                            {
                                ForwardEqual = true;
                                FindNUM = true;
                                strFinal += num.ToString();
                                break;
                            }
                        if (index + 1 < ReadCh.Length)
                        {
                            if (FindNUM && ReadCh[index + 1] != ' ')
                            {
                                index++;
                                FindNUM = false;
                                goto ReadLoop;
                            }
                            else if (!FindNUM && ForwardEqual)
                                index--;
                        }
                        else if (!FindNUM && ForwardEqual)
                        {
                            index--;
                        }
                        break;
                    }
                }
            }
            if (!ForwardEqual) // because this location is end of loop or input sentenc  
            {
                rtxtForm.AppendText("\nSyntax Error");
                return;
            }
            else // Continue of Sentence (however sentence has Continue or not have Answer);
            {
                ForwardEqual = false; // for find end of the sentence
                for (index++;index < ReadCh.Length;index++) // if (input sentence has Continue)
                {
                    bool FindPer = false;
                    if (ReadCh[index] == ' ') continue;
                    else
                    {
                        foreach (char per in AlphaPRAGMATIC)
                            if (per == ReadCh[index])
                            {
                                ForwardEqual = true;
                                FindPer = true;
                                if (per == '-' && searchMulDiv(index, '-', false))
                                {
                                    if (searchMulDiv(bafferIndexNegative, '-', false))
                                    {
                                        rtxtForm.AppendText("\nSyntax Error");
                                        return;
                                    }
                                    else
                                    {
                                        strFinal += "+";
                                        index++;
                                    }
                                }
                                else
                                    strFinal += per.ToString();
                                break;
                            }
                        if (!FindPer)
                        {
                            rtxtForm.AppendText("\nSyntax Error");
                            return;
                        }
                        break;
                    }                    
                }
                if (ForwardEqual) // correct sentence (Example: A= 1 + ...) check other words in Sentence Forward's
                {
                    index++;
                    goto Loop;
                }
                else // if (end of input sentence) go to PostFix Algorithm 
                {
                    rtxtInformation.Text = string.Empty;
                    rtxtInformation.AppendText("result * " + Negativism);
                    AllEvent += "\nresult * " + Negativism;
                    rtxtInformation.AppendText("\nParse to InFix: " + strFinal);
                    AllEvent += "\nParse to InFix: " + strFinal;
                    PostFix PF = new PostFix();
                    string strPostfix;
                    PF.ConvertToPostfix(strFinal);
                    strPostfix = PF.StrPostfix;
                    rtxtInformation.AppendText("\nParse to PostFix: " + strPostfix);
                    AllEvent += "\nParse to PostFix: " + strPostfix;
                    EvaluatePostfix EPF = new EvaluatePostfix();
                    if (FirstWord)
                    {
                        if (indexOfFirstWord == -1)
                        {
                            VarName[indexOfVar] = FirstWordCH;
                            VarValue[indexOfVar] = ((float)(EPF.evaluate(strPostfix))) * Negativism;
                            rtxtInformation.AppendText("\n" + FirstWordCH + " = " + VarValue[indexOfVar]);
                            AllEvent += "\n" + FirstWordCH + " = " + VarValue[indexOfVar];
                            indexOfVar++;
                            FirstWordCH = ' ';
                        }
                        else
                        {
                            VarValue[indexOfFirstWord] = ((float)(EPF.evaluate(strPostfix))) * Negativism;
                            rtxtInformation.AppendText("\n" + VarName[indexOfFirstWord].ToString() + " = " + VarValue[indexOfFirstWord]);
                            AllEvent += "\n" + VarName[indexOfFirstWord].ToString() + " = " + VarValue[indexOfFirstWord];
                            FirstWordCH = ' ';
                            indexOfFirstWord = -1;
                        }
                    }
                    else
                    {
                        rtxtForm.AppendText("\n" + (((float)(EPF.evaluate(strPostfix))) * Negativism).ToString());
                        AllEvent += "\n" + EPF.evaluate(strPostfix);
                    }
                    AllEvent += "\n-------------------------------";
                }
            }
        }

        private void rtxtForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tabkey)
            {
                e.Handled = true;
                Tabkey = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            rtxtForm.Clear();
            for (int i = 0; i < indexOfVar; i++)
            {
                VarName[i] = ' ';
                VarValue[i] = 0;
            }
            indexOfVar = 0;
            indexOfFirstWord = -1;
            strFinal = string.Empty;
            FirstWord = false;
            FirstWordCH = ' ';
            ReadCh = string.Empty.ToCharArray();
            rtxtInformation.Text = "New Document Created...";
            AllEvent = string.Empty;
            bafferIndexNegative = -1;
            rtxtForm.Select();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ProcessExpounder();
            rtxtForm.AppendText("\n");
            rtxtForm.Focus();
            rtxtForm.Select();
        }

        private void btnShowEvent_Click(object sender, EventArgs e)
        {
            AnswerEventView minForm = new AnswerEventView();
            minForm.ShowDialog();
            EventViewer MaxForm = new EventViewer();
            MaxForm.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About AboutF = new About();
            AboutF.ShowDialog();
        }
    }
}
