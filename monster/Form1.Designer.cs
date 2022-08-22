namespace monster
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxMessage = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lvwArray = new System.Windows.Forms.ListView();
            this.coluID = new System.Windows.Forms.ColumnHeader();
            this.coluName = new System.Windows.Forms.ColumnHeader();
            this.coluType = new System.Windows.Forms.ColumnHeader();
            this.colStatue = new System.Windows.Forms.ColumnHeader();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnClearMessage = new System.Windows.Forms.Button();
            this.colTotal = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 27);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // lbxMessage
            // 
            this.lbxMessage.FormattingEnabled = true;
            this.lbxMessage.ItemHeight = 20;
            this.lbxMessage.Location = new System.Drawing.Point(416, 18);
            this.lbxMessage.Name = "lbxMessage";
            this.lbxMessage.Size = new System.Drawing.Size(351, 364);
            this.lbxMessage.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(284, 71);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lvwArray
            // 
            this.lvwArray.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluID,
            this.coluName,
            this.coluType,
            this.colStatue,
            this.colTotal});
            this.lvwArray.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwArray.Location = new System.Drawing.Point(37, 123);
            this.lvwArray.Name = "lvwArray";
            this.lvwArray.Size = new System.Drawing.Size(351, 258);
            this.lvwArray.TabIndex = 7;
            this.lvwArray.UseCompatibleStateImageBehavior = false;
            this.lvwArray.View = System.Windows.Forms.View.Details;
            this.lvwArray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwArray_MouseDoubleClick);
            // 
            // coluID
            // 
            this.coluID.Text = "ID";
            this.coluID.Width = 30;
            // 
            // coluName
            // 
            this.coluName.Text = "Name";
            this.coluName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluName.Width = 100;
            // 
            // coluType
            // 
            this.coluType.Text = "Type";
            this.coluType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coluType.Width = 80;
            // 
            // colStatue
            // 
            this.colStatue.Text = "Statue";
            this.colStatue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStatue.Width = 80;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Type 1",
            "Type 2"});
            this.cmbType.Location = new System.Drawing.Point(104, 68);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(151, 28);
            this.cmbType.TabIndex = 8;
            this.cmbType.Text = "Type 1";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(294, 398);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteAll.TabIndex = 9;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.Location = new System.Drawing.Point(673, 398);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(94, 29);
            this.btnClearMessage.TabIndex = 10;
            this.btnClearMessage.Text = "Clear Message";
            this.btnClearMessage.UseVisualStyleBackColor = true;
            this.btnClearMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearMessage);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lvwArray);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Button btnCreate;
        private ListView lvwArray;
        private ComboBox cmbType;
        private ColumnHeader coluID;
        private ColumnHeader coluName;
        private ColumnHeader coluType;
        public ListBox lbxMessage;
        private ColumnHeader colStatue;
        private Button btnDeleteAll;
        private Button btnClearMessage;
        private ColumnHeader colTotal;
    }
}