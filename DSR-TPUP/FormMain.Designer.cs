﻿namespace DSR_TPUP
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblGameDir;
            System.Windows.Forms.Label lblUnpackDir;
            System.Windows.Forms.Label lblRepackDir;
            System.Windows.Forms.Label lblConvertFormat;
            System.Windows.Forms.Label lblConvertFile;
            System.Windows.Forms.Label lblThreads;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtGameDir = new System.Windows.Forms.TextBox();
            this.tmrCheckThread = new System.Windows.Forms.Timer(this.components);
            this.tclMain = new System.Windows.Forms.TabControl();
            this.tpgUnpack = new System.Windows.Forms.TabPage();
            this.btnUnpackExplore = new System.Windows.Forms.Button();
            this.btnUnpack = new System.Windows.Forms.Button();
            this.btnUnpackBrowse = new System.Windows.Forms.Button();
            this.txtUnpackDir = new System.Windows.Forms.TextBox();
            this.tpgRepack = new System.Windows.Forms.TabPage();
            this.cbxPreserveConverted = new System.Windows.Forms.CheckBox();
            this.btnRepackExplore = new System.Windows.Forms.Button();
            this.btnRepack = new System.Windows.Forms.Button();
            this.btnRepackBrowse = new System.Windows.Forms.Button();
            this.txtRepackDir = new System.Windows.Forms.TextBox();
            this.tpgConvert = new System.Windows.Forms.TabPage();
            this.btnConvertExplore = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cmbConvertFormat = new System.Windows.Forms.ComboBox();
            this.btnConvertBrowse = new System.Windows.Forms.Button();
            this.txtConvertFile = new System.Windows.Forms.TextBox();
            this.btnGameBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGameExplore = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.llbUpdate = new System.Windows.Forms.LinkLabel();
            this.spcLogs = new System.Windows.Forms.SplitContainer();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nudThreads = new System.Windows.Forms.NumericUpDown();
            this.lblProgress = new System.Windows.Forms.Label();
            lblGameDir = new System.Windows.Forms.Label();
            lblUnpackDir = new System.Windows.Forms.Label();
            lblRepackDir = new System.Windows.Forms.Label();
            lblConvertFormat = new System.Windows.Forms.Label();
            lblConvertFile = new System.Windows.Forms.Label();
            lblThreads = new System.Windows.Forms.Label();
            this.tclMain.SuspendLayout();
            this.tpgUnpack.SuspendLayout();
            this.tpgRepack.SuspendLayout();
            this.tpgConvert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLogs)).BeginInit();
            this.spcLogs.Panel1.SuspendLayout();
            this.spcLogs.Panel2.SuspendLayout();
            this.spcLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameDir
            // 
            lblGameDir.AutoSize = true;
            lblGameDir.Location = new System.Drawing.Point(22, 9);
            lblGameDir.Name = "lblGameDir";
            lblGameDir.Size = new System.Drawing.Size(80, 13);
            lblGameDir.TabIndex = 0;
            lblGameDir.Text = "Game Directory";
            // 
            // txtGameDir
            // 
            this.txtGameDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGameDir.Location = new System.Drawing.Point(22, 27);
            this.txtGameDir.Name = "txtGameDir";
            this.txtGameDir.Size = new System.Drawing.Size(546, 20);
            this.txtGameDir.TabIndex = 3;
            this.txtGameDir.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\DARK SOULS REMASTERED";
            // 
            // tmrCheckThread
            // 
            this.tmrCheckThread.Enabled = true;
            this.tmrCheckThread.Tick += new System.EventHandler(this.tmrCheckThread_Tick);
            // 
            // tclMain
            // 
            this.tclMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tclMain.Controls.Add(this.tpgUnpack);
            this.tclMain.Controls.Add(this.tpgRepack);
            this.tclMain.Controls.Add(this.tpgConvert);
            this.tclMain.Location = new System.Drawing.Point(12, 53);
            this.tclMain.Name = "tclMain";
            this.tclMain.SelectedIndex = 0;
            this.tclMain.Size = new System.Drawing.Size(728, 111);
            this.tclMain.TabIndex = 6;
            // 
            // tpgUnpack
            // 
            this.tpgUnpack.Controls.Add(this.btnUnpackExplore);
            this.tpgUnpack.Controls.Add(this.btnUnpack);
            this.tpgUnpack.Controls.Add(this.btnUnpackBrowse);
            this.tpgUnpack.Controls.Add(this.txtUnpackDir);
            this.tpgUnpack.Controls.Add(lblUnpackDir);
            this.tpgUnpack.Location = new System.Drawing.Point(4, 22);
            this.tpgUnpack.Name = "tpgUnpack";
            this.tpgUnpack.Padding = new System.Windows.Forms.Padding(3);
            this.tpgUnpack.Size = new System.Drawing.Size(720, 85);
            this.tpgUnpack.TabIndex = 0;
            this.tpgUnpack.Text = "Unpack";
            this.tpgUnpack.UseVisualStyleBackColor = true;
            // 
            // btnUnpackExplore
            // 
            this.btnUnpackExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpackExplore.Location = new System.Drawing.Point(639, 17);
            this.btnUnpackExplore.Name = "btnUnpackExplore";
            this.btnUnpackExplore.Size = new System.Drawing.Size(75, 23);
            this.btnUnpackExplore.TabIndex = 4;
            this.btnUnpackExplore.Text = "Explore";
            this.toolTip1.SetToolTip(this.btnUnpackExplore, "Open the output directory in Explorer");
            this.btnUnpackExplore.UseVisualStyleBackColor = true;
            this.btnUnpackExplore.Click += new System.EventHandler(this.btnUnpackExplore_Click);
            // 
            // btnUnpack
            // 
            this.btnUnpack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpack.Location = new System.Drawing.Point(558, 56);
            this.btnUnpack.Name = "btnUnpack";
            this.btnUnpack.Size = new System.Drawing.Size(75, 23);
            this.btnUnpack.TabIndex = 3;
            this.btnUnpack.Text = "Unpack";
            this.toolTip1.SetToolTip(this.btnUnpack, "Dump all of the game\'s textures to the specified directory");
            this.btnUnpack.UseVisualStyleBackColor = true;
            this.btnUnpack.Click += new System.EventHandler(this.btnUnpack_Click);
            // 
            // btnUnpackBrowse
            // 
            this.btnUnpackBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpackBrowse.Location = new System.Drawing.Point(558, 17);
            this.btnUnpackBrowse.Name = "btnUnpackBrowse";
            this.btnUnpackBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnUnpackBrowse.TabIndex = 2;
            this.btnUnpackBrowse.Text = "Browse";
            this.toolTip1.SetToolTip(this.btnUnpackBrowse, "Browse for your output directory");
            this.btnUnpackBrowse.UseVisualStyleBackColor = true;
            this.btnUnpackBrowse.Click += new System.EventHandler(this.btnUnpackBrowse_Click);
            // 
            // txtUnpackDir
            // 
            this.txtUnpackDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnpackDir.Location = new System.Drawing.Point(6, 19);
            this.txtUnpackDir.Name = "txtUnpackDir";
            this.txtUnpackDir.Size = new System.Drawing.Size(546, 20);
            this.txtUnpackDir.TabIndex = 1;
            this.txtUnpackDir.Text = "Texture Dump";
            // 
            // lblUnpackDir
            // 
            lblUnpackDir.AutoSize = true;
            lblUnpackDir.Location = new System.Drawing.Point(6, 3);
            lblUnpackDir.Name = "lblUnpackDir";
            lblUnpackDir.Size = new System.Drawing.Size(84, 13);
            lblUnpackDir.TabIndex = 0;
            lblUnpackDir.Text = "Output Directory";
            // 
            // tpgRepack
            // 
            this.tpgRepack.Controls.Add(this.cbxPreserveConverted);
            this.tpgRepack.Controls.Add(this.btnRepackExplore);
            this.tpgRepack.Controls.Add(this.btnRepack);
            this.tpgRepack.Controls.Add(this.btnRepackBrowse);
            this.tpgRepack.Controls.Add(this.txtRepackDir);
            this.tpgRepack.Controls.Add(lblRepackDir);
            this.tpgRepack.Location = new System.Drawing.Point(4, 22);
            this.tpgRepack.Name = "tpgRepack";
            this.tpgRepack.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRepack.Size = new System.Drawing.Size(720, 85);
            this.tpgRepack.TabIndex = 1;
            this.tpgRepack.Text = "Repack";
            this.tpgRepack.UseVisualStyleBackColor = true;
            // 
            // cbxPreserveConverted
            // 
            this.cbxPreserveConverted.AutoSize = true;
            this.cbxPreserveConverted.Location = new System.Drawing.Point(6, 60);
            this.cbxPreserveConverted.Name = "cbxPreserveConverted";
            this.cbxPreserveConverted.Size = new System.Drawing.Size(140, 17);
            this.cbxPreserveConverted.TabIndex = 9;
            this.cbxPreserveConverted.Text = "Preserve converted files";
            this.toolTip1.SetToolTip(this.cbxPreserveConverted, "Automatically converted textures will not be cleaned up afterwards");
            this.cbxPreserveConverted.UseVisualStyleBackColor = true;
            // 
            // btnRepackExplore
            // 
            this.btnRepackExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepackExplore.Location = new System.Drawing.Point(639, 17);
            this.btnRepackExplore.Name = "btnRepackExplore";
            this.btnRepackExplore.Size = new System.Drawing.Size(75, 23);
            this.btnRepackExplore.TabIndex = 8;
            this.btnRepackExplore.Text = "Explore";
            this.toolTip1.SetToolTip(this.btnRepackExplore, "Open the override directory in Explorer");
            this.btnRepackExplore.UseVisualStyleBackColor = true;
            this.btnRepackExplore.Click += new System.EventHandler(this.btnRepackExplore_Click);
            // 
            // btnRepack
            // 
            this.btnRepack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepack.Location = new System.Drawing.Point(558, 56);
            this.btnRepack.Name = "btnRepack";
            this.btnRepack.Size = new System.Drawing.Size(75, 23);
            this.btnRepack.TabIndex = 7;
            this.btnRepack.Text = "Repack";
            this.toolTip1.SetToolTip(this.btnRepack, "Repack any files with textures in the override directory");
            this.btnRepack.UseVisualStyleBackColor = true;
            this.btnRepack.Click += new System.EventHandler(this.btnRepack_Click);
            // 
            // btnRepackBrowse
            // 
            this.btnRepackBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRepackBrowse.Location = new System.Drawing.Point(558, 17);
            this.btnRepackBrowse.Name = "btnRepackBrowse";
            this.btnRepackBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnRepackBrowse.TabIndex = 6;
            this.btnRepackBrowse.Text = "Browse";
            this.toolTip1.SetToolTip(this.btnRepackBrowse, "Browse for your override directory");
            this.btnRepackBrowse.UseVisualStyleBackColor = true;
            this.btnRepackBrowse.Click += new System.EventHandler(this.btnRepackBrowse_Click);
            // 
            // txtRepackDir
            // 
            this.txtRepackDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRepackDir.Location = new System.Drawing.Point(6, 19);
            this.txtRepackDir.Name = "txtRepackDir";
            this.txtRepackDir.Size = new System.Drawing.Size(546, 20);
            this.txtRepackDir.TabIndex = 5;
            this.txtRepackDir.Text = "Texture Override";
            // 
            // lblRepackDir
            // 
            lblRepackDir.AutoSize = true;
            lblRepackDir.Location = new System.Drawing.Point(6, 3);
            lblRepackDir.Name = "lblRepackDir";
            lblRepackDir.Size = new System.Drawing.Size(92, 13);
            lblRepackDir.TabIndex = 4;
            lblRepackDir.Text = "Override Directory";
            // 
            // tpgConvert
            // 
            this.tpgConvert.Controls.Add(this.btnConvertExplore);
            this.tpgConvert.Controls.Add(this.btnConvert);
            this.tpgConvert.Controls.Add(this.cmbConvertFormat);
            this.tpgConvert.Controls.Add(lblConvertFormat);
            this.tpgConvert.Controls.Add(this.btnConvertBrowse);
            this.tpgConvert.Controls.Add(this.txtConvertFile);
            this.tpgConvert.Controls.Add(lblConvertFile);
            this.tpgConvert.Location = new System.Drawing.Point(4, 22);
            this.tpgConvert.Name = "tpgConvert";
            this.tpgConvert.Padding = new System.Windows.Forms.Padding(3);
            this.tpgConvert.Size = new System.Drawing.Size(720, 85);
            this.tpgConvert.TabIndex = 2;
            this.tpgConvert.Text = "Convert";
            this.tpgConvert.UseVisualStyleBackColor = true;
            // 
            // btnConvertExplore
            // 
            this.btnConvertExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertExplore.Location = new System.Drawing.Point(639, 17);
            this.btnConvertExplore.Name = "btnConvertExplore";
            this.btnConvertExplore.Size = new System.Drawing.Size(75, 23);
            this.btnConvertExplore.TabIndex = 13;
            this.btnConvertExplore.Text = "Explore";
            this.toolTip1.SetToolTip(this.btnConvertExplore, "Open the directory of the converted file in Explorer");
            this.btnConvertExplore.UseVisualStyleBackColor = true;
            this.btnConvertExplore.Click += new System.EventHandler(this.btnConvertExplore_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvert.Location = new System.Drawing.Point(558, 56);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Convert";
            this.toolTip1.SetToolTip(this.btnConvert, "Convert the specified file to the specified format");
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cmbConvertFormat
            // 
            this.cmbConvertFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbConvertFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConvertFormat.FormattingEnabled = true;
            this.cmbConvertFormat.Location = new System.Drawing.Point(6, 58);
            this.cmbConvertFormat.Name = "cmbConvertFormat";
            this.cmbConvertFormat.Size = new System.Drawing.Size(546, 21);
            this.cmbConvertFormat.TabIndex = 11;
            this.cmbConvertFormat.SelectedIndexChanged += new System.EventHandler(this.cmbConvertFormat_SelectedIndexChanged);
            // 
            // lblConvertFormat
            // 
            lblConvertFormat.AutoSize = true;
            lblConvertFormat.Location = new System.Drawing.Point(6, 42);
            lblConvertFormat.Name = "lblConvertFormat";
            lblConvertFormat.Size = new System.Drawing.Size(39, 13);
            lblConvertFormat.TabIndex = 10;
            lblConvertFormat.Text = "Format";
            // 
            // btnConvertBrowse
            // 
            this.btnConvertBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConvertBrowse.Location = new System.Drawing.Point(558, 17);
            this.btnConvertBrowse.Name = "btnConvertBrowse";
            this.btnConvertBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnConvertBrowse.TabIndex = 9;
            this.btnConvertBrowse.Text = "Browse";
            this.toolTip1.SetToolTip(this.btnConvertBrowse, "Browse for a file to convert");
            this.btnConvertBrowse.UseVisualStyleBackColor = true;
            this.btnConvertBrowse.Click += new System.EventHandler(this.btnConvertBrowse_Click);
            // 
            // txtConvertFile
            // 
            this.txtConvertFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConvertFile.Location = new System.Drawing.Point(6, 19);
            this.txtConvertFile.Name = "txtConvertFile";
            this.txtConvertFile.Size = new System.Drawing.Size(546, 20);
            this.txtConvertFile.TabIndex = 8;
            this.txtConvertFile.Text = "Texture Override";
            // 
            // lblConvertFile
            // 
            lblConvertFile.AutoSize = true;
            lblConvertFile.Location = new System.Drawing.Point(6, 3);
            lblConvertFile.Name = "lblConvertFile";
            lblConvertFile.Size = new System.Drawing.Size(63, 13);
            lblConvertFile.TabIndex = 7;
            lblConvertFile.Text = "Convert File";
            // 
            // btnGameBrowse
            // 
            this.btnGameBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGameBrowse.Location = new System.Drawing.Point(574, 25);
            this.btnGameBrowse.Name = "btnGameBrowse";
            this.btnGameBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnGameBrowse.TabIndex = 7;
            this.btnGameBrowse.Text = "Browse";
            this.toolTip1.SetToolTip(this.btnGameBrowse, "Browse for your game directory");
            this.btnGameBrowse.UseVisualStyleBackColor = true;
            this.btnGameBrowse.Click += new System.EventHandler(this.btnGameBrowse_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(655, 183);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 8;
            this.btnRestore.Text = "Restore";
            this.toolTip1.SetToolTip(this.btnRestore, "Restore all backups in the game directory");
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Location = new System.Drawing.Point(574, 183);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 9;
            this.btnAbort.Text = "Abort";
            this.toolTip1.SetToolTip(this.btnAbort, "Stop the current operation");
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnGameExplore
            // 
            this.btnGameExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGameExplore.Location = new System.Drawing.Point(655, 25);
            this.btnGameExplore.Name = "btnGameExplore";
            this.btnGameExplore.Size = new System.Drawing.Size(75, 23);
            this.btnGameExplore.TabIndex = 14;
            this.btnGameExplore.Text = "Explore";
            this.toolTip1.SetToolTip(this.btnGameExplore, "Open the game directory in Explorer");
            this.btnGameExplore.UseVisualStyleBackColor = true;
            this.btnGameExplore.Click += new System.EventHandler(this.btnGameExplore_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUpdate.Location = new System.Drawing.Point(277, 9);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(453, 13);
            this.lblUpdate.TabIndex = 10;
            this.lblUpdate.Text = "Checking for update...";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // llbUpdate
            // 
            this.llbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llbUpdate.Location = new System.Drawing.Point(280, 9);
            this.llbUpdate.Name = "llbUpdate";
            this.llbUpdate.Size = new System.Drawing.Size(450, 13);
            this.llbUpdate.TabIndex = 11;
            this.llbUpdate.TabStop = true;
            this.llbUpdate.Text = "New version available!";
            this.llbUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llbUpdate.Visible = false;
            this.llbUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbUpdate_LinkClicked);
            // 
            // spcLogs
            // 
            this.spcLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcLogs.Location = new System.Drawing.Point(12, 212);
            this.spcLogs.Name = "spcLogs";
            this.spcLogs.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcLogs.Panel1
            // 
            this.spcLogs.Panel1.Controls.Add(this.txtLog);
            // 
            // spcLogs.Panel2
            // 
            this.spcLogs.Panel2.Controls.Add(this.txtError);
            this.spcLogs.Size = new System.Drawing.Size(728, 310);
            this.spcLogs.SplitterDistance = 136;
            this.spcLogs.TabIndex = 12;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(728, 136);
            this.txtLog.TabIndex = 0;
            // 
            // txtError
            // 
            this.txtError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtError.Location = new System.Drawing.Point(0, 0);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtError.Size = new System.Drawing.Size(728, 170);
            this.txtError.TabIndex = 0;
            // 
            // pbrProgress
            // 
            this.pbrProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbrProgress.Location = new System.Drawing.Point(22, 183);
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(465, 23);
            this.pbrProgress.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images|*.dds;*.tga;*.png";
            this.openFileDialog1.Title = "Select an image to convert";
            // 
            // nudThreads
            // 
            this.nudThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudThreads.Location = new System.Drawing.Point(493, 183);
            this.nudThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreads.Name = "nudThreads";
            this.nudThreads.Size = new System.Drawing.Size(75, 20);
            this.nudThreads.TabIndex = 15;
            this.nudThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblThreads
            // 
            lblThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            lblThreads.AutoSize = true;
            lblThreads.Location = new System.Drawing.Point(490, 167);
            lblThreads.Name = "lblThreads";
            lblThreads.Size = new System.Drawing.Size(46, 13);
            lblThreads.TabIndex = 16;
            lblThreads.Text = "Threads";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(22, 167);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(48, 13);
            this.lblProgress.TabIndex = 17;
            this.lblProgress.Text = "Progress";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 534);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(lblThreads);
            this.Controls.Add(this.nudThreads);
            this.Controls.Add(this.btnGameExplore);
            this.Controls.Add(this.pbrProgress);
            this.Controls.Add(this.spcLogs);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnGameBrowse);
            this.Controls.Add(this.tclMain);
            this.Controls.Add(this.txtGameDir);
            this.Controls.Add(lblGameDir);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.llbUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormMain";
            this.Text = "DSR Texture Packer/Unpacker <version>";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tclMain.ResumeLayout(false);
            this.tpgUnpack.ResumeLayout(false);
            this.tpgUnpack.PerformLayout();
            this.tpgRepack.ResumeLayout(false);
            this.tpgRepack.PerformLayout();
            this.tpgConvert.ResumeLayout(false);
            this.tpgConvert.PerformLayout();
            this.spcLogs.Panel1.ResumeLayout(false);
            this.spcLogs.Panel1.PerformLayout();
            this.spcLogs.Panel2.ResumeLayout(false);
            this.spcLogs.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcLogs)).EndInit();
            this.spcLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.Timer tmrCheckThread;
        private System.Windows.Forms.TabControl tclMain;
        private System.Windows.Forms.TabPage tpgUnpack;
        private System.Windows.Forms.Button btnUnpack;
        private System.Windows.Forms.Button btnUnpackBrowse;
        private System.Windows.Forms.TextBox txtUnpackDir;
        private System.Windows.Forms.TabPage tpgRepack;
        private System.Windows.Forms.Button btnRepack;
        private System.Windows.Forms.Button btnRepackBrowse;
        private System.Windows.Forms.TextBox txtRepackDir;
        private System.Windows.Forms.Button btnGameBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.LinkLabel llbUpdate;
        private System.Windows.Forms.SplitContainer spcLogs;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.Button btnUnpackExplore;
        private System.Windows.Forms.Button btnRepackExplore;
        private System.Windows.Forms.Button btnGameExplore;
        private System.Windows.Forms.TabPage tpgConvert;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cmbConvertFormat;
        private System.Windows.Forms.Button btnConvertBrowse;
        private System.Windows.Forms.TextBox txtConvertFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnConvertExplore;
        private System.Windows.Forms.CheckBox cbxPreserveConverted;
        private System.Windows.Forms.NumericUpDown nudThreads;
        private System.Windows.Forms.Label lblProgress;
    }
}

