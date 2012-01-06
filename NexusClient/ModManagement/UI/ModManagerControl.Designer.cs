﻿namespace Nexus.Client.ModManagement.UI
{
	partial class ModManagerControl
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
			DoDispose();
			base.Dispose(disposing);
		}

		/// <summary>
		/// Allows extension of the dispose method.
		/// </summary>
		partial void DoDispose();

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModManagerControl));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbAddMod = new System.Windows.Forms.ToolStripSplitButton();
			this.addModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addModFromURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbActivate = new System.Windows.Forms.ToolStripButton();
			this.tsbDeactivate = new System.Windows.Forms.ToolStripButton();
			this.tsbDeleteMod = new System.Windows.Forms.ToolStripButton();
			this.tsbTagMod = new System.Windows.Forms.ToolStripButton();
			this.sptMods = new System.Windows.Forms.SplitContainer();
			this.lvwMods = new Nexus.Client.Controls.IconListView();
			this.clmModName = new System.Windows.Forms.ColumnHeader();
			this.clmVersion = new System.Windows.Forms.ColumnHeader();
			this.clmWebVersion = new System.Windows.Forms.ColumnHeader();
			this.clmAuthor = new System.Windows.Forms.ColumnHeader();
			this.sptSummaryInfo = new System.Windows.Forms.SplitContainer();
			this.ipbScreenShot = new Nexus.Client.Controls.ImagePreviewBox();
			this.flbInfo = new Nexus.Client.Controls.FormattedLabel();
			this.ofdChooseMod = new System.Windows.Forms.OpenFileDialog();
			this.toolStrip1.SuspendLayout();
			this.sptMods.Panel1.SuspendLayout();
			this.sptMods.Panel2.SuspendLayout();
			this.sptMods.SuspendLayout();
			this.sptSummaryInfo.Panel1.SuspendLayout();
			this.sptSummaryInfo.Panel2.SuspendLayout();
			this.sptSummaryInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ipbScreenShot)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddMod,
            this.tsbActivate,
            this.tsbDeactivate,
            this.tsbDeleteMod,
            this.tsbTagMod});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(49, 491);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbAddMod
			// 
			this.tsbAddMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbAddMod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addModToolStripMenuItem,
            this.addModFromURLToolStripMenuItem});
			this.tsbAddMod.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddMod.Image")));
			this.tsbAddMod.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbAddMod.Name = "tsbAddMod";
			this.tsbAddMod.Size = new System.Drawing.Size(46, 36);
			this.tsbAddMod.Text = "Add Mod";
			// 
			// addModToolStripMenuItem
			// 
			this.addModToolStripMenuItem.Image = global::Nexus.Client.Properties.Resources.add_mod;
			this.addModToolStripMenuItem.Name = "addModToolStripMenuItem";
			this.addModToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.addModToolStripMenuItem.Text = "Add Mod from File";
			this.addModToolStripMenuItem.Click += new System.EventHandler(this.addModToolStripMenuItem_Click);
			// 
			// addModFromURLToolStripMenuItem
			// 
			this.addModFromURLToolStripMenuItem.Image = global::Nexus.Client.Properties.Resources.add_mod_url;
			this.addModFromURLToolStripMenuItem.Name = "addModFromURLToolStripMenuItem";
			this.addModFromURLToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.addModFromURLToolStripMenuItem.Text = "Add Mod from URL";
			this.addModFromURLToolStripMenuItem.Click += new System.EventHandler(this.addModFromURLToolStripMenuItem_Click);
			// 
			// tsbActivate
			// 
			this.tsbActivate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbActivate.Image = global::Nexus.Client.Properties.Resources.activate_mod;
			this.tsbActivate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbActivate.Name = "tsbActivate";
			this.tsbActivate.Size = new System.Drawing.Size(46, 36);
			this.tsbActivate.Text = "toolStripButton1";
			// 
			// tsbDeactivate
			// 
			this.tsbDeactivate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbDeactivate.Image = global::Nexus.Client.Properties.Resources.deactivate_mod;
			this.tsbDeactivate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDeactivate.Name = "tsbDeactivate";
			this.tsbDeactivate.Size = new System.Drawing.Size(46, 36);
			this.tsbDeactivate.Text = "toolStripButton1";
			// 
			// tsbDeleteMod
			// 
			this.tsbDeleteMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbDeleteMod.Image = global::Nexus.Client.Properties.Resources.edit_delete_6;
			this.tsbDeleteMod.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbDeleteMod.Name = "tsbDeleteMod";
			this.tsbDeleteMod.Size = new System.Drawing.Size(46, 36);
			this.tsbDeleteMod.Text = "toolStripButton1";
			// 
			// tsbTagMod
			// 
			this.tsbTagMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbTagMod.Image = global::Nexus.Client.Properties.Resources.info_add;
			this.tsbTagMod.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbTagMod.Name = "tsbTagMod";
			this.tsbTagMod.Size = new System.Drawing.Size(46, 36);
			this.tsbTagMod.Text = "toolStripButton1";
			// 
			// sptMods
			// 
			this.sptMods.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sptMods.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.sptMods.Location = new System.Drawing.Point(49, 0);
			this.sptMods.Name = "sptMods";
			// 
			// sptMods.Panel1
			// 
			this.sptMods.Panel1.Controls.Add(this.lvwMods);
			// 
			// sptMods.Panel2
			// 
			this.sptMods.Panel2.Controls.Add(this.sptSummaryInfo);
			this.sptMods.Size = new System.Drawing.Size(624, 491);
			this.sptMods.SplitterDistance = 331;
			this.sptMods.TabIndex = 1;
			// 
			// lvwMods
			// 
			this.lvwMods.CheckBoxes = true;
			this.lvwMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmModName,
            this.clmVersion,
            this.clmWebVersion,
            this.clmAuthor});
			this.lvwMods.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvwMods.FullRowSelect = true;
			this.lvwMods.HideSelection = false;
			this.lvwMods.LabelEdit = true;
			this.lvwMods.Location = new System.Drawing.Point(0, 0);
			this.lvwMods.MultiSelect = false;
			this.lvwMods.Name = "lvwMods";
			this.lvwMods.OwnerDraw = true;
			this.lvwMods.ShowItemToolTips = true;
			this.lvwMods.Size = new System.Drawing.Size(331, 491);
			this.lvwMods.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvwMods.TabIndex = 0;
			this.lvwMods.UseCompatibleStateImageBehavior = false;
			this.lvwMods.View = System.Windows.Forms.View.Details;
			this.lvwMods.Resize += new System.EventHandler(this.lvwMods_Resize);
			this.lvwMods.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwMods_AfterLabelEdit);
			this.lvwMods.SelectedIndexChanged += new System.EventHandler(this.lvwMods_SelectedIndexChanged);
			this.lvwMods.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvwMods_MouseMove);
			this.lvwMods.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvwMods_MouseDown);
			this.lvwMods.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvwMods_ColumnWidthChanging);
			// 
			// clmModName
			// 
			this.clmModName.Text = "Name";
			// 
			// clmVersion
			// 
			this.clmVersion.Text = "Version";
			// 
			// clmWebVersion
			// 
			this.clmWebVersion.Text = "Latest Version";
			// 
			// clmAuthor
			// 
			this.clmAuthor.Text = "Author";
			// 
			// sptSummaryInfo
			// 
			this.sptSummaryInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sptSummaryInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.sptSummaryInfo.Location = new System.Drawing.Point(0, 0);
			this.sptSummaryInfo.Name = "sptSummaryInfo";
			this.sptSummaryInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sptSummaryInfo.Panel1
			// 
			this.sptSummaryInfo.Panel1.Controls.Add(this.ipbScreenShot);
			// 
			// sptSummaryInfo.Panel2
			// 
			this.sptSummaryInfo.Panel2.Controls.Add(this.flbInfo);
			this.sptSummaryInfo.Size = new System.Drawing.Size(289, 491);
			this.sptSummaryInfo.SplitterDistance = 142;
			this.sptSummaryInfo.TabIndex = 0;
			// 
			// ipbScreenShot
			// 
			this.ipbScreenShot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ipbScreenShot.Location = new System.Drawing.Point(0, 0);
			this.ipbScreenShot.Name = "ipbScreenShot";
			this.ipbScreenShot.Size = new System.Drawing.Size(289, 142);
			this.ipbScreenShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ipbScreenShot.TabIndex = 0;
			this.ipbScreenShot.TabStop = false;
			// 
			// flbInfo
			// 
			this.flbInfo.BackColor = System.Drawing.SystemColors.Control;
			this.flbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.flbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.flbInfo.Location = new System.Drawing.Point(0, 0);
			this.flbInfo.MinimumSize = new System.Drawing.Size(20, 20);
			this.flbInfo.Name = "flbInfo";
			this.flbInfo.Size = new System.Drawing.Size(289, 345);
			this.flbInfo.TabIndex = 0;
			this.flbInfo.Text = null;
			// 
			// ModManagerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.sptMods);
			this.Controls.Add(this.toolStrip1);
			this.Name = "ModManagerControl";
			this.Size = new System.Drawing.Size(673, 491);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.sptMods.Panel1.ResumeLayout(false);
			this.sptMods.Panel2.ResumeLayout(false);
			this.sptMods.ResumeLayout(false);
			this.sptSummaryInfo.Panel1.ResumeLayout(false);
			this.sptSummaryInfo.Panel2.ResumeLayout(false);
			this.sptSummaryInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ipbScreenShot)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.SplitContainer sptMods;
		private Nexus.Client.Controls.IconListView lvwMods;
		private System.Windows.Forms.SplitContainer sptSummaryInfo;
		private Nexus.Client.Controls.ImagePreviewBox ipbScreenShot;
		private Nexus.Client.Controls.FormattedLabel flbInfo;
		private System.Windows.Forms.ToolStripSplitButton tsbAddMod;
		private System.Windows.Forms.ToolStripMenuItem addModToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog ofdChooseMod;
		private System.Windows.Forms.ColumnHeader clmModName;
		private System.Windows.Forms.ColumnHeader clmVersion;
		private System.Windows.Forms.ColumnHeader clmWebVersion;
		private System.Windows.Forms.ColumnHeader clmAuthor;
		private System.Windows.Forms.ToolStripButton tsbActivate;
		private System.Windows.Forms.ToolStripButton tsbDeactivate;
		private System.Windows.Forms.ToolStripMenuItem addModFromURLToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton tsbDeleteMod;
		private System.Windows.Forms.ToolStripButton tsbTagMod;
	}
}
