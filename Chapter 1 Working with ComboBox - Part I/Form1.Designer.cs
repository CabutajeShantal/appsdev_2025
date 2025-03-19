namespace SimpleFormsAppWithComboBox
{
    partial class Form1
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
            this.comboBoxFoods = new System.Windows.Forms.ComboBox();
            this.checkedListBoxFoods = new System.Windows.Forms.CheckedListBox();
            this.listBoxFoods = new System.Windows.Forms.ListBox();
            this.Select = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.RmvbTN = new System.Windows.Forms.Button();
            this.ClrAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFoods
            // 
            this.comboBoxFoods.FormattingEnabled = true;
            this.comboBoxFoods.Location = new System.Drawing.Point(22, 123);
            this.comboBoxFoods.Name = "comboBoxFoods";
            this.comboBoxFoods.Size = new System.Drawing.Size(79, 21);
            this.comboBoxFoods.TabIndex = 0;
            // 
            // checkedListBoxFoods
            // 
            this.checkedListBoxFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxFoods.FormattingEnabled = true;
            this.checkedListBoxFoods.Location = new System.Drawing.Point(119, 121);
            this.checkedListBoxFoods.Name = "checkedListBoxFoods";
            this.checkedListBoxFoods.Size = new System.Drawing.Size(173, 184);
            this.checkedListBoxFoods.TabIndex = 1;
            this.checkedListBoxFoods.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // listBoxFoods
            // 
            this.listBoxFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFoods.FormattingEnabled = true;
            this.listBoxFoods.ItemHeight = 16;
            this.listBoxFoods.Location = new System.Drawing.Point(350, 123);
            this.listBoxFoods.Name = "listBoxFoods";
            this.listBoxFoods.Size = new System.Drawing.Size(137, 180);
            this.listBoxFoods.TabIndex = 2;
            // 
            // Select
            // 
            this.Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.Location = new System.Drawing.Point(21, 150);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(80, 35);
            this.Select.TabIndex = 3;
            this.Select.Text = "select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.button1_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(170, 313);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(86, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // RmvbTN
            // 
            this.RmvbTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RmvbTN.Location = new System.Drawing.Point(493, 148);
            this.RmvbTN.Name = "RmvbTN";
            this.RmvbTN.Size = new System.Drawing.Size(75, 23);
            this.RmvbTN.TabIndex = 5;
            this.RmvbTN.Text = "remove";
            this.RmvbTN.UseVisualStyleBackColor = true;
            this.RmvbTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // ClrAll
            // 
            this.ClrAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClrAll.Location = new System.Drawing.Point(493, 177);
            this.ClrAll.Name = "ClrAll";
            this.ClrAll.Size = new System.Drawing.Size(75, 23);
            this.ClrAll.TabIndex = 6;
            this.ClrAll.Text = "clear all";
            this.ClrAll.UseVisualStyleBackColor = true;
            this.ClrAll.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Food List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "My Favorite Food List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cuisine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "My Simple Favorite Food Picker App";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(576, 347);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClrAll);
            this.Controls.Add(this.RmvbTN);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.listBoxFoods);
            this.Controls.Add(this.checkedListBoxFoods);
            this.Controls.Add(this.comboBoxFoods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFoods;
        private System.Windows.Forms.CheckedListBox checkedListBoxFoods;
        private System.Windows.Forms.ListBox listBoxFoods;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button RmvbTN;
        private System.Windows.Forms.Button ClrAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

