﻿using System;

namespace _3DScanning
{
    partial class Form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.minDepthLB = new System.Windows.Forms.Label();
            this.minDepthTB = new System.Windows.Forms.TrackBar();
            this.maxDepthLB = new System.Windows.Forms.Label();
            this.maxDepthTB = new System.Windows.Forms.TrackBar();
            this.interpolationLB = new System.Windows.Forms.Label();
            this.interpolationTB = new System.Windows.Forms.TrackBar();
            this.colorlessMeshRB = new System.Windows.Forms.RadioButton();
            this.coloredMeshRB = new System.Windows.Forms.RadioButton();
            this.previewBT = new System.Windows.Forms.Button();
            this.generateBT = new System.Windows.Forms.Button();
            this.statusLB = new System.Windows.Forms.Label();
            this.clearBT = new System.Windows.Forms.Button();
            this.generateAllCB = new System.Windows.Forms.CheckBox();
            this.dispersionCB = new System.Windows.Forms.CheckBox();
            this.minDepthValueLB = new System.Windows.Forms.Label();
            this.scaledMeshRB = new System.Windows.Forms.RadioButton();
            this.interpolationValueLB = new System.Windows.Forms.Label();
            this.maxDepthValueLB = new System.Windows.Forms.Label();
            this.viewport = new OpenTKLib.OGLControl();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPointCloud = new System.Windows.Forms.TabPage();
            this.tabDepthFrame = new System.Windows.Forms.TabPage();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.elementHost = new System.Windows.Forms.Integration.ElementHost();
            this.imageControl = new _3DScanning.ImageControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minDepthTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDepthTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interpolationTB)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPointCloud.SuspendLayout();
            this.tabDepthFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.progressBar, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.minDepthLB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.minDepthTB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.maxDepthLB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.maxDepthTB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.interpolationLB, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.interpolationTB, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.colorlessMeshRB, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.coloredMeshRB, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.previewBT, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.generateBT, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.statusLB, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.clearBT, 4, 10);
            this.tableLayoutPanel1.Controls.Add(this.generateAllCB, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dispersionCB, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.minDepthValueLB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.scaledMeshRB, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.interpolationValueLB, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.maxDepthValueLB, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 517);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar, 4);
            this.progressBar.Location = new System.Drawing.Point(44, 431);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(158, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // minDepthLB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.minDepthLB, 3);
            this.minDepthLB.Location = new System.Drawing.Point(3, 3);
            this.minDepthLB.Margin = new System.Windows.Forms.Padding(3);
            this.minDepthLB.Name = "minDepthLB";
            this.minDepthLB.Size = new System.Drawing.Size(117, 24);
            this.minDepthLB.TabIndex = 4;
            this.minDepthLB.Text = "Minimální hloubka:";
            this.minDepthLB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // minDepthTB
            // 
            this.minDepthTB.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.minDepthTB, 6);
            this.minDepthTB.LargeChange = 50;
            this.minDepthTB.Location = new System.Drawing.Point(3, 33);
            this.minDepthTB.Maximum = 8000;
            this.minDepthTB.Minimum = 500;
            this.minDepthTB.Name = "minDepthTB";
            this.minDepthTB.Size = new System.Drawing.Size(244, 24);
            this.minDepthTB.SmallChange = 10;
            this.minDepthTB.TabIndex = 8;
            this.minDepthTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.minDepthTB.Value = 500;
            // 
            // maxDepthLB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.maxDepthLB, 3);
            this.maxDepthLB.Location = new System.Drawing.Point(3, 63);
            this.maxDepthLB.Margin = new System.Windows.Forms.Padding(3);
            this.maxDepthLB.Name = "maxDepthLB";
            this.maxDepthLB.Size = new System.Drawing.Size(117, 24);
            this.maxDepthLB.TabIndex = 5;
            this.maxDepthLB.Text = "Maximální hloubka:";
            this.maxDepthLB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // maxDepthTB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.maxDepthTB, 6);
            this.maxDepthTB.LargeChange = 50;
            this.maxDepthTB.Location = new System.Drawing.Point(3, 93);
            this.maxDepthTB.Maximum = 8000;
            this.maxDepthTB.Minimum = 500;
            this.maxDepthTB.Name = "maxDepthTB";
            this.maxDepthTB.Size = new System.Drawing.Size(244, 24);
            this.maxDepthTB.SmallChange = 10;
            this.maxDepthTB.TabIndex = 9;
            this.maxDepthTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.maxDepthTB.Value = 500;
            // 
            // interpolationLB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.interpolationLB, 3);
            this.interpolationLB.Location = new System.Drawing.Point(3, 123);
            this.interpolationLB.Margin = new System.Windows.Forms.Padding(3);
            this.interpolationLB.Name = "interpolationLB";
            this.interpolationLB.Size = new System.Drawing.Size(117, 24);
            this.interpolationLB.TabIndex = 16;
            this.interpolationLB.Text = "Počet interpolací:";
            this.interpolationLB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // interpolationTB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.interpolationTB, 6);
            this.interpolationTB.LargeChange = 10;
            this.interpolationTB.Location = new System.Drawing.Point(3, 153);
            this.interpolationTB.Maximum = Utility.MAX_INTERPOLATION;
            this.interpolationTB.Minimum = 1;
            this.interpolationTB.Name = "interpolationTB";
            this.interpolationTB.Size = new System.Drawing.Size(244, 24);
            this.interpolationTB.TabIndex = 17;
            this.interpolationTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip.SetToolTip(this.interpolationTB, "Pokud posuvník ukazuje maximální hranici 2000 volte jeho hodnotu rozumně podle ve" +
        "likosti své RAM paměti. (500 interpolací = 5 GB)");
            this.interpolationTB.Value = 1;
            // 
            // colorlessMeshRB
            // 
            this.colorlessMeshRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorlessMeshRB.AutoSize = true;
            this.colorlessMeshRB.Checked = true;
            this.tableLayoutPanel1.SetColumnSpan(this.colorlessMeshRB, 2);
            this.colorlessMeshRB.Location = new System.Drawing.Point(3, 183);
            this.colorlessMeshRB.Name = "colorlessMeshRB";
            this.colorlessMeshRB.Size = new System.Drawing.Size(76, 34);
            this.colorlessMeshRB.TabIndex = 25;
            this.colorlessMeshRB.TabStop = true;
            this.colorlessMeshRB.Text = "Bezbarvý mesh";
            this.colorlessMeshRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorlessMeshRB.UseVisualStyleBackColor = true;
            // 
            // coloredMeshRB
            // 
            this.coloredMeshRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coloredMeshRB.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.coloredMeshRB, 2);
            this.coloredMeshRB.Location = new System.Drawing.Point(167, 183);
            this.coloredMeshRB.Name = "coloredMeshRB";
            this.coloredMeshRB.Size = new System.Drawing.Size(80, 34);
            this.coloredMeshRB.TabIndex = 23;
            this.coloredMeshRB.Text = "Barevný mesh";
            this.coloredMeshRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.coloredMeshRB.UseVisualStyleBackColor = true;
            // 
            // previewBT
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.previewBT, 2);
            this.previewBT.Location = new System.Drawing.Point(3, 460);
            this.previewBT.Name = "previewBT";
            this.previewBT.Size = new System.Drawing.Size(76, 34);
            this.previewBT.TabIndex = 0;
            this.previewBT.Text = "Náhled";
            this.previewBT.UseVisualStyleBackColor = true;
            this.previewBT.Click += new System.EventHandler(this.PreviewBT_Click);
            // 
            // generateBT
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.generateBT, 2);
            this.generateBT.Location = new System.Drawing.Point(85, 460);
            this.generateBT.Name = "generateBT";
            this.generateBT.Size = new System.Drawing.Size(76, 34);
            this.generateBT.TabIndex = 1;
            this.generateBT.Text = "Generovat mesh";
            this.generateBT.UseVisualStyleBackColor = true;
            this.generateBT.Click += new System.EventHandler(this.GenerateBT_Click);
            // 
            // statusLB
            // 
            this.statusLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLB.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.statusLB, 6);
            this.statusLB.Location = new System.Drawing.Point(3, 500);
            this.statusLB.Margin = new System.Windows.Forms.Padding(3);
            this.statusLB.Name = "statusLB";
            this.statusLB.Size = new System.Drawing.Size(244, 14);
            this.statusLB.TabIndex = 29;
            this.statusLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearBT
            // 
            this.clearBT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.clearBT, 2);
            this.clearBT.Location = new System.Drawing.Point(167, 460);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(80, 34);
            this.clearBT.TabIndex = 30;
            this.clearBT.Text = "Vymazat data";
            this.clearBT.UseVisualStyleBackColor = true;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // generateAllCB
            // 
            this.generateAllCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateAllCB.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.generateAllCB, 4);
            this.generateAllCB.Location = new System.Drawing.Point(3, 223);
            this.generateAllCB.Name = "generateAllCB";
            this.generateAllCB.Size = new System.Drawing.Size(158, 24);
            this.generateAllCB.TabIndex = 20;
            this.generateAllCB.Text = "Generovat všechny frame";
            this.generateAllCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generateAllCB.UseVisualStyleBackColor = true;
            // 
            // dispersionCB
            // 
            this.dispersionCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dispersionCB.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.dispersionCB, 4);
            this.dispersionCB.Location = new System.Drawing.Point(3, 253);
            this.dispersionCB.Name = "dispersionCB";
            this.dispersionCB.Size = new System.Drawing.Size(158, 24);
            this.dispersionCB.TabIndex = 28;
            this.dispersionCB.Text = "Generovat rozptyl";
            this.dispersionCB.UseVisualStyleBackColor = true;
            // 
            // minDepthValueLB
            // 
            this.minDepthValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minDepthValueLB.Location = new System.Drawing.Point(126, 3);
            this.minDepthValueLB.Margin = new System.Windows.Forms.Padding(3);
            this.minDepthValueLB.Name = "minDepthValueLB";
            this.minDepthValueLB.Size = new System.Drawing.Size(35, 24);
            this.minDepthValueLB.TabIndex = 12;
            this.minDepthValueLB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // scaledMeshRB
            // 
            this.scaledMeshRB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scaledMeshRB.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.scaledMeshRB, 2);
            this.scaledMeshRB.Location = new System.Drawing.Point(85, 183);
            this.scaledMeshRB.Name = "scaledMeshRB";
            this.scaledMeshRB.Size = new System.Drawing.Size(76, 34);
            this.scaledMeshRB.TabIndex = 22;
            this.scaledMeshRB.Text = "Škálovaný mesh";
            this.scaledMeshRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scaledMeshRB.UseVisualStyleBackColor = true;
            // 
            // interpolationValueLB
            // 
            this.interpolationValueLB.Location = new System.Drawing.Point(126, 123);
            this.interpolationValueLB.Margin = new System.Windows.Forms.Padding(3);
            this.interpolationValueLB.Name = "interpolationValueLB";
            this.interpolationValueLB.Size = new System.Drawing.Size(35, 24);
            this.interpolationValueLB.TabIndex = 27;
            this.interpolationValueLB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // maxDepthValueLB
            // 
            this.maxDepthValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxDepthValueLB.Location = new System.Drawing.Point(126, 63);
            this.maxDepthValueLB.Margin = new System.Windows.Forms.Padding(3);
            this.maxDepthValueLB.Name = "maxDepthValueLB";
            this.maxDepthValueLB.Size = new System.Drawing.Size(35, 24);
            this.maxDepthValueLB.TabIndex = 26;
            this.maxDepthValueLB.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // viewport
            // 
            this.viewport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.viewport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewport.Location = new System.Drawing.Point(3, 3);
            this.viewport.Name = "viewport";
            this.viewport.Size = new System.Drawing.Size(724, 485);
            this.viewport.TabIndex = 1;
            this.viewport.VSync = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPointCloud);
            this.tabControl.Controls.Add(this.tabDepthFrame);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(260, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(738, 517);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPointCloud
            // 
            this.tabPointCloud.Controls.Add(this.viewport);
            this.tabPointCloud.Location = new System.Drawing.Point(4, 22);
            this.tabPointCloud.Name = "tabPointCloud";
            this.tabPointCloud.Padding = new System.Windows.Forms.Padding(3);
            this.tabPointCloud.Size = new System.Drawing.Size(730, 491);
            this.tabPointCloud.TabIndex = 0;
            this.tabPointCloud.Text = "Point Cloud";
            this.tabPointCloud.UseVisualStyleBackColor = true;
            // 
            // tabDepthFrame
            // 
            this.tabDepthFrame.Controls.Add(this.elementHost);
            this.tabDepthFrame.Location = new System.Drawing.Point(4, 22);
            this.tabDepthFrame.Name = "tabDepthFrame";
            this.tabDepthFrame.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepthFrame.Size = new System.Drawing.Size(730, 491);
            this.tabDepthFrame.TabIndex = 1;
            this.tabDepthFrame.Text = "Depth Frame";
            this.tabDepthFrame.UseVisualStyleBackColor = true;
            // 
            // elementHost
            // 
            this.elementHost.BackColor = System.Drawing.Color.Black;
            this.elementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost.Location = new System.Drawing.Point(3, 3);
            this.elementHost.Name = "elementHost";
            this.elementHost.Size = new System.Drawing.Size(724, 485);
            this.elementHost.TabIndex = 0;
            this.elementHost.Text = "elementHost";
            this.elementHost.Child = this.imageControl;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "3D Scanning";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minDepthTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxDepthTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interpolationTB)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPointCloud.ResumeLayout(false);
            this.tabDepthFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button previewBT;
        private System.Windows.Forms.Button generateBT;
        private System.Windows.Forms.Label minDepthLB;
        private System.Windows.Forms.Label maxDepthLB;
        private System.Windows.Forms.TrackBar minDepthTB;
        private System.Windows.Forms.TrackBar maxDepthTB;
        private System.Windows.Forms.Label minDepthValueLB;
        private System.Windows.Forms.Label interpolationLB;
        private System.Windows.Forms.TrackBar interpolationTB;
        private System.Windows.Forms.CheckBox generateAllCB;
        private OpenTKLib.OGLControl viewport;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPointCloud;
        private System.Windows.Forms.TabPage tabDepthFrame;
        private System.Windows.Forms.Integration.ElementHost elementHost;
        private ImageControl imageControl;
        private System.Windows.Forms.RadioButton scaledMeshRB;
        private System.Windows.Forms.RadioButton coloredMeshRB;
        private System.Windows.Forms.RadioButton colorlessMeshRB;
        private System.Windows.Forms.Label maxDepthValueLB;
        private System.Windows.Forms.Label interpolationValueLB;
        private System.Windows.Forms.CheckBox dispersionCB;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Label statusLB;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

