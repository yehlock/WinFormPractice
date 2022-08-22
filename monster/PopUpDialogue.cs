using monster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monster
{
    internal class PopUpDialogue : System.Windows.Forms.Form
    {
        private Button btnLeft;
        private Button btnCenter;
        private Button btnRight;
        private Label txtMessage;
        public string title { get; set; }
        public string message { get; set; }
        public string buttonLeft { get; set; }
        public string buttonCenter { get; set; }
        public string buttonRight { get; set; }
        private bool btnLeftClicked = false;
        private bool btnCenterClicked = false;
        private bool btnRightClicked = false;
        private DialogResult result = DialogResult.None;
        


        public PopUpDialogue(string title, string message, string btnLeft, string btnCenter, string btnRight)
        {
            InitializeComponent();
            var cutomiseMessageBox = new PopUpDialogue(title, message, btnLeft, btnCenter, btnRight);
            cutomiseMessageBox.ShowDialog();
            this.title = title;
            this.txtMessage.Text = message;
            this.btnLeft.Text = btnLeft;
            this.btnCenter.Text = btnCenter;
            this.btnRight.Text = btnRight;
            this.btnLeft.DialogResult = DialogResult.OK;
            this.btnLeft.DialogResult = DialogResult.No;
            this.btnLeft.DialogResult = DialogResult.Cancel;
        }
        public DialogResult Show(string title, string message, string btnLeft, string btnCenter, string btnRight)
        {
            var cutomiseMessageBox = new PopUpDialogue( title,  message,  btnLeft, btnCenter, btnRight);
            cutomiseMessageBox.ShowDialog();
            return result;
        }

        //public DialogResult ShowDialog()
        //{
        //    this.Text = title;
        //    //txtMessage.Text = message;
        //    btnLeft.Text = buttonLeft;
        //    btnCenter.Text = buttonCenter;
        //    btnRight.Text = buttonRight;
        //    while (true)
        //    {
        //        if (btnLeftClicked)
        //        {
        //            btnLeftClicked = false;
        //            return DialogResult.OK;
        //        }
        //        if (btnCenterClicked)
        //        {
        //            btnCenterClicked = false;
        //            return DialogResult.No;
        //        }
        //        if (btnRightClicked)
        //        {
        //            btnRightClicked = false;
        //            return DialogResult.Cancel;
        //        }
        //    }

        //    return DialogResult.OK;
        //}

        //public PopUpDialogue(string title,string message,string btnLeft,string btnCenter, string btnRight)
        //{
        //    this.title = title;
        //    this.message = message;
        //    this.buttonLeft = btnLeft;
        //    this.buttonCenter = btnCenter;
        //    this.buttonRight = btnRight;
        // }


        public DialogResult ShowDialogue()
        {
            if (btnLeftClicked)
            {
                btnLeftClicked = false;
                return DialogResult.OK;
            }
            if (btnCenterClicked)
            {
                btnCenterClicked = false;
                return DialogResult.No;
            }
            if (btnRightClicked)
            {
                btnRightClicked = false;
                return DialogResult.Cancel;
            }
            return DialogResult.OK;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            //cutomiseMessageBox.Close();
        }
        private void btnCenter_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            //cutomiseMessageBox.Close();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
            //cutomiseMessageBox.Close();
        }

        private void InitializeComponent()
        {
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 156);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(94, 29);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "button1";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(150, 156);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(94, 29);
            this.btnCenter.TabIndex = 1;
            this.btnCenter.Text = "button2";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(291, 156);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(94, 29);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "button3";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMessage.Location = new System.Drawing.Point(12, 9);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(81, 35);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "label1";
            // 
            // PopUpDialogue
            // 
            this.ClientSize = new System.Drawing.Size(397, 193);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnLeft);
            this.Name = "PopUpDialogue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}

public static class CustomMessageBox
{
    public static DialogResult Show(string title, string message, string btnLeft, string btnCenter, string btnRight)
    {
        // using construct ensures the resources are freed when form is closed
        using (var form = new PopUpDialogue(title, message, btnLeft, btnCenter, btnRight))
        {
            DialogResult result = form.ShowDialog();
            return result;
        }
    }
}
