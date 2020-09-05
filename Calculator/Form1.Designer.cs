namespace Calculator
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
            this.headerTable = new System.Windows.Forms.TableLayoutPanel();
            this.menuBtn = new System.Windows.Forms.Button();
            this.histBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTable = new System.Windows.Forms.TableLayoutPanel();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.equationLbl = new System.Windows.Forms.Label();
            this.oneOverBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearAllBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.percentBtn = new System.Windows.Forms.Button();
            this.squaredBtn = new System.Windows.Forms.Button();
            this.sqrRootBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.timesBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.posnegBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.decimalBtn = new System.Windows.Forms.Button();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.keypadTable = new System.Windows.Forms.TableLayoutPanel();
            this.headerTable.SuspendLayout();
            this.resultTable.SuspendLayout();
            this.keypadTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerTable
            // 
            this.headerTable.ColumnCount = 3;
            this.headerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.headerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.headerTable.Controls.Add(this.menuBtn, 0, 0);
            this.headerTable.Controls.Add(this.histBtn, 2, 0);
            this.headerTable.Controls.Add(this.label1, 1, 0);
            this.headerTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerTable.Location = new System.Drawing.Point(0, 0);
            this.headerTable.Name = "headerTable";
            this.headerTable.RowCount = 1;
            this.headerTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.headerTable.Size = new System.Drawing.Size(492, 58);
            this.headerTable.TabIndex = 1;
            // 
            // menuBtn
            // 
            this.menuBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBtn.Location = new System.Drawing.Point(3, 3);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(44, 52);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            // 
            // histBtn
            // 
            this.histBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histBtn.Location = new System.Drawing.Point(445, 3);
            this.histBtn.Name = "histBtn";
            this.histBtn.Size = new System.Drawing.Size(44, 52);
            this.histBtn.TabIndex = 1;
            this.histBtn.Text = "HIST";
            this.histBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Standard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultTable
            // 
            this.resultTable.ColumnCount = 1;
            this.resultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.resultTable.Controls.Add(this.inputBox, 0, 1);
            this.resultTable.Controls.Add(this.equationLbl, 0, 0);
            this.resultTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultTable.Location = new System.Drawing.Point(0, 58);
            this.resultTable.Name = "resultTable";
            this.resultTable.RowCount = 2;
            this.resultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.resultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.resultTable.Size = new System.Drawing.Size(492, 105);
            this.resultTable.TabIndex = 2;
            // 
            // inputBox
            // 
            this.inputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputBox.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputBox.Location = new System.Drawing.Point(3, 34);
            this.inputBox.Name = "inputBox";
            this.inputBox.ReadOnly = true;
            this.inputBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputBox.Size = new System.Drawing.Size(486, 63);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // equationLbl
            // 
            this.equationLbl.AutoSize = true;
            this.equationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equationLbl.Location = new System.Drawing.Point(3, 0);
            this.equationLbl.Name = "equationLbl";
            this.equationLbl.Size = new System.Drawing.Size(486, 31);
            this.equationLbl.TabIndex = 1;
            this.equationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // oneOverBtn
            // 
            this.oneOverBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneOverBtn.Location = new System.Drawing.Point(3, 76);
            this.oneOverBtn.Name = "oneOverBtn";
            this.oneOverBtn.Size = new System.Drawing.Size(117, 67);
            this.oneOverBtn.TabIndex = 3;
            this.oneOverBtn.Text = "1/x";
            this.oneOverBtn.UseVisualStyleBackColor = true;
            this.oneOverBtn.Click += new System.EventHandler(this.oneOverBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Location = new System.Drawing.Point(372, 3);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(117, 67);
            this.deleteBtn.TabIndex = 0;
            this.deleteBtn.Text = "DEL";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearAllBtn
            // 
            this.clearAllBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearAllBtn.Location = new System.Drawing.Point(249, 3);
            this.clearAllBtn.Name = "clearAllBtn";
            this.clearAllBtn.Size = new System.Drawing.Size(117, 67);
            this.clearAllBtn.TabIndex = 2;
            this.clearAllBtn.Text = "C";
            this.clearAllBtn.UseVisualStyleBackColor = true;
            this.clearAllBtn.Click += new System.EventHandler(this.clearAllBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.Location = new System.Drawing.Point(126, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(117, 67);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "CE";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // percentBtn
            // 
            this.percentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentBtn.Location = new System.Drawing.Point(3, 3);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(117, 67);
            this.percentBtn.TabIndex = 0;
            this.percentBtn.Text = "%";
            this.percentBtn.UseVisualStyleBackColor = true;
            this.percentBtn.Click += new System.EventHandler(this.percentBtn_Click);
            // 
            // squaredBtn
            // 
            this.squaredBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squaredBtn.Location = new System.Drawing.Point(126, 76);
            this.squaredBtn.Name = "squaredBtn";
            this.squaredBtn.Size = new System.Drawing.Size(117, 67);
            this.squaredBtn.TabIndex = 3;
            this.squaredBtn.Text = "x^2";
            this.squaredBtn.UseVisualStyleBackColor = true;
            this.squaredBtn.Click += new System.EventHandler(this.squaredBtn_Click);
            // 
            // sqrRootBtn
            // 
            this.sqrRootBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqrRootBtn.Location = new System.Drawing.Point(249, 76);
            this.sqrRootBtn.Name = "sqrRootBtn";
            this.sqrRootBtn.Size = new System.Drawing.Size(117, 67);
            this.sqrRootBtn.TabIndex = 3;
            this.sqrRootBtn.Text = "|x";
            this.sqrRootBtn.UseVisualStyleBackColor = true;
            this.sqrRootBtn.Click += new System.EventHandler(this.sqrRootBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideBtn.Location = new System.Drawing.Point(372, 76);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(117, 67);
            this.divideBtn.TabIndex = 3;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenBtn.Location = new System.Drawing.Point(3, 149);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(117, 67);
            this.sevenBtn.TabIndex = 3;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightBtn.Location = new System.Drawing.Point(126, 149);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(117, 67);
            this.eightBtn.TabIndex = 3;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineBtn.Location = new System.Drawing.Point(249, 149);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(117, 67);
            this.nineBtn.TabIndex = 3;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // timesBtn
            // 
            this.timesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timesBtn.Location = new System.Drawing.Point(372, 149);
            this.timesBtn.Name = "timesBtn";
            this.timesBtn.Size = new System.Drawing.Size(117, 67);
            this.timesBtn.TabIndex = 3;
            this.timesBtn.Text = "X";
            this.timesBtn.UseVisualStyleBackColor = true;
            this.timesBtn.Click += new System.EventHandler(this.timesBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourBtn.Location = new System.Drawing.Point(3, 222);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(117, 67);
            this.fourBtn.TabIndex = 3;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveBtn.Location = new System.Drawing.Point(126, 222);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(117, 67);
            this.fiveBtn.TabIndex = 3;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixBtn.Location = new System.Drawing.Point(249, 222);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(117, 67);
            this.sixBtn.TabIndex = 3;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusBtn.Location = new System.Drawing.Point(372, 222);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(117, 67);
            this.minusBtn.TabIndex = 3;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneBtn.Location = new System.Drawing.Point(3, 295);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(117, 67);
            this.oneBtn.TabIndex = 3;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoBtn.Location = new System.Drawing.Point(126, 295);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(117, 67);
            this.twoBtn.TabIndex = 3;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeBtn.Location = new System.Drawing.Point(249, 295);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(117, 67);
            this.threeBtn.TabIndex = 3;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusBtn.Location = new System.Drawing.Point(372, 295);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(117, 67);
            this.plusBtn.TabIndex = 3;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // posnegBtn
            // 
            this.posnegBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.posnegBtn.Location = new System.Drawing.Point(3, 368);
            this.posnegBtn.Name = "posnegBtn";
            this.posnegBtn.Size = new System.Drawing.Size(117, 69);
            this.posnegBtn.TabIndex = 3;
            this.posnegBtn.Text = "+/-";
            this.posnegBtn.UseVisualStyleBackColor = true;
            this.posnegBtn.Click += new System.EventHandler(this.posnegBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroBtn.Location = new System.Drawing.Point(126, 368);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(117, 69);
            this.zeroBtn.TabIndex = 3;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // decimalBtn
            // 
            this.decimalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalBtn.Location = new System.Drawing.Point(249, 368);
            this.decimalBtn.Name = "decimalBtn";
            this.decimalBtn.Size = new System.Drawing.Size(117, 69);
            this.decimalBtn.TabIndex = 3;
            this.decimalBtn.Text = ".";
            this.decimalBtn.UseVisualStyleBackColor = true;
            this.decimalBtn.Click += new System.EventHandler(this.decimalBtn_Click);
            // 
            // equalsBtn
            // 
            this.equalsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalsBtn.Location = new System.Drawing.Point(372, 368);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(117, 69);
            this.equalsBtn.TabIndex = 3;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = true;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            // 
            // keypadTable
            // 
            this.keypadTable.ColumnCount = 4;
            this.keypadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keypadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keypadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keypadTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.keypadTable.Controls.Add(this.equalsBtn, 3, 5);
            this.keypadTable.Controls.Add(this.decimalBtn, 2, 5);
            this.keypadTable.Controls.Add(this.zeroBtn, 1, 5);
            this.keypadTable.Controls.Add(this.posnegBtn, 0, 5);
            this.keypadTable.Controls.Add(this.plusBtn, 3, 4);
            this.keypadTable.Controls.Add(this.threeBtn, 2, 4);
            this.keypadTable.Controls.Add(this.twoBtn, 1, 4);
            this.keypadTable.Controls.Add(this.oneBtn, 0, 4);
            this.keypadTable.Controls.Add(this.minusBtn, 3, 3);
            this.keypadTable.Controls.Add(this.sixBtn, 2, 3);
            this.keypadTable.Controls.Add(this.fiveBtn, 1, 3);
            this.keypadTable.Controls.Add(this.fourBtn, 0, 3);
            this.keypadTable.Controls.Add(this.timesBtn, 3, 2);
            this.keypadTable.Controls.Add(this.nineBtn, 2, 2);
            this.keypadTable.Controls.Add(this.eightBtn, 1, 2);
            this.keypadTable.Controls.Add(this.sevenBtn, 0, 2);
            this.keypadTable.Controls.Add(this.divideBtn, 3, 1);
            this.keypadTable.Controls.Add(this.sqrRootBtn, 2, 1);
            this.keypadTable.Controls.Add(this.squaredBtn, 1, 1);
            this.keypadTable.Controls.Add(this.percentBtn, 0, 0);
            this.keypadTable.Controls.Add(this.clearBtn, 1, 0);
            this.keypadTable.Controls.Add(this.clearAllBtn, 2, 0);
            this.keypadTable.Controls.Add(this.deleteBtn, 3, 0);
            this.keypadTable.Controls.Add(this.oneOverBtn, 0, 1);
            this.keypadTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keypadTable.Location = new System.Drawing.Point(0, 163);
            this.keypadTable.Name = "keypadTable";
            this.keypadTable.RowCount = 6;
            this.keypadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.keypadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.keypadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.keypadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.keypadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.keypadTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.keypadTable.Size = new System.Drawing.Size(492, 440);
            this.keypadTable.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.equalsBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 603);
            this.Controls.Add(this.keypadTable);
            this.Controls.Add(this.resultTable);
            this.Controls.Add(this.headerTable);
            this.MinimumSize = new System.Drawing.Size(330, 630);
            this.Name = "Form1";
            this.Text = "Form1";
            this.headerTable.ResumeLayout(false);
            this.headerTable.PerformLayout();
            this.resultTable.ResumeLayout(false);
            this.resultTable.PerformLayout();
            this.keypadTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel headerTable;
        private System.Windows.Forms.TableLayoutPanel resultTable;
        private System.Windows.Forms.Button oneOverBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearAllBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button percentBtn;
        private System.Windows.Forms.Button squaredBtn;
        private System.Windows.Forms.Button sqrRootBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button timesBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button posnegBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button decimalBtn;
        private System.Windows.Forms.Button equalsBtn;
        private System.Windows.Forms.TableLayoutPanel keypadTable;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button histBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label equationLbl;
    }
}

