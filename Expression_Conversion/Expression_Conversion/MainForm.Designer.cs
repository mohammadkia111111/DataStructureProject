namespace Expression_Conversion
{
    partial class MainForm
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
            this.textBoxInfix = new System.Windows.Forms.TextBox();
            this.labelInfix = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelPostfix = new System.Windows.Forms.Label();
            this.textBoxPostfix = new System.Windows.Forms.TextBox();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.buttonFromInfix = new System.Windows.Forms.Button();
            this.buttonFromPostfix = new System.Windows.Forms.Button();
            this.buttonFromPrefix = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInfix
            // 
            this.textBoxInfix.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxInfix.Location = new System.Drawing.Point(65, 3);
            this.textBoxInfix.Name = "textBoxInfix";
            this.textBoxInfix.Size = new System.Drawing.Size(582, 26);
            this.textBoxInfix.TabIndex = 0;
            // 
            // labelInfix
            // 
            this.labelInfix.AutoSize = true;
            this.labelInfix.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfix.Location = new System.Drawing.Point(3, 0);
            this.labelInfix.Name = "labelInfix";
            this.labelInfix.Size = new System.Drawing.Size(56, 20);
            this.labelInfix.TabIndex = 1;
            this.labelInfix.Text = "Infix";
            this.labelInfix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelMain.Controls.Add(this.labelPrefix, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxPrefix, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelPostfix, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxPostfix, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelInfix, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxInfix, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonFromInfix, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonFromPostfix, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonFromPrefix, 2, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // labelPostfix
            // 
            this.labelPostfix.AutoSize = true;
            this.labelPostfix.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPostfix.Location = new System.Drawing.Point(3, 80);
            this.labelPostfix.Name = "labelPostfix";
            this.labelPostfix.Size = new System.Drawing.Size(56, 20);
            this.labelPostfix.TabIndex = 3;
            this.labelPostfix.Text = "Postfix";
            this.labelPostfix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPostfix
            // 
            this.textBoxPostfix.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPostfix.Location = new System.Drawing.Point(65, 83);
            this.textBoxPostfix.Name = "textBoxPostfix";
            this.textBoxPostfix.Size = new System.Drawing.Size(582, 26);
            this.textBoxPostfix.TabIndex = 2;
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrefix.Location = new System.Drawing.Point(3, 160);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(56, 20);
            this.labelPrefix.TabIndex = 5;
            this.labelPrefix.Text = "Prefix";
            this.labelPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPrefix.Location = new System.Drawing.Point(65, 163);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(582, 26);
            this.textBoxPrefix.TabIndex = 4;
            // 
            // buttonFromInfix
            // 
            this.buttonFromInfix.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonFromInfix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFromInfix.ForeColor = System.Drawing.Color.White;
            this.buttonFromInfix.Location = new System.Drawing.Point(653, 3);
            this.buttonFromInfix.Name = "buttonFromInfix";
            this.buttonFromInfix.Size = new System.Drawing.Size(144, 48);
            this.buttonFromInfix.TabIndex = 6;
            this.buttonFromInfix.Text = "تبدیل";
            this.buttonFromInfix.UseVisualStyleBackColor = false;
            this.buttonFromInfix.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // buttonFromPostfix
            // 
            this.buttonFromPostfix.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonFromPostfix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFromPostfix.ForeColor = System.Drawing.Color.White;
            this.buttonFromPostfix.Location = new System.Drawing.Point(653, 83);
            this.buttonFromPostfix.Name = "buttonFromPostfix";
            this.buttonFromPostfix.Size = new System.Drawing.Size(144, 48);
            this.buttonFromPostfix.TabIndex = 7;
            this.buttonFromPostfix.Text = "تبدیل";
            this.buttonFromPostfix.UseVisualStyleBackColor = false;
            this.buttonFromPostfix.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // buttonFromPrefix
            // 
            this.buttonFromPrefix.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonFromPrefix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFromPrefix.ForeColor = System.Drawing.Color.White;
            this.buttonFromPrefix.Location = new System.Drawing.Point(653, 163);
            this.buttonFromPrefix.Name = "buttonFromPrefix";
            this.buttonFromPrefix.Size = new System.Drawing.Size(144, 48);
            this.buttonFromPrefix.TabIndex = 8;
            this.buttonFromPrefix.Text = "تبدیل";
            this.buttonFromPrefix.UseVisualStyleBackColor = false;
            this.buttonFromPrefix.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "MainForm";
            this.Text = "Expression Conversion";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfix;
        private System.Windows.Forms.Label labelInfix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label labelPostfix;
        private System.Windows.Forms.TextBox textBoxPostfix;
        private System.Windows.Forms.Button buttonFromInfix;
        private System.Windows.Forms.Button buttonFromPostfix;
        private System.Windows.Forms.Button buttonFromPrefix;
    }
}