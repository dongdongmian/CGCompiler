﻿namespace bitzhuwei.CGCompiler.Winform
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pgbProcess = new System.Windows.Forms.ProgressBar();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.txtCodeFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.generatedCodeFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.codeGenerator = new System.ComponentModel.BackgroundWorker();
            this.txtSourceCode = new System.Windows.Forms.TextBox();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompilerName = new System.Windows.Forms.TextBox();
            this.cmbGrammarList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbProcess
            // 
            this.pgbProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbProcess.Location = new System.Drawing.Point(12, 394);
            this.pgbProcess.Name = "pgbProcess";
            this.pgbProcess.Size = new System.Drawing.Size(715, 21);
            this.pgbProcess.TabIndex = 19;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(425, 113);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(41, 12);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Text = "状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "生成代码存放的位置：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "代码命名空间：";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamespace.Location = new System.Drawing.Point(143, 65);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(503, 21);
            this.txtNamespace.TabIndex = 2;
            this.txtNamespace.Text = "bitzhuwei.Compiler";
            // 
            // txtCodeFolder
            // 
            this.txtCodeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodeFolder.Location = new System.Drawing.Point(143, 89);
            this.txtCodeFolder.Name = "txtCodeFolder";
            this.txtCodeFolder.Size = new System.Drawing.Size(503, 21);
            this.txtCodeFolder.TabIndex = 3;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFolder.Location = new System.Drawing.Point(652, 87);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseFolder.TabIndex = 8;
            this.btnBrowseFolder.Text = "浏览...";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(652, 421);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 21);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "开始！";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // generatedCodeFolderBrowser
            // 
            this.generatedCodeFolderBrowser.Description = "选择一个文件夹以存放即将生成的代码文件";
            // 
            // codeGenerator
            // 
            this.codeGenerator.WorkerReportsProgress = true;
            this.codeGenerator.WorkerSupportsCancellation = true;
            this.codeGenerator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.codeGenerator_DoWork);
            this.codeGenerator.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.codeGenerator_ProgressChanged);
            this.codeGenerator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.codeGenerator_RunWorkerCompleted);
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceCode.Location = new System.Drawing.Point(13, 128);
            this.txtSourceCode.Multiline = true;
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSourceCode.Size = new System.Drawing.Size(408, 260);
            this.txtSourceCode.TabIndex = 4;
            this.txtSourceCode.Text = resources.GetString("txtSourceCode.Text");
            // 
            // txtProcess
            // 
            this.txtProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcess.Location = new System.Drawing.Point(427, 128);
            this.txtProcess.Multiline = true;
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.ReadOnly = true;
            this.txtProcess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProcess.Size = new System.Drawing.Size(301, 260);
            this.txtProcess.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "文法：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "您的编译器名字：";
            // 
            // txtCompilerName
            // 
            this.txtCompilerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompilerName.Location = new System.Drawing.Point(143, 38);
            this.txtCompilerName.Name = "txtCompilerName";
            this.txtCompilerName.Size = new System.Drawing.Size(503, 21);
            this.txtCompilerName.TabIndex = 0;
            // 
            // cmbGrammarList
            // 
            this.cmbGrammarList.FormattingEnabled = true;
            this.cmbGrammarList.Location = new System.Drawing.Point(143, 12);
            this.cmbGrammarList.Name = "cmbGrammarList";
            this.cmbGrammarList.Size = new System.Drawing.Size(268, 20);
            this.cmbGrammarList.TabIndex = 1;
            this.cmbGrammarList.SelectedIndexChanged += new System.EventHandler(this.cmbGrammarList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "选择常用文法：";
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(428, 11);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 21);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "添加...";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(509, 11);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 21);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(590, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(10, 385);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(0, 12);
            this.lblTip.TabIndex = 21;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 454);
            this.Controls.Add(this.cmbGrammarList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pgbProcess);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.txtCodeFolder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSourceCode);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompilerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Context-free Grammar的编译器代码的生成器";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbProcess;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.TextBox txtCodeFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.FolderBrowserDialog generatedCodeFolderBrowser;
        private System.ComponentModel.BackgroundWorker codeGenerator;
        private System.Windows.Forms.TextBox txtSourceCode;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompilerName;
        private System.Windows.Forms.ComboBox cmbGrammarList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTip;
    }
}