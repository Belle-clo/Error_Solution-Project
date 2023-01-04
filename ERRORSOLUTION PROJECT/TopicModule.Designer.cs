namespace ERRORSOLUTION_PROJECT
{
    partial class TopicModule
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
            this.pTOPICMODULE = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddTopicModule = new System.Windows.Forms.Button();
            this.btnDeleteTopicModule = new System.Windows.Forms.Button();
            this.btnUpdateTopicModule = new System.Windows.Forms.Button();
            this.btnSelectTopicModule = new System.Windows.Forms.Button();
            this.dgvTopicModule = new System.Windows.Forms.DataGridView();
            this.cmbTopicID = new System.Windows.Forms.ComboBox();
            this.cmbModuleID = new System.Windows.Forms.ComboBox();
            this.lblTopicID = new System.Windows.Forms.Label();
            this.lblModuleID = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pTOPICMODULE.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicModule)).BeginInit();
            this.SuspendLayout();
            // 
            // pTOPICMODULE
            // 
            this.pTOPICMODULE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pTOPICMODULE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pTOPICMODULE.Controls.Add(this.label1);
            this.pTOPICMODULE.Location = new System.Drawing.Point(12, 12);
            this.pTOPICMODULE.Name = "pTOPICMODULE";
            this.pTOPICMODULE.Size = new System.Drawing.Size(776, 56);
            this.pTOPICMODULE.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(289, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOPICMODULE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSignOut);
            this.panel2.Controls.Add(this.btnAddTopicModule);
            this.panel2.Controls.Add(this.btnDeleteTopicModule);
            this.panel2.Controls.Add(this.btnUpdateTopicModule);
            this.panel2.Controls.Add(this.btnSelectTopicModule);
            this.panel2.Controls.Add(this.dgvTopicModule);
            this.panel2.Controls.Add(this.cmbTopicID);
            this.panel2.Controls.Add(this.cmbModuleID);
            this.panel2.Controls.Add(this.lblTopicID);
            this.panel2.Controls.Add(this.lblModuleID);
            this.panel2.Location = new System.Drawing.Point(12, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 203);
            this.panel2.TabIndex = 1;
            // 
            // btnAddTopicModule
            // 
            this.btnAddTopicModule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTopicModule.Location = new System.Drawing.Point(56, 111);
            this.btnAddTopicModule.Name = "btnAddTopicModule";
            this.btnAddTopicModule.Size = new System.Drawing.Size(75, 23);
            this.btnAddTopicModule.TabIndex = 9;
            this.btnAddTopicModule.Text = "Add";
            this.btnAddTopicModule.UseVisualStyleBackColor = true;
            this.btnAddTopicModule.Click += new System.EventHandler(this.btnAddTopicModule_Click);
            // 
            // btnDeleteTopicModule
            // 
            this.btnDeleteTopicModule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTopicModule.Location = new System.Drawing.Point(187, 145);
            this.btnDeleteTopicModule.Name = "btnDeleteTopicModule";
            this.btnDeleteTopicModule.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTopicModule.TabIndex = 8;
            this.btnDeleteTopicModule.Text = "Delete";
            this.btnDeleteTopicModule.UseVisualStyleBackColor = true;
            this.btnDeleteTopicModule.Click += new System.EventHandler(this.btnDeleteTopicModule_Click);
            // 
            // btnUpdateTopicModule
            // 
            this.btnUpdateTopicModule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTopicModule.Location = new System.Drawing.Point(51, 145);
            this.btnUpdateTopicModule.Name = "btnUpdateTopicModule";
            this.btnUpdateTopicModule.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTopicModule.TabIndex = 7;
            this.btnUpdateTopicModule.Text = "Update";
            this.btnUpdateTopicModule.UseVisualStyleBackColor = true;
            this.btnUpdateTopicModule.Click += new System.EventHandler(this.btnUpdateTopicModule_Click);
            // 
            // btnSelectTopicModule
            // 
            this.btnSelectTopicModule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTopicModule.Location = new System.Drawing.Point(187, 111);
            this.btnSelectTopicModule.Name = "btnSelectTopicModule";
            this.btnSelectTopicModule.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTopicModule.TabIndex = 6;
            this.btnSelectTopicModule.Text = "Select";
            this.btnSelectTopicModule.UseVisualStyleBackColor = true;
            this.btnSelectTopicModule.Click += new System.EventHandler(this.btnSelectTopicModule_Click);
            // 
            // dgvTopicModule
            // 
            this.dgvTopicModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopicModule.Location = new System.Drawing.Point(388, 18);
            this.dgvTopicModule.Name = "dgvTopicModule";
            this.dgvTopicModule.Size = new System.Drawing.Size(376, 150);
            this.dgvTopicModule.TabIndex = 4;
            this.dgvTopicModule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTopicModule_CellClick);
            // 
            // cmbTopicID
            // 
            this.cmbTopicID.FormattingEnabled = true;
            this.cmbTopicID.Location = new System.Drawing.Point(220, 60);
            this.cmbTopicID.Name = "cmbTopicID";
            this.cmbTopicID.Size = new System.Drawing.Size(162, 21);
            this.cmbTopicID.TabIndex = 3;
            // 
            // cmbModuleID
            // 
            this.cmbModuleID.FormattingEnabled = true;
            this.cmbModuleID.Location = new System.Drawing.Point(220, 18);
            this.cmbModuleID.Name = "cmbModuleID";
            this.cmbModuleID.Size = new System.Drawing.Size(162, 21);
            this.cmbModuleID.TabIndex = 2;
            // 
            // lblTopicID
            // 
            this.lblTopicID.AutoSize = true;
            this.lblTopicID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicID.Location = new System.Drawing.Point(48, 68);
            this.lblTopicID.Name = "lblTopicID";
            this.lblTopicID.Size = new System.Drawing.Size(66, 19);
            this.lblTopicID.TabIndex = 1;
            this.lblTopicID.Text = "TopicID";
            // 
            // lblModuleID
            // 
            this.lblModuleID.AutoSize = true;
            this.lblModuleID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleID.Location = new System.Drawing.Point(48, 26);
            this.lblModuleID.Name = "lblModuleID";
            this.lblModuleID.Size = new System.Drawing.Size(83, 19);
            this.lblModuleID.TabIndex = 0;
            this.lblModuleID.Text = "ModuleID";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.Location = new System.Drawing.Point(307, 145);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 10;
            this.btnSignOut.Text = "SignOut";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // TopicModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 289);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pTOPICMODULE);
            this.Name = "TopicModule";
            this.Text = "TopicModule";
            this.Load += new System.EventHandler(this.TopicModule_Load);
            this.pTOPICMODULE.ResumeLayout(false);
            this.pTOPICMODULE.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicModule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTOPICMODULE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTopicModule;
        private System.Windows.Forms.ComboBox cmbTopicID;
        private System.Windows.Forms.ComboBox cmbModuleID;
        private System.Windows.Forms.Label lblTopicID;
        private System.Windows.Forms.Label lblModuleID;
        private System.Windows.Forms.Button btnDeleteTopicModule;
        private System.Windows.Forms.Button btnUpdateTopicModule;
        private System.Windows.Forms.Button btnSelectTopicModule;
        private System.Windows.Forms.Button btnAddTopicModule;
        private System.Windows.Forms.Button btnSignOut;
    }
}