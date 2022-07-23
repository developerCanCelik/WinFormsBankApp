namespace WinFormsBankApp
{
    partial class Form2
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
            this.data_grid_view = new System.Windows.Forms.DataGridView();
            this.delete_money = new System.Windows.Forms.Button();
            this.add_money = new System.Windows.Forms.Button();
            this.txt_many = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANK APP";
            // 
            // data_grid_view
            // 
            this.data_grid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view.Location = new System.Drawing.Point(26, 55);
            this.data_grid_view.Name = "data_grid_view";
            this.data_grid_view.RowHeadersWidth = 51;
            this.data_grid_view.RowTemplate.Height = 29;
            this.data_grid_view.Size = new System.Drawing.Size(595, 59);
            this.data_grid_view.TabIndex = 2;
            // 
            // delete_money
            // 
            this.delete_money.Location = new System.Drawing.Point(32, 194);
            this.delete_money.Name = "delete_money";
            this.delete_money.Size = new System.Drawing.Size(190, 29);
            this.delete_money.TabIndex = 3;
            this.delete_money.Text = "PARA ÇEK";
            this.delete_money.UseVisualStyleBackColor = true;
            this.delete_money.Click += new System.EventHandler(this.delete_money_Click);
            // 
            // add_money
            // 
            this.add_money.Location = new System.Drawing.Point(32, 159);
            this.add_money.Name = "add_money";
            this.add_money.Size = new System.Drawing.Size(190, 29);
            this.add_money.TabIndex = 4;
            this.add_money.Text = "PARA YATIR";
            this.add_money.UseVisualStyleBackColor = true;
            this.add_money.Click += new System.EventHandler(this.add_money_Click);
            // 
            // txt_many
            // 
            this.txt_many.Location = new System.Drawing.Point(349, 179);
            this.txt_many.Name = "txt_many";
            this.txt_many.Size = new System.Drawing.Size(272, 27);
            this.txt_many.TabIndex = 5;
            this.txt_many.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_many_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "MİKTAR:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_many);
            this.Controls.Add(this.add_money);
            this.Controls.Add(this.delete_money);
            this.Controls.Add(this.data_grid_view);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView data_grid_view;
        private Button delete_money;
        private Button add_money;
        private TextBox txt_many;
        private Label label2;
    }
}