namespace Assignment3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxFileName = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.gbxFile = new System.Windows.Forms.GroupBox();
            this.rbtOpen = new System.Windows.Forms.RadioButton();
            this.rbtCreate = new System.Windows.Forms.RadioButton();
            this.btnCreateOpen = new System.Windows.Forms.Button();
            this.gbxTransactWrite = new System.Windows.Forms.GroupBox();
            this.txtTransactWrite = new System.Windows.Forms.TextBox();
            this.gbxDate = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.gbxSerialNumber = new System.Windows.Forms.GroupBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.gbxTool = new System.Windows.Forms.GroupBox();
            this.txtTool = new System.Windows.Forms.TextBox();
            this.gbxPrice = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.gbxQty = new System.Windows.Forms.GroupBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.gbxAmount = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.ltvDisplay = new System.Windows.Forms.ListView();
            this.btnWriteRecord = new System.Windows.Forms.Button();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.gbxFindTransact = new System.Windows.Forms.GroupBox();
            this.txtTransactFind = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.gbxMessage = new System.Windows.Forms.GroupBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.gbxFileName.SuspendLayout();
            this.gbxFile.SuspendLayout();
            this.gbxTransactWrite.SuspendLayout();
            this.gbxDate.SuspendLayout();
            this.gbxSerialNumber.SuspendLayout();
            this.gbxTool.SuspendLayout();
            this.gbxPrice.SuspendLayout();
            this.gbxQty.SuspendLayout();
            this.gbxAmount.SuspendLayout();
            this.gbxFindTransact.SuspendLayout();
            this.gbxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFileName
            // 
            this.gbxFileName.Controls.Add(this.txtFileName);
            this.gbxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxFileName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxFileName.Location = new System.Drawing.Point(21, 36);
            this.gbxFileName.Name = "gbxFileName";
            this.gbxFileName.Size = new System.Drawing.Size(267, 63);
            this.gbxFileName.TabIndex = 2;
            this.gbxFileName.TabStop = false;
            this.gbxFileName.Text = "Enter File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(15, 23);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(235, 22);
            this.txtFileName.TabIndex = 0;
            // 
            // gbxFile
            // 
            this.gbxFile.Controls.Add(this.rbtOpen);
            this.gbxFile.Controls.Add(this.rbtCreate);
            this.gbxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxFile.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbxFile.Location = new System.Drawing.Point(293, 36);
            this.gbxFile.Name = "gbxFile";
            this.gbxFile.Size = new System.Drawing.Size(256, 63);
            this.gbxFile.TabIndex = 2;
            this.gbxFile.TabStop = false;
            this.gbxFile.Text = "File";
            // 
            // rbtOpen
            // 
            this.rbtOpen.AutoSize = true;
            this.rbtOpen.Location = new System.Drawing.Point(117, 24);
            this.rbtOpen.Name = "rbtOpen";
            this.rbtOpen.Size = new System.Drawing.Size(121, 20);
            this.rbtOpen.TabIndex = 0;
            this.rbtOpen.TabStop = true;
            this.rbtOpen.Text = "Open Existing";
            this.rbtOpen.UseVisualStyleBackColor = true;
            // 
            // rbtCreate
            // 
            this.rbtCreate.AutoSize = true;
            this.rbtCreate.Location = new System.Drawing.Point(5, 24);
            this.rbtCreate.Name = "rbtCreate";
            this.rbtCreate.Size = new System.Drawing.Size(106, 20);
            this.rbtCreate.TabIndex = 0;
            this.rbtCreate.TabStop = true;
            this.rbtCreate.Text = "Create New";
            this.rbtCreate.UseVisualStyleBackColor = true;
            // 
            // btnCreateOpen
            // 
            this.btnCreateOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCreateOpen.Location = new System.Drawing.Point(555, 46);
            this.btnCreateOpen.Name = "btnCreateOpen";
            this.btnCreateOpen.Size = new System.Drawing.Size(102, 53);
            this.btnCreateOpen.TabIndex = 3;
            this.btnCreateOpen.Text = "Create/Open File";
            this.btnCreateOpen.UseVisualStyleBackColor = true;
            this.btnCreateOpen.Click += new System.EventHandler(this.btnCreateOpen_Click);
            // 
            // gbxTransactWrite
            // 
            this.gbxTransactWrite.Controls.Add(this.txtTransactWrite);
            this.gbxTransactWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxTransactWrite.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxTransactWrite.Location = new System.Drawing.Point(21, 105);
            this.gbxTransactWrite.Name = "gbxTransactWrite";
            this.gbxTransactWrite.Size = new System.Drawing.Size(129, 63);
            this.gbxTransactWrite.TabIndex = 2;
            this.gbxTransactWrite.TabStop = false;
            this.gbxTransactWrite.Text = "Transact #";
            // 
            // txtTransactWrite
            // 
            this.txtTransactWrite.Location = new System.Drawing.Point(15, 23);
            this.txtTransactWrite.Name = "txtTransactWrite";
            this.txtTransactWrite.Size = new System.Drawing.Size(101, 22);
            this.txtTransactWrite.TabIndex = 0;
            // 
            // gbxDate
            // 
            this.gbxDate.Controls.Add(this.txtDate);
            this.gbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxDate.Location = new System.Drawing.Point(159, 105);
            this.gbxDate.Name = "gbxDate";
            this.gbxDate.Size = new System.Drawing.Size(129, 63);
            this.gbxDate.TabIndex = 2;
            this.gbxDate.TabStop = false;
            this.gbxDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(15, 23);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(101, 22);
            this.txtDate.TabIndex = 0;
            // 
            // gbxSerialNumber
            // 
            this.gbxSerialNumber.Controls.Add(this.txtSerialNumber);
            this.gbxSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxSerialNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxSerialNumber.Location = new System.Drawing.Point(293, 105);
            this.gbxSerialNumber.Name = "gbxSerialNumber";
            this.gbxSerialNumber.Size = new System.Drawing.Size(129, 63);
            this.gbxSerialNumber.TabIndex = 2;
            this.gbxSerialNumber.TabStop = false;
            this.gbxSerialNumber.Text = "Serial Number";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(15, 23);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(101, 22);
            this.txtSerialNumber.TabIndex = 0;
            // 
            // gbxTool
            // 
            this.gbxTool.Controls.Add(this.txtTool);
            this.gbxTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxTool.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxTool.Location = new System.Drawing.Point(428, 105);
            this.gbxTool.Name = "gbxTool";
            this.gbxTool.Size = new System.Drawing.Size(211, 63);
            this.gbxTool.TabIndex = 2;
            this.gbxTool.TabStop = false;
            this.gbxTool.Text = "Tool Purchased";
            // 
            // txtTool
            // 
            this.txtTool.Location = new System.Drawing.Point(15, 23);
            this.txtTool.Name = "txtTool";
            this.txtTool.Size = new System.Drawing.Size(184, 22);
            this.txtTool.TabIndex = 0;
            // 
            // gbxPrice
            // 
            this.gbxPrice.Controls.Add(this.txtPrice);
            this.gbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxPrice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxPrice.Location = new System.Drawing.Point(644, 105);
            this.gbxPrice.Name = "gbxPrice";
            this.gbxPrice.Size = new System.Drawing.Size(102, 63);
            this.gbxPrice.TabIndex = 2;
            this.gbxPrice.TabStop = false;
            this.gbxPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(15, 23);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(73, 22);
            this.txtPrice.TabIndex = 0;
            // 
            // gbxQty
            // 
            this.gbxQty.Controls.Add(this.txtQty);
            this.gbxQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxQty.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxQty.Location = new System.Drawing.Point(751, 105);
            this.gbxQty.Name = "gbxQty";
            this.gbxQty.Size = new System.Drawing.Size(102, 63);
            this.gbxQty.TabIndex = 2;
            this.gbxQty.TabStop = false;
            this.gbxQty.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(15, 23);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(73, 22);
            this.txtQty.TabIndex = 0;
            // 
            // gbxAmount
            // 
            this.gbxAmount.Controls.Add(this.txtAmount);
            this.gbxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxAmount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxAmount.Location = new System.Drawing.Point(858, 105);
            this.gbxAmount.Name = "gbxAmount";
            this.gbxAmount.Size = new System.Drawing.Size(102, 63);
            this.gbxAmount.TabIndex = 2;
            this.gbxAmount.TabStop = false;
            this.gbxAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(15, 23);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(73, 22);
            this.txtAmount.TabIndex = 0;
            // 
            // ltvDisplay
            // 
            this.ltvDisplay.Location = new System.Drawing.Point(21, 253);
            this.ltvDisplay.Name = "ltvDisplay";
            this.ltvDisplay.Size = new System.Drawing.Size(940, 275);
            this.ltvDisplay.TabIndex = 4;
            this.ltvDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // btnWriteRecord
            // 
            this.btnWriteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteRecord.Location = new System.Drawing.Point(21, 196);
            this.btnWriteRecord.Name = "btnWriteRecord";
            this.btnWriteRecord.Size = new System.Drawing.Size(116, 37);
            this.btnWriteRecord.TabIndex = 5;
            this.btnWriteRecord.Text = "Write a Record";
            this.btnWriteRecord.UseVisualStyleBackColor = true;
            this.btnWriteRecord.Click += new System.EventHandler(this.btnWriteRecord_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(163, 196);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(226, 37);
            this.btnDeleteRecord.TabIndex = 6;
            this.btnDeleteRecord.Text = "Delete a Record by Transac #";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // gbxFindTransact
            // 
            this.gbxFindTransact.Controls.Add(this.txtTransactFind);
            this.gbxFindTransact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFindTransact.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbxFindTransact.Location = new System.Drawing.Point(410, 182);
            this.gbxFindTransact.Name = "gbxFindTransact";
            this.gbxFindTransact.Size = new System.Drawing.Size(200, 56);
            this.gbxFindTransact.TabIndex = 7;
            this.gbxFindTransact.TabStop = false;
            this.gbxFindTransact.Text = "Transact #";
            // 
            // txtTransactFind
            // 
            this.txtTransactFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactFind.Location = new System.Drawing.Point(33, 21);
            this.txtTransactFind.Name = "txtTransactFind";
            this.txtTransactFind.Size = new System.Drawing.Size(142, 21);
            this.txtTransactFind.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(21, 549);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(96, 38);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "Display Data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(123, 549);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 38);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close File";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFile.Location = new System.Drawing.Point(224, 549);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(101, 38);
            this.btnDeleteFile.TabIndex = 10;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            // 
            // gbxMessage
            // 
            this.gbxMessage.Controls.Add(this.rtbMessage);
            this.gbxMessage.Location = new System.Drawing.Point(21, 612);
            this.gbxMessage.Name = "gbxMessage";
            this.gbxMessage.Size = new System.Drawing.Size(940, 136);
            this.gbxMessage.TabIndex = 11;
            this.gbxMessage.TabStop = false;
            this.gbxMessage.Text = "Display Message";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(15, 20);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(910, 96);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(979, 760);
            this.Controls.Add(this.gbxMessage);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.gbxFindTransact);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnWriteRecord);
            this.Controls.Add(this.ltvDisplay);
            this.Controls.Add(this.btnCreateOpen);
            this.Controls.Add(this.gbxFile);
            this.Controls.Add(this.gbxAmount);
            this.Controls.Add(this.gbxQty);
            this.Controls.Add(this.gbxPrice);
            this.Controls.Add(this.gbxTool);
            this.Controls.Add(this.gbxSerialNumber);
            this.Controls.Add(this.gbxDate);
            this.Controls.Add(this.gbxTransactWrite);
            this.Controls.Add(this.gbxFileName);
            this.Name = "Form1";
            this.Text = "File IO";
            this.gbxFileName.ResumeLayout(false);
            this.gbxFileName.PerformLayout();
            this.gbxFile.ResumeLayout(false);
            this.gbxFile.PerformLayout();
            this.gbxTransactWrite.ResumeLayout(false);
            this.gbxTransactWrite.PerformLayout();
            this.gbxDate.ResumeLayout(false);
            this.gbxDate.PerformLayout();
            this.gbxSerialNumber.ResumeLayout(false);
            this.gbxSerialNumber.PerformLayout();
            this.gbxTool.ResumeLayout(false);
            this.gbxTool.PerformLayout();
            this.gbxPrice.ResumeLayout(false);
            this.gbxPrice.PerformLayout();
            this.gbxQty.ResumeLayout(false);
            this.gbxQty.PerformLayout();
            this.gbxAmount.ResumeLayout(false);
            this.gbxAmount.PerformLayout();
            this.gbxFindTransact.ResumeLayout(false);
            this.gbxFindTransact.PerformLayout();
            this.gbxMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox gbxFile;
        private System.Windows.Forms.RadioButton rbtOpen;
        private System.Windows.Forms.RadioButton rbtCreate;
        private System.Windows.Forms.Button btnCreateOpen;
        private System.Windows.Forms.GroupBox gbxTransactWrite;
        private System.Windows.Forms.TextBox txtTransactWrite;
        private System.Windows.Forms.GroupBox gbxDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.GroupBox gbxSerialNumber;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.GroupBox gbxTool;
        private System.Windows.Forms.TextBox txtTool;
        private System.Windows.Forms.GroupBox gbxPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox gbxQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.GroupBox gbxAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ListView ltvDisplay;
        private System.Windows.Forms.Button btnWriteRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.GroupBox gbxFindTransact;
        private System.Windows.Forms.TextBox txtTransactFind;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.GroupBox gbxMessage;
        private System.Windows.Forms.RichTextBox rtbMessage;
    }
}

