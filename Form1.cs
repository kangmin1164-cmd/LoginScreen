namespace LoginScreen
{
    public partial class Form1 : Form
    {
        // 프로그램에서 인증에 사용할 고정 아이디와 비밀번호
        string myID = "admin";
        string myPW = "superman";

        public Form1()
        {
            InitializeComponent();
            // 실행 시 아이디와 비밀번호 칸에 힌트 문구와 색상 초기 설정
            txtID.Text = "아이디";
            txtID.ForeColor = Color.Silver;

            txtPW.Text = "패스워드";
            txtPW.ForeColor = Color.Silver;
            txtPW.UseSystemPasswordChar = false;
        }

        // --- Placeholder 및 보안 처리 기능 ---
        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }
        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false; // 힌트 문구를 보여주기 위해 가림 해제
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true; // 입력 시작 시 ●로 가림 처리
            }
        }

        // --- 로그인 버튼 클릭 이벤트 (최종 확인) ---
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;

            // 저장된 정보와 입력된 정보를 비교하여 결과 출력
            if (inputID == myID && inputPW == myPW)
            {
                lblErrorMsg.Visible = false;
                MessageBox.Show("로그인 성공!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblErrorMsg.Visible = true; //오류 발생시 오류라벨 보임
                //MessageBox.Show("로그인 실패~", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 아이디 입력창에서 키를 눌렀을 때 실행
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            // 누른 키가 Enter 키인지 확인
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter 입력 시 발생하는 '띵' 소리 방지
                txtPW.Focus();             // 커서를 비밀번호 입력창으로 이동
            }
        }

        // 비밀번호 입력창에서 키를 눌렀을 때 실행
        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            // 누른 키가 Enter 키인지 확인
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // '띵' 소리 방지
                btnLogin.PerformClick();   // 로그인 버튼을 마우스로 클릭한 것과 동일하게 작동
            }
        }
    }
}
