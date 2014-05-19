﻿namespace MRP_GUI
{
    partial class frmBatchMaterial
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.objSourceItem = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMaterialPacking = new System.Windows.Forms.DataGridView();
            this.objSourceItemPacking = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormulaQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cReceivedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialPacking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceItemPacking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.FormulaQty,
            this.ReceivedQty,
            this.Unit});
            this.dgvItems.Location = new System.Drawing.Point(10, 35);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(501, 468);
            this.dgvItems.TabIndex = 0;
            // 
            // dgvMaterialPacking
            // 
            this.dgvMaterialPacking.AllowUserToAddRows = false;
            this.dgvMaterialPacking.AllowUserToDeleteRows = false;
            this.dgvMaterialPacking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialPacking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaterial,
            this.MaterialName,
            this.cReceivedQty,
            this.Unit_});
            this.dgvMaterialPacking.Location = new System.Drawing.Point(518, 35);
            this.dgvMaterialPacking.Name = "dgvMaterialPacking";
            this.dgvMaterialPacking.ReadOnly = true;
            this.dgvMaterialPacking.Size = new System.Drawing.Size(461, 467);
            this.dgvMaterialPacking.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raw Material and Semi Product List for the Batch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Packing Material Taken into the Batch";
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // FormulaQty
            // 
            this.FormulaQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormulaQty.DataPropertyName = "Qty";
            this.FormulaQty.FillWeight = 50F;
            this.FormulaQty.HeaderText = "FormulaQty";
            this.FormulaQty.Name = "FormulaQty";
            this.FormulaQty.ReadOnly = true;
            // 
            // ReceivedQty
            // 
            this.ReceivedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReceivedQty.DataPropertyName = "IssuedQty";
            this.ReceivedQty.FillWeight = 50F;
            this.ReceivedQty.HeaderText = "ReceivedQty";
            this.ReceivedQty.Name = "ReceivedQty";
            this.ReceivedQty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "Unit";
            this.Unit.FillWeight = 30F;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // cMaterial
            // 
            this.cMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cMaterial.DataPropertyName = "Item";
            this.cMaterial.HeaderText = "Material";
            this.cMaterial.Name = "cMaterial";
            this.cMaterial.ReadOnly = true;
            this.cMaterial.Visible = false;
            // 
            // MaterialName
            // 
            this.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialName.DataPropertyName = "Item";
            this.MaterialName.FillWeight = 125F;
            this.MaterialName.HeaderText = "Material";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // cReceivedQty
            // 
            this.cReceivedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cReceivedQty.DataPropertyName = "UsedQty";
            this.cReceivedQty.FillWeight = 50F;
            this.cReceivedQty.HeaderText = "ReceivedQty";
            this.cReceivedQty.Name = "cReceivedQty";
            this.cReceivedQty.ReadOnly = true;
            // 
            // Unit_
            // 
            this.Unit_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit_.DataPropertyName = "Unit";
            this.Unit_.FillWeight = 30F;
            this.Unit_.HeaderText = "Unit";
            this.Unit_.Name = "Unit_";
            this.Unit_.ReadOnly = true;
            // 
            // frmBatchMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMaterialPacking);
            this.Controls.Add(this.dgvItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBatchMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Material";
            this.Load += new System.EventHandler(this.frmBatchMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialPacking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceItemPacking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource objSourceItem;
        private System.Windows.Forms.DataGridView dgvMaterialPacking;
        private System.Windows.Forms.BindingSource objSourceItemPacking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormulaQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cReceivedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_;
    }
}