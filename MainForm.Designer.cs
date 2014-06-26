namespace ConwaysGame
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.pnlDrawGame = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.lbAutoState = new System.Windows.Forms.Label();
            this.lbAutoStateName = new System.Windows.Forms.Label();
            this.btnRemoveCell = new System.Windows.Forms.Button();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.lbDelay = new System.Windows.Forms.Label();
            this.lbAddAliveCell = new System.Windows.Forms.Label();
            this.btnChangeUniverseSize = new System.Windows.Forms.Button();
            this.btnAddCell = new System.Windows.Forms.Button();
            this.lbY = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.numUniverseSize = new System.Windows.Forms.NumericUpDown();
            this.lbUniverseSize = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grpMain.SuspendLayout();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUniverseSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(715, 537);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(69, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start Auto";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.pnlDrawGame);
            this.grpMain.Location = new System.Drawing.Point(199, 6);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(660, 525);
            this.grpMain.TabIndex = 2;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Universe Current State";
            // 
            // pnlDrawGame
            // 
            this.pnlDrawGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrawGame.Location = new System.Drawing.Point(6, 19);
            this.pnlDrawGame.Name = "pnlDrawGame";
            this.pnlDrawGame.Size = new System.Drawing.Size(648, 500);
            this.pnlDrawGame.TabIndex = 0;
            this.pnlDrawGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawGame_Paint);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(640, 537);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(69, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(790, 537);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(69, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop Auto";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Universe";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grpSettings.Controls.Add(this.lbAutoState);
            this.grpSettings.Controls.Add(this.lbAutoStateName);
            this.grpSettings.Controls.Add(this.btnRemoveCell);
            this.grpSettings.Controls.Add(this.numDelay);
            this.grpSettings.Controls.Add(this.lbDelay);
            this.grpSettings.Controls.Add(this.lbAddAliveCell);
            this.grpSettings.Controls.Add(this.btnChangeUniverseSize);
            this.grpSettings.Controls.Add(this.btnAddCell);
            this.grpSettings.Controls.Add(this.lbY);
            this.grpSettings.Controls.Add(this.lbX);
            this.grpSettings.Controls.Add(this.numY);
            this.grpSettings.Controls.Add(this.btnClear);
            this.grpSettings.Controls.Add(this.numX);
            this.grpSettings.Controls.Add(this.numUniverseSize);
            this.grpSettings.Controls.Add(this.lbUniverseSize);
            this.grpSettings.Location = new System.Drawing.Point(12, 6);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(181, 525);
            this.grpSettings.TabIndex = 1;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Initial Universe Configuration";
            // 
            // lbAutoState
            // 
            this.lbAutoState.AutoSize = true;
            this.lbAutoState.Location = new System.Drawing.Point(87, 350);
            this.lbAutoState.Name = "lbAutoState";
            this.lbAutoState.Size = new System.Drawing.Size(53, 13);
            this.lbAutoState.TabIndex = 15;
            this.lbAutoState.Text = "Unknown";
            // 
            // lbAutoStateName
            // 
            this.lbAutoStateName.AutoSize = true;
            this.lbAutoStateName.Location = new System.Drawing.Point(6, 350);
            this.lbAutoStateName.Name = "lbAutoStateName";
            this.lbAutoStateName.Size = new System.Drawing.Size(60, 13);
            this.lbAutoStateName.TabIndex = 14;
            this.lbAutoStateName.Text = "Auto State:";
            // 
            // btnRemoveCell
            // 
            this.btnRemoveCell.Location = new System.Drawing.Point(9, 214);
            this.btnRemoveCell.Name = "btnRemoveCell";
            this.btnRemoveCell.Size = new System.Drawing.Size(153, 23);
            this.btnRemoveCell.TabIndex = 6;
            this.btnRemoveCell.Text = "Remove Alive Cell";
            this.btnRemoveCell.UseVisualStyleBackColor = true;
            this.btnRemoveCell.Click += new System.EventHandler(this.btnRemoveCell_Click);
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(90, 320);
            this.numDelay.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(72, 20);
            this.numDelay.TabIndex = 8;
            this.numDelay.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // lbDelay
            // 
            this.lbDelay.AutoSize = true;
            this.lbDelay.Location = new System.Drawing.Point(6, 322);
            this.lbDelay.Name = "lbDelay";
            this.lbDelay.Size = new System.Drawing.Size(76, 13);
            this.lbDelay.TabIndex = 13;
            this.lbDelay.Text = "Delay (msecs):";
            // 
            // lbAddAliveCell
            // 
            this.lbAddAliveCell.AutoSize = true;
            this.lbAddAliveCell.Location = new System.Drawing.Point(6, 134);
            this.lbAddAliveCell.Name = "lbAddAliveCell";
            this.lbAddAliveCell.Size = new System.Drawing.Size(147, 13);
            this.lbAddAliveCell.TabIndex = 11;
            this.lbAddAliveCell.Text = "Adding/Removing Alive Cells:";
            // 
            // btnChangeUniverseSize
            // 
            this.btnChangeUniverseSize.Location = new System.Drawing.Point(9, 58);
            this.btnChangeUniverseSize.Name = "btnChangeUniverseSize";
            this.btnChangeUniverseSize.Size = new System.Drawing.Size(153, 23);
            this.btnChangeUniverseSize.TabIndex = 2;
            this.btnChangeUniverseSize.Text = "Change Universe Size";
            this.btnChangeUniverseSize.UseVisualStyleBackColor = true;
            this.btnChangeUniverseSize.Click += new System.EventHandler(this.btnChangeUniverseSize_Click);
            // 
            // btnAddCell
            // 
            this.btnAddCell.Location = new System.Drawing.Point(9, 185);
            this.btnAddCell.Name = "btnAddCell";
            this.btnAddCell.Size = new System.Drawing.Size(153, 23);
            this.btnAddCell.TabIndex = 5;
            this.btnAddCell.Text = "Add Alive Cell";
            this.btnAddCell.UseVisualStyleBackColor = true;
            this.btnAddCell.Click += new System.EventHandler(this.btnAddCell_Click);
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(87, 161);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(17, 13);
            this.lbY.TabIndex = 10;
            this.lbY.Text = "Y:";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(6, 161);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(17, 13);
            this.lbX.TabIndex = 9;
            this.lbX.Text = "X:";
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(110, 159);
            this.numY.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(52, 20);
            this.numY.TabIndex = 4;
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(29, 159);
            this.numX.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(52, 20);
            this.numX.TabIndex = 3;
            // 
            // numUniverseSize
            // 
            this.numUniverseSize.Location = new System.Drawing.Point(87, 32);
            this.numUniverseSize.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.numUniverseSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUniverseSize.Name = "numUniverseSize";
            this.numUniverseSize.Size = new System.Drawing.Size(75, 20);
            this.numUniverseSize.TabIndex = 1;
            this.numUniverseSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbUniverseSize
            // 
            this.lbUniverseSize.AutoSize = true;
            this.lbUniverseSize.Location = new System.Drawing.Point(6, 34);
            this.lbUniverseSize.Name = "lbUniverseSize";
            this.lbUniverseSize.Size = new System.Drawing.Size(75, 13);
            this.lbUniverseSize.TabIndex = 6;
            this.lbUniverseSize.Text = "Universe Size:";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(12, 537);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(87, 537);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 572);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpMain);
            this.Name = "MainForm";
            this.Text = "Conway\'s Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.grpMain.ResumeLayout(false);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUniverseSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Panel pnlDrawGame;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.NumericUpDown numUniverseSize;
        private System.Windows.Forms.Label lbUniverseSize;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddCell;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.Button btnChangeUniverseSize;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbAddAliveCell;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label lbDelay;
        private System.Windows.Forms.Button btnRemoveCell;
        private System.Windows.Forms.Label lbAutoState;
        private System.Windows.Forms.Label lbAutoStateName;
    }
}

