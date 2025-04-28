using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudyApp04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> fruitItems {  get; set; }
        
        public Dictionary<string, string> countryItems { get; set; }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fruitItems = new ObservableCollection<string>
            {
                "용과",
                "망고스틴",
                "애플망고",
                "자몽",
                "두리안"
            };


            countryItems = new Dictionary<string, string>
            {
                {"KR","대한민국" },
                {"US","미국" },
                {"JP","일본" },
                {"CN","중국" },
                {"IN","인도" },
                {"PH","필리핀" },
            };
            
            
            //윈앱의 컨트롤 .DataSoucrce와 동일한 속성
            CboCollection.ItemsSource = fruitItems;

            LoadDivisionFromDatabase();

            // WPF.xaml의 전체의 데이터컨텍스트에 현재값을 바인딩
            // this.DataContext = this;와 동일한 기능
            // 대신 데이터를 전달하는 레벨은 다름
            this.DataContext = this;    // 반드시 실행
            //CboFruits.DataContext = this // 조심해야함(MainWindow 포함 전체데이터를 다넘김)
        }

        private void LoadDivisionFromDatabase()
        {
            // DB연결문자열(DB연결정보)
            string connectionString = "Server=localhost;Database=bookrentalshop;Uid=root;Pwd=12345;Charset=utf8;";
            string query = "SELECT division, names FROM divtbl"; // 언어에서 쿼리작성시는 ; 사용안됨

            List<KeyValuePair<string, string>> divisions = new List<KeyValuePair<string, string>>();

            // DB연결, 처리, 할당. using을 쓰면 db.close()를 using문이 대신 실행해줌
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // DB연결
                    MySqlCommand cmd = new MySqlCommand(query, conn); // 쿼리전송객체
                    MySqlDataReader reader = cmd.ExecuteReader(); // 쿼리실행

                    while (reader.Read())
                    {
                        var division = reader.GetString("division"); // reader.GetString(0) 은 지양
                        var name = reader.GetString("names");

                        divisions.Add(new KeyValuePair<string, string>(division, name));
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"DB연결이 실패하였습니다. : {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                // conn.Close() //using문에서는 사용하지 않아도 됨
            } // 자동으로 conn.Close()가 실행됨

            CboDivision.ItemsSource = divisions; // DB에서 가져온 데이터로 콤보박스의 데이터소스 설정
        }

        private void CboCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Debug.WriteLine(CboCountries.SelectedItem);
            string value = ((KeyValuePair<string, string>)CboCountries.SelectedItem).Value;
            MessageBox.Show(value, "선택한국가", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}