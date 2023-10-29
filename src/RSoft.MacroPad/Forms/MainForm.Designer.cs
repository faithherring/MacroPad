﻿namespace RSoft.MacroPad.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            BLL.Infrasturture.Physical.KeyboardLayout keyboardLayout1 = new BLL.Infrasturture.Physical.KeyboardLayout();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            groupBox1 = new System.Windows.Forms.GroupBox();
            keyboardVisual1 = new Controls.Visual.KeyboardVisual();
            groupBox3 = new System.Windows.Forms.GroupBox();
            keyboardFunction1 = new Controls.Compound.KeyboardFunction();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            lblCommStatus = new System.Windows.Forms.ToolStripStatusLabel();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            tsSend = new System.Windows.Forms.ToolStripMenuItem();
            tsLayout = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            splitContainer1.Location = new System.Drawing.Point(0, 35);
            splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2MinSize = 135;
            splitContainer1.Size = new System.Drawing.Size(1065, 916);
            splitContainer1.SplitterDistance = 467;
            splitContainer1.SplitterWidth = 9;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(keyboardVisual1);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(1065, 467);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Keyboard visual";
            // 
            // keyboardVisual1
            // 
            keyboardVisual1.Dock = System.Windows.Forms.DockStyle.Fill;
            keyboardVisual1.KeyboardLayout = null;
            keyboardVisual1.Layer = 1;
            keyboardVisual1.Location = new System.Drawing.Point(4, 19);
            keyboardVisual1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            keyboardVisual1.Name = "keyboardVisual1";
            keyboardVisual1.SelectedAction = BLL.Infrasturture.Model.InputAction.Key1;
            keyboardVisual1.Size = new System.Drawing.Size(1057, 445);
            keyboardVisual1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(keyboardFunction1);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox3.Location = new System.Drawing.Point(0, 0);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(1065, 440);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Key setup";
            // 
            // keyboardFunction1
            // 
            keyboardFunction1.Delay = (ushort)6000;
            keyboardFunction1.Dock = System.Windows.Forms.DockStyle.Fill;
            keyboardFunction1.Function = Model.SetFunction.KeySequence;
            keyboardLayout1.Controls = null;
            keyboardLayout1.LayerCount = 0;
            keyboardLayout1.LedModeCount = 3;
            keyboardLayout1.MaxCharacters = 5;
            keyboardLayout1.Name = null;
            keyboardLayout1.SupportsColor = false;
            keyboardLayout1.SupportsDelay = false;
            keyboardFunction1.KeyboardLayout = keyboardLayout1;
            keyboardFunction1.LedColor = BLL.Infrasturture.Model.LedColor.Random;
            keyboardFunction1.LedMode = BLL.Infrasturture.Model.LedMode.Mode0;
            keyboardFunction1.Location = new System.Drawing.Point(4, 19);
            keyboardFunction1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            keyboardFunction1.MediaKey = System.Windows.Forms.Keys.MediaNextTrack;
            keyboardFunction1.MouseButton = BLL.Infrasturture.Model.MouseButton.Left;
            keyboardFunction1.MouseModifier = BLL.Infrasturture.Model.Modifier.None;
            keyboardFunction1.Name = "keyboardFunction1";
            keyboardFunction1.Size = new System.Drawing.Size(1057, 418);
            keyboardFunction1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblStatus, lblCommStatus });
            statusStrip1.Location = new System.Drawing.Point(0, 956);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            statusStrip1.Size = new System.Drawing.Size(1065, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = false;
            lblStatus.BackColor = System.Drawing.Color.FromArgb(192, 192, 0);
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStatus.ForeColor = System.Drawing.Color.White;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(150, 17);
            lblStatus.Text = "N/A";
            // 
            // lblCommStatus
            // 
            lblCommStatus.Name = "lblCommStatus";
            lblCommStatus.Size = new System.Drawing.Size(16, 17);
            lblCommStatus.Text = "...";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsSend, tsLayout, toolStripSeparator1, tsAbout });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1065, 32);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsSend
            // 
            tsSend.AutoSize = false;
            tsSend.Image = Properties.Resources.send;
            tsSend.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsSend.Name = "tsSend";
            tsSend.Size = new System.Drawing.Size(28, 28);
            tsSend.Click += tsSend_Click;
            // 
            // tsLayout
            // 
            tsLayout.AutoSize = false;
            tsLayout.Image = Properties.Resources.layout;
            tsLayout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsLayout.Name = "tsLayout";
            tsLayout.Size = new System.Drawing.Size(28, 28);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsAbout
            // 
            tsAbout.AutoSize = false;
            tsAbout.Image = Properties.Resources.about;
            tsAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            tsAbout.Name = "tsAbout";
            tsAbout.Size = new System.Drawing.Size(28, 28);
            tsAbout.Click += tsAbout_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1065, 978);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(splitContainer1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new System.Drawing.Size(1047, 571);
            Name = "MainForm";
            Text = "Form1";
            Deactivate += StopRecording;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsSend;
        private System.Windows.Forms.ToolStripMenuItem tsLayout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private Controls.Visual.KeyboardVisual keyboardVisual1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controls.Compound.KeyboardFunction keyboardFunction1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lblCommStatus;
        private System.Windows.Forms.TextBox textBox1;
    }
}