
namespace davaleba_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.saxelitxt = new System.Windows.Forms.TextBox();
            this.fasitxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.damatebabtn = new System.Windows.Forms.Button();
            this.raodenobatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gamoshvebistarixi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "პროდუქტის სახელი";
            // 
            // saxelitxt
            // 
            this.saxelitxt.Location = new System.Drawing.Point(13, 42);
            this.saxelitxt.Name = "saxelitxt";
            this.saxelitxt.Size = new System.Drawing.Size(130, 23);
            this.saxelitxt.TabIndex = 1;
            // 
            // fasitxt
            // 
            this.fasitxt.Location = new System.Drawing.Point(160, 42);
            this.fasitxt.Name = "fasitxt";
            this.fasitxt.Size = new System.Drawing.Size(115, 23);
            this.fasitxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "პროდუქტის ფასი";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(459, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // damatebabtn
            // 
            this.damatebabtn.Location = new System.Drawing.Point(316, 86);
            this.damatebabtn.Name = "damatebabtn";
            this.damatebabtn.Size = new System.Drawing.Size(74, 41);
            this.damatebabtn.TabIndex = 5;
            this.damatebabtn.Text = "დამატება";
            this.damatebabtn.UseVisualStyleBackColor = true;
            this.damatebabtn.Click += new System.EventHandler(this.damatebabtn_Click_1);
            // 
            // raodenobatxt
            // 
            this.raodenobatxt.Location = new System.Drawing.Point(290, 42);
            this.raodenobatxt.Name = "raodenobatxt";
            this.raodenobatxt.Size = new System.Drawing.Size(100, 23);
            this.raodenobatxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "რაოდენობა";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ჯამი";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gamoshvebistarixi
            // 
            this.gamoshvebistarixi.Location = new System.Drawing.Point(12, 93);
            this.gamoshvebistarixi.Name = "gamoshvebistarixi";
            this.gamoshvebistarixi.Size = new System.Drawing.Size(228, 23);
            this.gamoshvebistarixi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "გამოშვების თარიღი";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gamoshvebistarixi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.raodenobatxt);
            this.Controls.Add(this.damatebabtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fasitxt);
            this.Controls.Add(this.saxelitxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox saxelitxt;
        private System.Windows.Forms.TextBox fasitxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button damatebabtn;
        private System.Windows.Forms.TextBox raodenobatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker gamoshvebistarixi;
        private System.Windows.Forms.Label label5;
    }
}

