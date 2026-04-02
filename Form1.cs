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
                MessageBox.Show("로그인 성공!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("로그인 실패~", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
