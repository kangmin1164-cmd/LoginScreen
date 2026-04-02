namespace LoginScreen
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
            lalAppName = new Label();
            btnLogin = new Button();
            txtID = new TextBox();
            txtPW = new TextBox();
            lblErrorMsg = new Label();
            chkPWLook = new CheckBox();
            btnCleanID = new Button();
            btnCleanPW = new Button();
            SuspendLayout();
            // 
            // lalAppName
            // 
            lalAppName.AutoSize = true;
            lalAppName.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lalAppName.Location = new Point(291, 29);
            lalAppName.Name = "lalAppName";
            lalAppName.Size = new Size(219, 90);
            lalAppName.TabIndex = 0;
            lalAppName.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 255);
            btnLogin.Font = new Font("한컴 고딕", 21.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(318, 321);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(164, 64);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("한컴 고딕", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtID.Location = new Point(212, 146);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "아이디";
            txtID.Size = new Size(376, 59);
            txtID.TabIndex = 2;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("한컴 고딕", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtPW.Location = new Point(212, 225);
            txtPW.Name = "txtPW";
            txtPW.PlaceholderText = "패스워드";
            txtPW.Size = new Size(376, 59);
            txtPW.TabIndex = 3;
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(212, 290);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(385, 28);
            lblErrorMsg.TabIndex = 6;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // chkPWLook
            // 
            chkPWLook.AutoSize = true;
            chkPWLook.Font = new Font("맑은 고딕", 16F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkPWLook.Location = new Point(556, 244);
            chkPWLook.Name = "chkPWLook";
            chkPWLook.Size = new Size(22, 21);
            chkPWLook.TabIndex = 5;
            chkPWLook.UseVisualStyleBackColor = true;
            chkPWLook.CheckedChanged += chkPWLook_CheckedChanged;
            // 
            // btnCleanID
            // 
            btnCleanID.BackColor = Color.FromArgb(255, 192, 192);
            btnCleanID.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCleanID.ImageAlign = ContentAlignment.MiddleLeft;
            btnCleanID.Location = new Point(594, 159);
            btnCleanID.Name = "btnCleanID";
            btnCleanID.Size = new Size(44, 42);
            btnCleanID.TabIndex = 6;
            btnCleanID.Text = "X";
            btnCleanID.UseVisualStyleBackColor = false;
            btnCleanID.Click += btnCleanID_Click;
            // 
            // btnCleanPW
            // 
            btnCleanPW.BackColor = Color.FromArgb(255, 192, 192);
            btnCleanPW.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnCleanPW.ImageAlign = ContentAlignment.MiddleLeft;
            btnCleanPW.Location = new Point(594, 238);
            btnCleanPW.Name = "btnCleanPW";
            btnCleanPW.Size = new Size(44, 42);
            btnCleanPW.TabIndex = 7;
            btnCleanPW.Text = "X";
            btnCleanPW.UseVisualStyleBackColor = false;
            btnCleanPW.Click += btnCleanPW_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCleanPW);
            Controls.Add(btnCleanID);
            Controls.Add(chkPWLook);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(btnLogin);
            Controls.Add(lalAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lalAppName;
        private Button btnLogin;
        private TextBox txtID;
        private TextBox txtPW;
        private Label lblErrorMsg;
        private CheckBox chkPWLook;
        private Button btnCleanID;
        private Button btnCleanPW;
    }
}
