﻿/*
Copyright (c) 2011 Ben Barron

Permission is hereby granted, free of charge, to any person obtaining a copy 
of this software and associated documentation files (the "Software"), to deal 
in the Software without restriction, including without limitation the rights 
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
copies of the Software, and to permit persons to whom the Software is furnished 
to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all 
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION 
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

namespace PS3BluMote
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mitemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMappings = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lvButtons = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvKeys = new System.Windows.Forms.ListView();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDump = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtRepeatInterval = new System.Windows.Forms.TextBox();
            this.lblRepeatInterval = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.llblOpenFolder = new System.Windows.Forms.LinkLabel();
            this.cbDebugMode = new System.Windows.Forms.CheckBox();
            this.gbAdvanced = new System.Windows.Forms.GroupBox();
            this.comboBtAddr = new System.Windows.Forms.ComboBox();
            this.lblBtAddr = new System.Windows.Forms.Label();
            this.lblRemoteCodes = new System.Windows.Forms.Label();
            this.txtVendorId = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblVendorId = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.cbHibernation = new System.Windows.Forms.CheckBox();
            this.cbSms = new System.Windows.Forms.CheckBox();
            this.toolTipAdvanced = new System.Windows.Forms.ToolTip(this.components);
            this.menuNotifyIcon.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabMappings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.gbAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.menuNotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PS3BluMote: Disconnected.";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // menuNotifyIcon
            // 
            this.menuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemSettings,
            this.mitemExit});
            this.menuNotifyIcon.Name = "menuNotifyIcon";
            this.menuNotifyIcon.Size = new System.Drawing.Size(117, 48);
            // 
            // mitemSettings
            // 
            this.mitemSettings.Name = "mitemSettings";
            this.mitemSettings.Size = new System.Drawing.Size(116, 22);
            this.mitemSettings.Text = "Settings";
            this.mitemSettings.Click += new System.EventHandler(this.menuNotifyIcon_ItemClick);
            // 
            // mitemExit
            // 
            this.mitemExit.Name = "mitemExit";
            this.mitemExit.Size = new System.Drawing.Size(116, 22);
            this.mitemExit.Text = "Exit";
            this.mitemExit.Click += new System.EventHandler(this.menuNotifyIcon_ItemClick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMappings);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(6, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(721, 495);
            this.tabControl.TabIndex = 1;
            // 
            // tabMappings
            // 
            this.tabMappings.Controls.Add(this.splitContainer);
            this.tabMappings.Location = new System.Drawing.Point(4, 22);
            this.tabMappings.Name = "tabMappings";
            this.tabMappings.Padding = new System.Windows.Forms.Padding(3);
            this.tabMappings.Size = new System.Drawing.Size(713, 469);
            this.tabMappings.TabIndex = 0;
            this.tabMappings.Text = "Mappings";
            this.tabMappings.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.lvButtons);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lvKeys);
            this.splitContainer.Size = new System.Drawing.Size(707, 463);
            this.splitContainer.SplitterDistance = 391;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 2;
            // 
            // lvButtons
            // 
            this.lvButtons.CheckBoxes = true;
            this.lvButtons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lvButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvButtons.FullRowSelect = true;
            this.lvButtons.GridLines = true;
            this.lvButtons.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvButtons.HideSelection = false;
            this.lvButtons.Location = new System.Drawing.Point(0, 0);
            this.lvButtons.MultiSelect = false;
            this.lvButtons.Name = "lvButtons";
            this.lvButtons.ShowGroups = false;
            this.lvButtons.Size = new System.Drawing.Size(391, 463);
            this.lvButtons.TabIndex = 0;
            this.lvButtons.UseCompatibleStateImageBehavior = false;
            this.lvButtons.View = System.Windows.Forms.View.Details;
            this.lvButtons.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvButtons_ItemChecked);
            this.lvButtons.SelectedIndexChanged += new System.EventHandler(this.lvButtons_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Repeat";
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Remote button";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Keys assigned";
            this.columnHeader2.Width = 150;
            // 
            // lvKeys
            // 
            this.lvKeys.CheckBoxes = true;
            this.lvKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKeys.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvKeys.Location = new System.Drawing.Point(0, 0);
            this.lvKeys.MultiSelect = false;
            this.lvKeys.Name = "lvKeys";
            this.lvKeys.ShowGroups = false;
            this.lvKeys.Size = new System.Drawing.Size(310, 463);
            this.lvKeys.TabIndex = 1;
            this.lvKeys.UseCompatibleStateImageBehavior = false;
            this.lvKeys.View = System.Windows.Forms.View.List;
            this.lvKeys.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvKeys_ItemCheck);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.buttonDump);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Controls.Add(this.txtMinutes);
            this.tabSettings.Controls.Add(this.txtRepeatInterval);
            this.tabSettings.Controls.Add(this.lblRepeatInterval);
            this.tabSettings.Controls.Add(this.lblCopyright);
            this.tabSettings.Controls.Add(this.llblOpenFolder);
            this.tabSettings.Controls.Add(this.cbDebugMode);
            this.tabSettings.Controls.Add(this.gbAdvanced);
            this.tabSettings.Controls.Add(this.cbHibernation);
            this.tabSettings.Controls.Add(this.cbSms);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(10);
            this.tabSettings.Size = new System.Drawing.Size(713, 469);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hibernate the remote after";
            // 
            // buttonDump
            // 
            this.buttonDump.Location = new System.Drawing.Point(316, 79);
            this.buttonDump.Name = "buttonDump";
            this.buttonDump.Size = new System.Drawing.Size(75, 23);
            this.buttonDump.TabIndex = 11;
            this.buttonDump.Text = "Dump";
            this.buttonDump.UseVisualStyleBackColor = true;
            this.buttonDump.Visible = false;
            this.buttonDump.Click += new System.EventHandler(this.buttonDump_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "minutes without any key press.";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(166, 57);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(30, 20);
            this.txtMinutes.TabIndex = 9;
            this.txtMinutes.Text = "3";
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinutes.TextChanged += new System.EventHandler(this.txtMinutes_TextChanged);
            // 
            // txtRepeatInterval
            // 
            this.txtRepeatInterval.Location = new System.Drawing.Point(160, 128);
            this.txtRepeatInterval.Name = "txtRepeatInterval";
            this.txtRepeatInterval.Size = new System.Drawing.Size(95, 20);
            this.txtRepeatInterval.TabIndex = 7;
            this.txtRepeatInterval.Text = "500";
            this.txtRepeatInterval.Validating += new System.ComponentModel.CancelEventHandler(this.txtRepeatInterval_Validating);
            // 
            // lblRepeatInterval
            // 
            this.lblRepeatInterval.AutoSize = true;
            this.lblRepeatInterval.Location = new System.Drawing.Point(10, 131);
            this.lblRepeatInterval.Name = "lblRepeatInterval";
            this.lblRepeatInterval.Size = new System.Drawing.Size(144, 13);
            this.lblRepeatInterval.TabIndex = 6;
            this.lblRepeatInterval.Text = "Button repeat interval (in ms):";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(10, 420);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(149, 39);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "PS3BluMote v2.1.\r\nCopyright © Ben Barron 2012.\r\nHibernation by Miljbee";
            // 
            // llblOpenFolder
            // 
            this.llblOpenFolder.AutoSize = true;
            this.llblOpenFolder.Location = new System.Drawing.Point(190, 84);
            this.llblOpenFolder.Name = "llblOpenFolder";
            this.llblOpenFolder.Size = new System.Drawing.Size(120, 13);
            this.llblOpenFolder.TabIndex = 4;
            this.llblOpenFolder.TabStop = true;
            this.llblOpenFolder.Text = "Open log/settings folder";
            this.llblOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llblOpenFolder.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llblOpenFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblOpenFolder_LinkClicked);
            // 
            // cbDebugMode
            // 
            this.cbDebugMode.AutoSize = true;
            this.cbDebugMode.Location = new System.Drawing.Point(13, 83);
            this.cbDebugMode.Name = "cbDebugMode";
            this.cbDebugMode.Size = new System.Drawing.Size(171, 17);
            this.cbDebugMode.TabIndex = 3;
            this.cbDebugMode.Text = "Debug mode (logging enabled)";
            this.cbDebugMode.UseVisualStyleBackColor = true;
            this.cbDebugMode.CheckedChanged += new System.EventHandler(this.cbDebugMode_CheckedChanged);
            // 
            // gbAdvanced
            // 
            this.gbAdvanced.Controls.Add(this.comboBtAddr);
            this.gbAdvanced.Controls.Add(this.lblBtAddr);
            this.gbAdvanced.Controls.Add(this.lblRemoteCodes);
            this.gbAdvanced.Controls.Add(this.txtVendorId);
            this.gbAdvanced.Controls.Add(this.txtProductId);
            this.gbAdvanced.Controls.Add(this.lblVendorId);
            this.gbAdvanced.Controls.Add(this.lblProductId);
            this.gbAdvanced.Location = new System.Drawing.Point(9, 169);
            this.gbAdvanced.Name = "gbAdvanced";
            this.gbAdvanced.Padding = new System.Windows.Forms.Padding(6);
            this.gbAdvanced.Size = new System.Drawing.Size(258, 237);
            this.gbAdvanced.TabIndex = 2;
            this.gbAdvanced.TabStop = false;
            this.gbAdvanced.Text = "Advanced";
            this.toolTipAdvanced.SetToolTip(this.gbAdvanced, "For when using a remote OTHER THAN the official Sony PS3 Remote.");
            // 
            // comboBtAddr
            // 
            this.comboBtAddr.FormattingEnabled = true;
            this.comboBtAddr.Items.AddRange(new object[] {
            "Searching ..."});
            this.comboBtAddr.Location = new System.Drawing.Point(97, 79);
            this.comboBtAddr.Name = "comboBtAddr";
            this.comboBtAddr.Size = new System.Drawing.Size(121, 21);
            this.comboBtAddr.TabIndex = 13;
            this.comboBtAddr.Text = "Searching ...";
            this.comboBtAddr.SelectedIndexChanged += new System.EventHandler(this.comboBtAddr_SelectedIndexChanged);
            this.comboBtAddr.TextChanged += new System.EventHandler(this.comboBtAddr_TextChanged);
            // 
            // lblBtAddr
            // 
            this.lblBtAddr.AutoSize = true;
            this.lblBtAddr.Location = new System.Drawing.Point(9, 82);
            this.lblBtAddr.Name = "lblBtAddr";
            this.lblBtAddr.Size = new System.Drawing.Size(65, 13);
            this.lblBtAddr.TabIndex = 4;
            this.lblBtAddr.Text = "BT Address:";
            // 
            // lblRemoteCodes
            // 
            this.lblRemoteCodes.AutoSize = true;
            this.lblRemoteCodes.Location = new System.Drawing.Point(9, 127);
            this.lblRemoteCodes.Name = "lblRemoteCodes";
            this.lblRemoteCodes.Size = new System.Drawing.Size(239, 104);
            this.lblRemoteCodes.TabIndex = 3;
            this.lblRemoteCodes.Text = resources.GetString("lblRemoteCodes.Text");
            // 
            // txtVendorId
            // 
            this.txtVendorId.Location = new System.Drawing.Point(99, 51);
            this.txtVendorId.Name = "txtVendorId";
            this.txtVendorId.Size = new System.Drawing.Size(119, 20);
            this.txtVendorId.TabIndex = 3;
            this.txtVendorId.Text = "0x054c";
            this.txtVendorId.Validating += new System.ComponentModel.CancelEventHandler(this.txtVendorId_Validating);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(99, 22);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(119, 20);
            this.txtProductId.TabIndex = 2;
            this.txtProductId.Text = "0x0306";
            this.txtProductId.Validating += new System.ComponentModel.CancelEventHandler(this.txtProductId_Validating);
            // 
            // lblVendorId
            // 
            this.lblVendorId.AutoSize = true;
            this.lblVendorId.Location = new System.Drawing.Point(9, 54);
            this.lblVendorId.Name = "lblVendorId";
            this.lblVendorId.Size = new System.Drawing.Size(58, 13);
            this.lblVendorId.TabIndex = 1;
            this.lblVendorId.Text = "Vendor ID:";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(9, 25);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(61, 13);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "Product ID:";
            // 
            // cbHibernation
            // 
            this.cbHibernation.AutoSize = true;
            this.cbHibernation.Enabled = false;
            this.cbHibernation.Location = new System.Drawing.Point(13, 36);
            this.cbHibernation.Name = "cbHibernation";
            this.cbHibernation.Size = new System.Drawing.Size(175, 17);
            this.cbHibernation.TabIndex = 1;
            this.cbHibernation.Text = "Hibernation - to save battery life";
            this.cbHibernation.UseVisualStyleBackColor = true;
            this.cbHibernation.CheckedChanged += new System.EventHandler(this.cbHibernation_CheckedChanged);
            // 
            // cbSms
            // 
            this.cbSms.AutoSize = true;
            this.cbSms.Location = new System.Drawing.Point(13, 13);
            this.cbSms.Name = "cbSms";
            this.cbSms.Size = new System.Drawing.Size(95, 17);
            this.cbSms.TabIndex = 0;
            this.cbSms.Text = "SMS text input";
            this.cbSms.UseVisualStyleBackColor = true;
            this.cbSms.CheckedChanged += new System.EventHandler(this.cbSms_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 507);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "PS3BluMote configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.menuNotifyIcon.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabMappings.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.gbAdvanced.ResumeLayout(false);
            this.gbAdvanced.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip menuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem mitemSettings;
        private System.Windows.Forms.ToolStripMenuItem mitemExit;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMappings;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView lvButtons;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvKeys;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.GroupBox gbAdvanced;
        private System.Windows.Forms.TextBox txtVendorId;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblVendorId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.CheckBox cbHibernation;
        private System.Windows.Forms.CheckBox cbSms;
        private System.Windows.Forms.ToolTip toolTipAdvanced;
        private System.Windows.Forms.Label lblRemoteCodes;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox cbDebugMode;
        private System.Windows.Forms.LinkLabel llblOpenFolder;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.TextBox txtRepeatInterval;
        private System.Windows.Forms.Label lblRepeatInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Button buttonDump;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBtAddr;
        private System.Windows.Forms.ComboBox comboBtAddr;
    }
}