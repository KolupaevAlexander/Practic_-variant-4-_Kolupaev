using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Вариант_4
{
    public partial class Form1 :Form
    {
        List<string [ ]> multiply = new List<string [ ]>( );
        public Form1 ()
        {
            InitializeComponent( );

            List<string[]> sets = new List<string[]>( );
            string path = "Sets.txt";
            try
            {
                if ( File.Exists(path) && File.ReadAllText(path).Length != 0 && File.ReadAllLines(path).Length==3)
                {
                    foreach ( string line in File.ReadAllLines(path) )
                        sets.Add(line.Split(new char [ ] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries));

                    multiply = (from first in sets [ 0 ]
                                from second in sets [ 1 ]
                                from third in sets [ 2 ]
                                select new [ ] { first, second, third }).ToList( );


                }
                else answer.Text = "Файл пуст";
            }
            catch
            {
                MessageBox.Show("Формат файла нарушен");
            }



        }

        private void AddNewLine_Click (object sender, EventArgs e)
        {
            var appendLine = new [ ] { Symbol.Text, number.Value.ToString( ), Line.Text };
            if ( Symbol.Text.Length == 1 && !multiply.Contains(appendLine))
            {
                multiply.Add(new [ ] { Symbol.Text, number.Value.ToString(),  Line.Text});
                ShowAns( );
            }
            else answer.Text = "Ошибка ввода";



        }
        private void ShowAns()
        {
            switch ( Options.SelectedIndex )
            {
                case 0:
                    answer.Text = "";
                    foreach ( var i in multiply.OrderBy(x => x [ 0 ]) )
                        answer.Text += '\n' + $"Буква = {i [ 0 ]}; Число = {i [ 1 ]}; Цвет = {i [ 2 ]}";
                    break;
                case 1:
                    answer.Text = "";
                    foreach ( var i in multiply.OrderBy(x => x [ 1 ]) )
                        answer.Text += '\n' + $"Число = {i [ 1 ]}; Буква = {i [ 0 ]}; Цвет = {i [ 2 ]}";
                    break;
                case 2:
                    answer.Text = "";
                    foreach ( var i in multiply.OrderBy(x => x [ 2 ]) )
                        answer.Text += '\n' + $"Цвет = {i [ 2 ]}; Буква = {i [ 0 ]}; Число = {i [ 1 ]}";
                    break;
                default:
                    break;
            }
        }
        private void Options_SelectedIndexChanged (object sender, EventArgs e)
        {
            ShowAns( );
        }
    }
}
