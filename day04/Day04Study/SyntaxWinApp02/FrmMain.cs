namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 실제로 DB에서 데이터로드 후 아래의 작업들을 수행
            // 배열생성
            string[] fruits = { "사과", "바나나", "딸기", "망고", "블루베리" };
            CboArray.Items.AddRange(fruits);    // 배열을 ComboBox에 추가Items 속성->addRange() 메서드 사용
            CboArray.SelectedIndex = 0; // ComboBox의 선택된 인덱스 설정 [0] -> 사과

            // 리스트 생성 - 둘중 어느 방법이든 사용가능
            List<string> lFruits = ["용과", "망고스틴", "애플망고", "자몽"];
            //List<string> lFruits = new List<string>();
            //lFruits.Add("용과");
            //lFruits.Add("망고스틴");
            //lFruits.Add("애플망고");
            //lFruits.Add("자몽");
            CboList.DataSource = lFruits;


            // 딕셔너리 생성 - DB핸들링시 가장 많이 사용되는 방식
            Dictionary<string, string> dCountry = new Dictionary<string, string>()
            {
                { "KR", "대한민국" },
                { "US", "미국" },
                { "JP", "일본" },
                { "CN", "중국" },
                { "IN", "인도"},
                { "PH", "필리핀"},
            };
            CboDictionary.DataSource = new BindingSource(dCountry, null);
            CboDictionary.DisplayMember = "Value"; // 사용자에게 보여줄 값
            CboDictionary.ValueMember = "Key"; // 내부적으로 선택되는 값

            // foreach문을 사용하여 반복 처리
            string result = "";
            foreach (var item in dCountry)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void CboArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SelectedItem 은 object 타입이므로 string으로 변환
            string selected = CboArray.SelectedItem.ToString();
            MessageBox.Show($"선택한과일은 {selected}입니다", "좋아하는과일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = CboList.SelectedItem.ToString();
            MessageBox.Show(selected, "선택된과일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CboDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kvp = (KeyValuePair<string, string>)CboDictionary.SelectedItem;
            string key = kvp.Key; // Key
            string value = kvp.Value; // Value
            MessageBox.Show($"선택된 국가코드는 {key}이고, 국가는 {value}입니다", "국가정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
