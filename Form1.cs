using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

using System.Drawing;

namespace RegexLearning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             

            LoadMemory();
            FormClosed += (s, e) => SaveMemory();
            MatchRegex();
            inputTextBox.TextChanged += (s, e) => MatchRegex();
            patternTextBox.TextChanged += (s, e) => MatchRegex();
            CheckVerbatim();
           

        }
        private void MatchRegex()
        {
            try
            {
                IsMatchResultLabel.Text = Regex.IsMatch(
                input: inputTextBox.Text,
                pattern: isVerbatim ?
                    $@"{patternTextBox.Text}" : patternTextBox.Text 
                ).ToString();
            }
            catch { }
        }
        private void LoadMemory()
        {
            if (File.Exists(MemPath))
            {
                using var stream = File.Open(MemPath, FileMode.Open);
                using var reader = new StreamReader(stream);
                var content = reader.ReadToEnd();
                var parts = content.Split((char)0x1C);
                inputTextBox.Text = parts[0];
                patternTextBox.Text = parts[1];
                isVerbatim = bool.Parse(parts[2]);
               
            }
          
        }
        private void SaveMemory()
        {
            using var stream = File.Open(MemPath, FileMode.Create); 
            using var writer = new StreamWriter(stream);
            writer.Write(inputTextBox.Text);
            writer.Write((char)0x1C);
            writer.Write(patternTextBox.Text);
            writer.Write((char)0x1C);
            writer.Write(isVerbatim);
        }

        private void verbatim_Click(object sender, EventArgs e)
        {
            isVerbatim = !isVerbatim;
            CheckVerbatim();
        }
        private void CheckVerbatim()
        {
            if (isVerbatim)
                verbatim.BackColor = Color.Red;
            else verbatim.BackColor = Color.Green;
        }
       
        private string MemPath = $"{Environment.CurrentDirectory}\\memory.txt";
        private bool isVerbatim;
        private bool onlyMatch => patternTextBox.Text.StartsWith('^');

        private void onlyMatchButton_Click(object sender, EventArgs e)
        {
            var text = patternTextBox.Text;
            if (!onlyMatch)
                patternTextBox.Text = $"^{text}$";
            else
                patternTextBox.Text = text.Substring(1).Substring(0, text.Length - 2);
        }
    }
}
