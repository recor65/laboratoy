﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{

    public partial class Form1 : Form
    {
        int[] arr;
        public Form1()
        {
            var rand = new Random();
            InitializeComponent();
            arr = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arr[i] = rand.Next(0, 100);
                listBox1.Items.Add(arr[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void QuickSort(ref int[] Array, int Left, int Right) {
            int i = Left;
            int j = Right;
            int x = Array[(Left + Right) / 2];
            do
            {
                while (Array[i] < x)
                {
                    i++;
                }

                while (Array[j] > x)
                {
                    i--;
                }

                if (i <= j)
                {
                    int t = Array[i];
                    Array[i] = Array[j];
                    Array[j] = t;
                    i++;
                    j--;
                } while (i <= j)
                    ;
                if (Left < j)
                {
                    QuickSort(ref Array, Left, j);
                }
                if (i < Right)
                {
                    QuickSort(ref Array, i, Right);
                }
            } while (true);

    }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
