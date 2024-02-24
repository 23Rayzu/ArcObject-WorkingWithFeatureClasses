using System;

namespace WorkingWithFeatureClasses
{
    partial class frmFeatureClasses
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboLayers = new System.Windows.Forms.ComboBox();
            this.btnGetValues = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboFields = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Layers:";
            // 
            // cboLayers
            // 
            this.cboLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLayers.FormattingEnabled = true;
            this.cboLayers.Location = new System.Drawing.Point(113, 43);
            this.cboLayers.Name = "cboLayers";
            this.cboLayers.Size = new System.Drawing.Size(365, 24);
            this.cboLayers.TabIndex = 1;
            this.cboLayers.SelectedIndexChanged += new System.EventHandler(this.cboLayers_SelectedIndexChanged);
            // 
            // btnGetValues
            // 
            this.btnGetValues.Location = new System.Drawing.Point(113, 120);
            this.btnGetValues.Name = "btnGetValues";
            this.btnGetValues.Size = new System.Drawing.Size(106, 33);
            this.btnGetValues.TabIndex = 2;
            this.btnGetValues.Text = "Get Values";
            this.btnGetValues.UseVisualStyleBackColor = true;
            this.btnGetValues.Click += new System.EventHandler(this.btnGetValues_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(336, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboFields
            // 
            this.cboFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFields.FormattingEnabled = true;
            this.cboFields.Location = new System.Drawing.Point(113, 83);
            this.cboFields.Name = "cboFields";
            this.cboFields.Size = new System.Drawing.Size(365, 24);
            this.cboFields.TabIndex = 4;
            this.cboFields.SelectedIndexChanged += new System.EventHandler(this.cboFields_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fields:";
            // 
            // frmFeatureClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboFields);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGetValues);
            this.Controls.Add(this.cboLayers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFeatureClasses";
            this.Text = "Working With Feature Classes";
            this.Load += new System.EventHandler(this.frmFeatureClasses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cboFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGetValues_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLayers;
        private System.Windows.Forms.Button btnGetValues;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboFields;
        private System.Windows.Forms.Label label2;
    }
}