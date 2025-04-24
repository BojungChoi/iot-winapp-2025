namespace SyntaxWinApp01
{

    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            TxtLog.Text += ("1.폼 생성자 이벤트 실행\r\n");
        }


        private void FrmMain_Load(object sender, EventArgs e) {
            TxtLog.Text += ("2.폼로드 이벤트 실행\r\n");
        }
        private void FrmMain_Activated(object sender, EventArgs e) {
            TxtLog.Text += ("3.폼액티베이트 이벤트 실행\r\n");
        }
        private void FrmMain_Shown(object sender, EventArgs e) { 
            TxtLog.Text += ("4.폼숀 이벤트 실행\r\n");

        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e) {
            MessageBox.Show("5.폼클로징 이벤트 실행", "메시지 창", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) {
            MessageBox.Show("6.폼클로즈드 이벤트 실행", "메시지 창", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 1. 직접호출
            SayHello("Hi~");
            SayGoodbye("By~");


            // 2. 대리자(delegate)호출 (윈앱 개발 핵심!!)
            MyDelegate del = SayHello; // 대리자 호출할 메서드를 묶어줌
            del += SayGoodbye;  // 추가도 가능(대리자 체인 추가) += : 연결이란개념
            //del -= SayHello; // (대리자 체인 삭제)
            del("ㅋㅋ");

            // 3. 반환값없는 대리자 - Action
            Action<string> art = SayHello;
            art("Chris");

            // 4. 반환값 있는 대리자 - Func
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(7, 8);
            Console.WriteLine(result);

        }
        
        
        // 대리자(delegate) 선언
        delegate void MyDelegate(string msg);
        // 이벤트 핸들러 대리자 선언
        delegate void MyEventHandler(object sender, EventArgs e);
        // 이벤트를 선언
        public event EventHandler SoemtingHappend;

        // 대리자에서 호출할 메서드 - 대리자와 파라미터(string msg)가 일치
        void SayHello(string msg)
        {
            MessageBox.Show($"안녕,{msg}", "메시지 창", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SayGoodbye(string msg)
        {
            MessageBox.Show($"내일보재이~ ,{msg}", "메시지 창", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





    }
}
