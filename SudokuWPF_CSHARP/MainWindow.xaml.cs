using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SudokuWPF_CSHARP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        private static Random rng = new Random();





        public MainWindow()
        {
            InitializeComponent();

            var textboxes = new List<TextBox>()
            {
                Box0,                      Box1,                      Box2,                      Box3,                      Box4,                      Box5,                      Box6,                      Box7,                      Box8,
                Box0_Copy,                 Box1_Copy,                 Box2_Copy,                 Box3_Copy,                 Box4_Copy,                 Box5_Copy,                 Box6_Copy,                 Box7_Copy,                 Box8_Copy,
                Box0_Copy1,                Box1_Copy1,                Box2_Copy1,                Box3_Copy1,                Box4_Copy1,                Box5_Copy1,                Box6_Copy1,                Box7_Copy1,                Box8_Copy1,
                Box0_Copy2,                Box1_Copy2,                Box2_Copy2,                Box3_Copy2,                Box4_Copy2,                Box5_Copy2,                Box6_Copy2,                Box7_Copy2,                Box8_Copy2,
                Box0_Copy3,                Box1_Copy3,                Box2_Copy3,                Box3_Copy3,                Box4_Copy3,                Box5_Copy3,                Box6_Copy3,                Box7_Copy3,                Box8_Copy3,
                Box0_Copy4,                Box1_Copy4,                Box2_Copy4,                Box3_Copy4,                Box4_Copy4,                Box5_Copy4,                Box6_Copy4,                Box7_Copy4,                Box8_Copy4,
                Box0_Copy5,                Box1_Copy5,                Box2_Copy5,                Box3_Copy5,                Box4_Copy5,                Box5_Copy5,                Box6_Copy5,                Box7_Copy5,                Box8_Copy5,
                Box0_Copy6,                Box1_Copy6,                Box2_Copy6,                Box3_Copy6,                Box4_Copy6,                Box5_Copy6,                Box6_Copy6,                Box7_Copy6,                Box8_Copy6,
                Box0_Copy7,                Box1_Copy7,                Box2_Copy7,                Box3_Copy7,                Box4_Copy7,                Box5_Copy7,                Box6_Copy7,                Box7_Copy7,                Box8_Copy7,
            };
            int i = 0;
            int j1 = 0;
            int j2 = 0;
            var numba = new List<int>(Enumerable.Range(1, 9));


            numba = numba.OrderBy(a => rng.Next()).ToList();

            foreach (var item in numba)
            {
                Debug.Write("simba " + item);
            }
            








               int[,] SudokuArray = new int[9, 9];




            i = 0;
            j1 = 0;
            while (j1 <= 2)
            {
                while (i <= 8)
                {
                    SudokuArray[(j1 + 3), i] = SudokuArray[j1, i] + 1;
                    if (SudokuArray[(j1 + 3), i] == 10)
                    {
                        SudokuArray[(j1 + 3), i] = 1;
                    }
                    //Debug.WriteLine(SudokuArray[(j1 + 3), i]);

                    SudokuArray[(j1 + 6), i] = SudokuArray[j1, i] + 2;
                    if (SudokuArray[(j1 + 6), i] == 10)
                    {
                        SudokuArray[(j1 + 6), i] = 1;
                    }
                    if (SudokuArray[(j1 + 6), i] == 11)
                    {
                        SudokuArray[(j1 + 6), i] = 2;
                    }

                    i++;
                }

                j1++;
                i = 0;

            }

            j1 = 0;
            j2 = 0;
            for (i = 0; i < (textboxes.Count); i++)
            {
                Debug.WriteLine("J2 Przed arrayowe: " + j2 + "AAAAA i to:" + i);
                textboxes[i].Text = SudokuArray[j1,j2].ToString();

                if(j2 == 8 && j1 <= 8)
                {
                    
                    Debug.WriteLine("Cylk j1: " + j1);
                    j1++;
                    j2 = 0;
                }
                else
                {
                    j2++;
                }

            }




            /*
            Debug.WriteLine("Drugie");

            foreach (var item in SudokuArray)
            {
                Debug.Write(" " + item);
            }*/




            //Box_0_0.Text = ((SudokuArray[0, 0]).ToString());
            /* for (i = 0; i < 9; i++)
             {
                 for (j1 = 0; j1 < 9; j1++)
                 {
                     textboxes[i, j1].Text = SudokuArray[i, j1].ToString();
                 }
             }*/



        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    
    }

