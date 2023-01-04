namespace ERRORSOLUTION_PROJECT
{
    partial class frmReport_ErrorSolution
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvErrorReports = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchErrorProg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvErrorProg = new System.Windows.Forms.DataGridView();
            this.btnErrorProg = new System.Windows.Forms.Button();
            this.txtSearchT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTopicError = new System.Windows.Forms.DataGridView();
            this.btnSearchTopicError = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorProg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(623, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search:";
            // 
            // dgvErrorReports
            // 
            this.dgvErrorReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorReports.Location = new System.Drawing.Point(78, 49);
            this.dgvErrorReports.Name = "dgvErrorReports";
            this.dgvErrorReports.Size = new System.Drawing.Size(623, 100);
            this.dgvErrorReports.TabIndex = 9;
            this.dgvErrorReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvErrorReports_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(713, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 58);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "ErrorSolution Details";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // txtSearchErrorProg
            // 
            this.txtSearchErrorProg.Location = new System.Drawing.Point(78, 171);
            this.txtSearchErrorProg.Name = "txtSearchErrorProg";
            this.txtSearchErrorProg.Size = new System.Drawing.Size(623, 20);
            this.txtSearchErrorProg.TabIndex = 20;
            this.txtSearchErrorProg.TextChanged += new System.EventHandler(this.txtSearchErrorProg_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Search:";
            // 
            // dgvErrorProg
            // 
            this.dgvErrorProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrorProg.Location = new System.Drawing.Point(78, 197);
            this.dgvErrorProg.Name = "dgvErrorProg";
            this.dgvErrorProg.Size = new System.Drawing.Size(623, 150);
            this.dgvErrorProg.TabIndex = 18;
            // 
            // btnErrorProg
            // 
            this.btnErrorProg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnErrorProg.Location = new System.Drawing.Point(707, 171);
            this.btnErrorProg.Name = "btnErrorProg";
            this.btnErrorProg.Size = new System.Drawing.Size(89, 35);
            this.btnErrorProg.TabIndex = 17;
            this.btnErrorProg.Text = "Error  ProgLan ";
            this.btnErrorProg.UseVisualStyleBackColor = true;
            this.btnErrorProg.Click += new System.EventHandler(this.btnErrorProg_Click);
            // 
            // txtSearchT
            // 
            this.txtSearchT.Location = new System.Drawing.Point(78, 367);
            this.txtSearchT.Name = "txtSearchT";
            this.txtSearchT.Size = new System.Drawing.Size(623, 20);
            this.txtSearchT.TabIndex = 24;
            this.txtSearchT.TextChanged += new System.EventHandler(this.tXTSearchT_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Search:";
            // 
            // dgvTopicError
            // 
            this.dgvTopicError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopicError.Location = new System.Drawing.Point(78, 393);
            this.dgvTopicError.Name = "dgvTopicError";
            this.dgvTopicError.Size = new System.Drawing.Size(623, 150);
            this.dgvTopicError.TabIndex = 22;
            // 
            // btnSearchTopicError
            // 
            this.btnSearchTopicError.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearchTopicError.Location = new System.Drawing.Point(710, 434);
            this.btnSearchTopicError.Name = "btnSearchTopicError";
            this.btnSearchTopicError.Size = new System.Drawing.Size(89, 35);
            this.btnSearchTopicError.TabIndex = 21;
            this.btnSearchTopicError.Text = "Topic Error";
            this.btnSearchTopicError.UseVisualStyleBackColor = true;
            this.btnSearchTopicError.Click += new System.EventHandler(this.btnSearchTopicError_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.Location = new System.Drawing.Point(707, 505);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 25;
            this.btnSignOut.Text = "SignOut";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // frmReport_ErrorSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(811, 566);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.txtSearchT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTopicError);
            this.Controls.Add(this.btnSearchTopicError);
            this.Controls.Add(this.txtSearchErrorProg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvErrorProg);
            this.Controls.Add(this.btnErrorProg);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvErrorReports);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmReport_ErrorSolution";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmReport_Error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorProg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvErrorReports;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchErrorProg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvErrorProg;
        private System.Windows.Forms.Button btnErrorProg;
        private System.Windows.Forms.TextBox txtSearchT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTopicError;
        private System.Windows.Forms.Button btnSearchTopicError;
        private System.Windows.Forms.Button btnSignOut;
    }
}