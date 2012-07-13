﻿namespace CMcG.CodeAlignment.Options
{
    partial class ScreenGeneral
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
            this.components = new System.ComponentModel.Container();
            this.bindOptions = new System.Windows.Forms.BindingSource(this.components);
            this.btnClearMruList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // bindOptions
            // 
            this.bindOptions.DataSource = typeof(CMcG.CodeAlignment.Business.Options);
            // 
            // btnClearMruList
            // 
            this.btnClearMruList.Location = new System.Drawing.Point(3, 3);
            this.btnClearMruList.Name = "btnClearMruList";
            this.btnClearMruList.Size = new System.Drawing.Size(252, 41);
            this.btnClearMruList.TabIndex = 0;
            this.btnClearMruList.Text = "Clear most recently used alignment list";
            this.btnClearMruList.UseVisualStyleBackColor = true;
            this.btnClearMruList.Click += new System.EventHandler(this.ResetMruList);
            // 
            // ScreenGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClearMruList);
            this.Name = "ScreenGeneral";
            this.Size = new System.Drawing.Size(622, 317);
            ((System.ComponentModel.ISupportInitialize)(this.bindOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindOptions;
        private System.Windows.Forms.Button btnClearMruList;
    }
}