namespace Autoconfig
{
    partial class Autoconfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BImplement = new System.Windows.Forms.Button();
            this.BRemove = new System.Windows.Forms.Button();
            this.BCreateUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.autoconfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this._Auto_configDataSet = new Autoconfig._Auto_configDataSet();
     //       this.auto_configTableAdapter = new Autoconfig._Auto_configDataSetTableAdapters.auto_configTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autoconfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Auto_configDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto-Config";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create an auto-config just for you!";
            // 
            // BImplement
            // 
            this.BImplement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BImplement.Location = new System.Drawing.Point(587, 219);
            this.BImplement.Name = "BImplement";
            this.BImplement.Size = new System.Drawing.Size(113, 41);
            this.BImplement.TabIndex = 2;
            this.BImplement.Text = "Implement";
            this.BImplement.UseVisualStyleBackColor = true;
            this.BImplement.Click += new System.EventHandler(this.BImplement_Click);
            // 
            // BRemove
            // 
            this.BRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRemove.Location = new System.Drawing.Point(587, 293);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(113, 44);
            this.BRemove.TabIndex = 3;
            this.BRemove.Text = "Remove";
            this.BRemove.UseVisualStyleBackColor = true;
            // 
            // BCreateUpdate
            // 
            this.BCreateUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCreateUpdate.Location = new System.Drawing.Point(587, 364);
            this.BCreateUpdate.Name = "BCreateUpdate";
            this.BCreateUpdate.Size = new System.Drawing.Size(113, 38);
            this.BCreateUpdate.TabIndex = 4;
            this.BCreateUpdate.Text = "Create/Update";
            this.BCreateUpdate.UseVisualStyleBackColor = true;
            this.BCreateUpdate.Click += new System.EventHandler(this.BCreateUpdate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.autoconfigBindingSource, "Game", true));
            this.comboBox1.DataSource = this.autoconfigBindingSource;
            this.comboBox1.DisplayMember = "Game";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // autoconfigBindingSource
            // 
            this.autoconfigBindingSource.DataMember = "auto-config";
            this.autoconfigBindingSource.DataSource = this._Auto_configDataSet;
            // 
            // _Auto_configDataSet
            // 
            this._Auto_configDataSet.DataSetName = "_Auto_configDataSet";
            this._Auto_configDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auto_configTableAdapter
            // 
            this.auto_configTableAdapter.ClearBeforeFill = true;
            // 
            // Autoconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BCreateUpdate);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.BImplement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Autoconfig";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Autoconfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoconfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Auto_configDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BImplement;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.Button BCreateUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private Autoconfig._Auto_configDataSet _Auto_configDataSet;
        private System.Windows.Forms.BindingSource autoconfigBindingSource;
        private Autoconfig._Auto_configDataSetTableAdapters.auto_configTableAdapter auto_configTableAdapter;
    }
}

