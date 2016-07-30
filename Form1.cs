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

namespace Main
{
    public partial class Form1 : Form
    {
        int[,] a;
        string dfs = "";
        bool[] chuaxet;
        int n_dfs;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbSoDinh.Text);            

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {                   
                    TextBox b = new TextBox();
                    b.Size = new Size(20, 20);
                    b.Location = new Point(i * 20, j * 20);
                    if (i == j)
                    {                        
                        if (i == 0 && j == 0)
                        {
                            b.Visible = false;
                        }
                        else
                        {
                            b.Text = "-1";
                            b.ReadOnly = true;
                            b.TextAlign = HorizontalAlignment.Center;
                        }
                    }
                    else 
                    {
                        if (i == 0 && j != 0)
                        {
                            b.Text = j.ToString();
                            b.BackColor = System.Drawing.Color.DarkSeaGreen;
                        }
                        else if (i != 0 && j == 0)
                        {
                            b.Text = i.ToString();
                            b.BackColor = System.Drawing.Color.DarkSeaGreen;
                        }
                        else
                        {
                            b.Text = "0";
                            b.TextAlign = HorizontalAlignment.Center;
                        }                       
                    }
                    pnGraph.Controls.Add(b);    
                }
            }
            
        }       

        //========================================================================

        public void DFS(int[,] matrix, int n_dfs, int v, bool[] chuaxet)
        {
            dfs += v.ToString() + " -> ";
            chuaxet[v] = false;
            for (int i = 0; i < n_dfs; i++)
            {
                if (matrix[v, i] == 1 && chuaxet[i] == true)
                {
                    DFS(matrix, n_dfs, i, chuaxet);
                }
            }
        }

        public void BFS(int[,] matrix, int n)
        {

        }

        public void Dijsktra(int[,] matrix, int n)
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                { 
                    
                }
            }
        }

        public void CayKhung(int[,] matrix, int n)
        {

        }

        //=======================================================================

        private void btnBFS_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCayKhung_Click(object sender, EventArgs e)
        {

        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {

        }

        private void btnDFS_Click(object sender, EventArgs e)
        {
            chuaxet = new bool[n_dfs];
            for (int i = 1; i < n_dfs; i++)
            {
                chuaxet[i] = true;
            }
            for (int i = 1; i < n_dfs; i++)
            {
                lbketqua.Text = "";
                if (chuaxet[i])
                {
                    DFS(a, n_dfs, i, chuaxet);
                    lbketqua.Text = dfs;
                }                
            }            
        }

        private void btnFile_Click(object sender, EventArgs e)
        {            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbFileName.Text = openFileDialog1.FileName;
                tbFileName.Text = File.ReadAllText(lbFileName.Text);
                
                String matrix = tbFileName.Text;

                int n = int.Parse(matrix[0].ToString());
                n_dfs = n + 1;
                int d1 = int.Parse(matrix[3].ToString());
                int d2 = int.Parse(matrix[5].ToString());
                int dem = 8;
                n = n + 1;
                a = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            a[i, j] = -1;
                            continue;
                        }
                        if (i == 0 && j != 0)
                        {
                            a[i, j] = j;
                        }
                        else if (i != 0 && j == 0)
                        {
                            a[i, j] = i;
                        }
                        else
                        {
                            a[i, j] = int.Parse(matrix[dem].ToString());
                            if (j == n - 1)
                            {
                                dem += 3;
                            }
                            else
                            {
                                dem += 2;
                            }
                        }   
                    }
                }
                //MessageBox.Show(a[2, 1].ToString());
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        TextBox b = new TextBox();
                        b.Size = new Size(20, 20);
                        b.Location = new Point(i * 20, j * 20);
                        if (i == j)
                        {
                            if (i == 0 && j == 0)
                            {
                                b.Visible = false;
                            }
                            else
                            {
                                b.Text = "0";
                                b.ReadOnly = true;
                                b.TextAlign = HorizontalAlignment.Center;
                            }
                        }
                        else
                        {
                            if (i == 0 && j != 0)
                            {
                                b.Text = j.ToString();
                                b.BackColor = System.Drawing.Color.DarkSeaGreen;
                            }
                            else if (i != 0 && j == 0)
                            {
                                b.Text = i.ToString();
                                b.BackColor = System.Drawing.Color.DarkSeaGreen;
                            }
                            else
                            {
                                b.Text = a[i, j].ToString();
                                b.TextAlign = HorizontalAlignment.Center;
                            }                            
                        }
                        pnGraph.Controls.Add(b);
                    }
                }
                //====================================
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, tbFileName.Text);
            }
        }      

        private void lbFileName_Click(object sender, EventArgs e)
        {

        }
    }
}
