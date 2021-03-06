﻿namespace RCPA.Gui
{
  partial class ListViewField
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox = new System.Windows.Forms.GroupBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnLoad = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.lbFiles = new System.Windows.Forms.ListView();
      this.btnUp = new System.Windows.Forms.Button();
      this.btnDown = new System.Windows.Forms.Button();
      this.groupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox
      // 
      this.groupBox.Controls.Add(this.splitContainer1);
      this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox.Location = new System.Drawing.Point(0, 0);
      this.groupBox.Name = "groupBox";
      this.groupBox.Size = new System.Drawing.Size(807, 387);
      this.groupBox.TabIndex = 0;
      this.groupBox.TabStop = false;
      this.groupBox.Text = "Files";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(3, 17);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.lbFiles);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.btnDown);
      this.splitContainer1.Panel2.Controls.Add(this.btnUp);
      this.splitContainer1.Panel2.Controls.Add(this.btnSave);
      this.splitContainer1.Panel2.Controls.Add(this.btnLoad);
      this.splitContainer1.Panel2.Controls.Add(this.btnClear);
      this.splitContainer1.Panel2.Controls.Add(this.btnRemove);
      this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
      this.splitContainer1.Size = new System.Drawing.Size(801, 367);
      this.splitContainer1.SplitterDistance = 699;
      this.splitContainer1.TabIndex = 15;
      // 
      // btnSave
      // 
      this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnSave.Location = new System.Drawing.Point(0, 92);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(98, 23);
      this.btnSave.TabIndex = 19;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // btnLoad
      // 
      this.btnLoad.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnLoad.Location = new System.Drawing.Point(0, 69);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(98, 23);
      this.btnLoad.TabIndex = 18;
      this.btnLoad.Text = "Load";
      this.btnLoad.UseVisualStyleBackColor = true;
      // 
      // btnClear
      // 
      this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnClear.Location = new System.Drawing.Point(0, 46);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(98, 23);
      this.btnClear.TabIndex = 17;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      // 
      // btnRemove
      // 
      this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnRemove.Location = new System.Drawing.Point(0, 23);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(98, 23);
      this.btnRemove.TabIndex = 16;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      // 
      // btnAdd
      // 
      this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnAdd.Location = new System.Drawing.Point(0, 0);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(98, 23);
      this.btnAdd.TabIndex = 15;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      // 
      // lbFiles
      // 
      this.lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbFiles.Location = new System.Drawing.Point(0, 0);
      this.lbFiles.Name = "lbFiles";
      this.lbFiles.Size = new System.Drawing.Size(699, 367);
      this.lbFiles.TabIndex = 0;
      this.lbFiles.UseCompatibleStateImageBehavior = false;
      // 
      // btnUp
      // 
      this.btnUp.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnUp.Location = new System.Drawing.Point(0, 115);
      this.btnUp.Name = "btnUp";
      this.btnUp.Size = new System.Drawing.Size(98, 23);
      this.btnUp.TabIndex = 20;
      this.btnUp.Text = "Move Up";
      this.btnUp.UseVisualStyleBackColor = true;
      // 
      // btnDown
      // 
      this.btnDown.Dock = System.Windows.Forms.DockStyle.Top;
      this.btnDown.Location = new System.Drawing.Point(0, 138);
      this.btnDown.Name = "btnDown";
      this.btnDown.Size = new System.Drawing.Size(98, 23);
      this.btnDown.TabIndex = 21;
      this.btnDown.Text = "Move Down";
      this.btnDown.UseVisualStyleBackColor = true;
      // 
      // ListViewField
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.groupBox);
      this.Name = "ListViewField";
      this.Size = new System.Drawing.Size(807, 387);
      this.groupBox.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ListView lbFiles;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnLoad;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDown;
    private System.Windows.Forms.Button btnUp;
  }
}
