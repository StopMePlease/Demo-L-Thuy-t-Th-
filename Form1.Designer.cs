namespace Main
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.lbSoDinh = new System.Windows.Forms.Label();
            this.tbSoDinh = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.pnGraph = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.gbSolution = new System.Windows.Forms.GroupBox();
            this.btnDijkstra = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnCayKhung = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbFileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbketqua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.gbSolution.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(465, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 24);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbSoDinh
            // 
            this.lbSoDinh.AutoSize = true;
            this.lbSoDinh.Location = new System.Drawing.Point(27, 13);
            this.lbSoDinh.Name = "lbSoDinh";
            this.lbSoDinh.Size = new System.Drawing.Size(44, 13);
            this.lbSoDinh.TabIndex = 1;
            this.lbSoDinh.Text = "Số đỉnh";
            // 
            // tbSoDinh
            // 
            this.tbSoDinh.BackColor = System.Drawing.SystemColors.Info;
            this.tbSoDinh.Location = new System.Drawing.Point(89, 10);
            this.tbSoDinh.Name = "tbSoDinh";
            this.tbSoDinh.Size = new System.Drawing.Size(115, 20);
            this.tbSoDinh.TabIndex = 2;
            this.tbSoDinh.Text = "0";
            this.tbSoDinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(224, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(46, 22);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnGraph
            // 
            this.pnGraph.Location = new System.Drawing.Point(8, 19);
            this.pnGraph.Name = "pnGraph";
            this.pnGraph.Size = new System.Drawing.Size(233, 162);
            this.pnGraph.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnGraph);
            this.groupBox1.Location = new System.Drawing.Point(22, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 190);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lbketqua);
            this.gbResult.Location = new System.Drawing.Point(21, 232);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(248, 75);
            this.gbResult.TabIndex = 7;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // gbSolution
            // 
            this.gbSolution.Controls.Add(this.btnDijkstra);
            this.gbSolution.Controls.Add(this.btnBFS);
            this.gbSolution.Controls.Add(this.btnDFS);
            this.gbSolution.Controls.Add(this.btnCayKhung);
            this.gbSolution.Location = new System.Drawing.Point(285, 48);
            this.gbSolution.Name = "gbSolution";
            this.gbSolution.Size = new System.Drawing.Size(248, 89);
            this.gbSolution.TabIndex = 8;
            this.gbSolution.TabStop = false;
            this.gbSolution.Text = "Solution";
            // 
            // btnDijkstra
            // 
            this.btnDijkstra.Location = new System.Drawing.Point(153, 57);
            this.btnDijkstra.Name = "btnDijkstra";
            this.btnDijkstra.Size = new System.Drawing.Size(85, 23);
            this.btnDijkstra.TabIndex = 3;
            this.btnDijkstra.Text = "Dijkstra";
            this.btnDijkstra.UseVisualStyleBackColor = true;
            this.btnDijkstra.Click += new System.EventHandler(this.btnDijkstra_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(153, 18);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(86, 23);
            this.btnBFS.TabIndex = 2;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.Location = new System.Drawing.Point(7, 57);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(86, 23);
            this.btnDFS.TabIndex = 1;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = true;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnCayKhung
            // 
            this.btnCayKhung.Location = new System.Drawing.Point(6, 19);
            this.btnCayKhung.Name = "btnCayKhung";
            this.btnCayKhung.Size = new System.Drawing.Size(87, 22);
            this.btnCayKhung.TabIndex = 0;
            this.btnCayKhung.Text = "Cây Khung";
            this.btnCayKhung.UseVisualStyleBackColor = true;
            this.btnCayKhung.Click += new System.EventHandler(this.btnCayKhung_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(292, 9);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(73, 23);
            this.btnFile.TabIndex = 9;
            this.btnFile.Text = "Upload File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(27, 310);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(54, 13);
            this.lbFileName.TabIndex = 11;
            this.lbFileName.Text = "File Name";
            this.lbFileName.Click += new System.EventHandler(this.lbFileName_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(285, 151);
            this.tbFileName.Multiline = true;
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbFileName.Size = new System.Drawing.Size(248, 158);
            this.tbFileName.TabIndex = 12;
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.Location = new System.Drawing.Point(28, 21);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(0, 13);
            this.lbketqua.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 327);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.gbSolution);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbSoDinh);
            this.Controls.Add(this.lbSoDinh);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Lý thuyết đồ thị";
            this.groupBox1.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.gbSolution.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbSoDinh;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.TextBox tbSoDinh;
        private System.Windows.Forms.Panel pnGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.GroupBox gbSolution;
        private System.Windows.Forms.Button btnDijkstra;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnCayKhung;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lbketqua;
    }
}

