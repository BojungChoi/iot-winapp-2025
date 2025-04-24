namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int add(int x, int y)
        {
            return x + y; // 한줄짜리
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            int result = add(10, 5);

            //        대리자         = 람다식
            Func<int, int, int> add2 = (x, y) => x + y;
            TxtLog.Text += result + "\r\n";
            TxtLog.Text += add2(10, 6) + "\r\n";


            // SayHello 함수 생성대신
            Action<string> sayHello = name => MessageBox.Show($"안녕,{name}", "인사",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            sayHello("뽀룡");

            // LINQ 사용 이전
            List<int> resList = new List<int>();
            List<int> numbers = [4, 10, 1, 5, 9, 8, 6, 2, 3, 7];

            // 짝수만 추출해서 오름차순 정렬 하는 로직
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    resList.Add(n);
                }
            }
            TxtLog.Text += "전통 짝수리스트 > " + string.Join(", ", resList) + "\r\n";


            resList.Sort();

            //TxtLog.Text += "정렬리스트" + resList + "\r\n";
            TxtLog.Text += "전통 정렬리스트 > " + string.Join(", ", resList) + "\r\n";

            // 기본 LINQ 방식 > 줄로 위의 전통방식을 처리
            numbers = [14, 20, 11, 15, 18, 19, 16, 13, 12, 17];
            var resList2 = from n in numbers
                           where n % 2 == 0
                           orderby n
                           select n;
            TxtLog.Text += "링큐1 정렬리스트 > " + string.Join(",", resList2) + "\r\n";

            // LINQ Method Chaining
            numbers = [24, 30, 21, 25, 28, 29, 26, 23, 22, 27];
            var resList3 = numbers.Where(n => n % 2 == 0).OrderBy(n => n);
            TxtLog.Text += "링큐2 정렬리스트 > " + string.Join(",", resList3) + "\r\n";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // UI 초기화
            TxtTest.PlaceholderText = "테스트입니다.";
            TxtTest.Size = new Size(250, 23);
            TxtTest.KeyPress += TxtTest_KeyPress;
            TxtTest.Font = new Font("나눔고딕", 10, FontStyle.Italic);
        }
        private void TxtTest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  // == Keys.Enter와 동일
            {
                MessageBox.Show("엔터를 쳤습니다.", "키프레스", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnGeneric_Click(object sender, EventArgs e)
        {
            // 기본
            Print<int>(100);
            Print<float>(3.141592f);
            Print<string>("안녕,뽀룡!");
            Print<Boolean>(false);

            // 생략가능 - 편의성을 위해서
            Print(200);
            Print(5.141592f);
            Print("잘가,뽀룡!");
            Print(true);

            // 제네릭 클래스 사용
            Box<int> intBox = new Box<int>();
            intBox.Value = 300;
            intBox.Show();

            Box<string> stringBox = new Box<string>();
            stringBox.Value = "뽀룡스";
            stringBox.Show();

        }

        public void Print<T>(T data) { Console.WriteLine(data); }
    }

    // 제네릭 클래스
    //public class Box<T> where T : struct // <- 이거넣으면 string 안됨. (값형식만받기)
    //public class Box<T> where T : class // <- 이거넣으면 int 는 안됨. (클래스만 허용)
    public class Box<T> 
    {

        public T Value { get; set; } // 속성
        // private T value; // 멤버변수

        public void Show()
        {
            MessageBox.Show($"Box의 값 : {Value}","BOX값" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
