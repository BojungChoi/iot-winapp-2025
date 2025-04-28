using System.Management; // WMI 사용하려면 필요

namespace WinFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (var Font in Fonts)
            {
                CboFonts.Items.Add(Font.Name);
            }

            // 기본 글꼴 지정
            string defaultFontName = "맑은 고딕";

            if (CboFonts.Items.Contains(defaultFontName))
            {
                CboFonts.SelectedItem = defaultFontName;
            }
            else if (CboFonts.Items.Count > 0)
            {
                CboFonts.SelectedIndex = 0;
            }

            // 글꼴 적용
            ChangeFont();

            // 상태 초기화
            LblState.Text = "상태 : 폰트읽기 완료";

            TxtCpu.Text = "";
            TxtRam.Text = "";
            TxtGpu.Text = "";
            TxtDisk.Text = "";
            TxtOs.Text = "";
            TxtBoard.Text = "";

            // 🌟 추가 : PbxLoading 설정
            try
            {
                PbxLoading.Image = Image.FromFile("C:\\Source\\iot-winapp-2025\\image\\Loading.gif"); // 너가 넣은 피젯스피너 GIF 파일명
                PbxLoading.SizeMode = PictureBoxSizeMode.Zoom;
                PbxLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"로딩 스피너 GIF 파일을 불러오는 데 실패했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BtnRefresh.Tag = BtnRefresh.BackColor;
            BtnClear.Tag = BtnClear.BackColor;

            BtnRefresh.MouseCaptureChanged += Button_MouseCaptureChanged;
            BtnClear.MouseCaptureChanged += Button_MouseCaptureChanged;
        }

        private void Button_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Color originalColor)
            {
                btn.BackColor = originalColor;
            }
        }
        private void ChangeFont()
        {
            if (CboFonts.SelectedItem is not string fontName) return;
            FontStyle style = FontStyle.Regular;
            if (ChkBold.Checked) style |= FontStyle.Bold;
            if (ChkItalic.Checked) style |= FontStyle.Italic;

            // 기존 텍스트박스 폰트 크기를 유지한 채, 글꼴과 스타일만 변경
            float fontSize = TxtCpu.Font.Size;
            Font newFont = new Font(fontName, fontSize, style);

            TxtCpu.Font = newFont;
            TxtBoard.Font = newFont;
            TxtDisk.Font = newFont;
            TxtGpu.Font = newFont;
            TxtOs.Font = newFont;
            TxtRam.Font = newFont;
        }

        private string GetCpuInfo()
        {
            string cpuName = "정보 없음";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    cpuName = obj["Name"].ToString();
                    Thread.Sleep(500); // 0.5초 딜레이
                }
            }
            return cpuName;
        }

        private string GetCpuDetailInfo()
        {
            string result = "정보 없음";

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string name = obj["Name"]?.ToString() ?? "정보 없음";
                    uint numberOfCores = (uint)(obj["NumberOfCores"] ?? 0);
                    uint numberOfLogicalProcessors = (uint)(obj["NumberOfLogicalProcessors"] ?? 0);
                    uint maxClockSpeed = (uint)(obj["MaxClockSpeed"] ?? 0);
                    string socketDesignation = obj["SocketDesignation"]?.ToString() ?? "정보 없음";
                    uint l2CacheSize = (uint)(obj["L2CacheSize"] ?? 0);
                    uint l3CacheSize = (uint)(obj["L3CacheSize"] ?? 0);

                    result = $"이름: {name}\r\n" +
                             $"코어 수: {numberOfCores}\r\n" +
                             $"쓰레드 수: {numberOfLogicalProcessors}\r\n" +
                             $"기본 클럭: {maxClockSpeed} MHz\r\n" +
                             $"소켓 타입: {socketDesignation}\r\n" +
                             $"L2 캐시: {l2CacheSize} KB\r\n" +
                             $"L3 캐시: {l3CacheSize} KB";
                }
            }

            return result;
        }



        private string GetRamInfo()
        {
            double totalMemory = 0;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_ComputerSystem"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    totalMemory = Math.Round(Convert.ToDouble(obj["TotalPhysicalMemory"]) / (1024 * 1024 * 1024), 2); // GB 단위
                }
            }
            return totalMemory + " GB";
        }

        private string GetRamDetailInfo()
        {
            string result = "";

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string deviceLocator = obj["DeviceLocator"]?.ToString() ?? "슬롯 정보 없음";
                    string manufacturer = obj["Manufacturer"]?.ToString() ?? "제조사 정보 없음";

                    ulong capacityBytes = 0;
                    if (obj["Capacity"] != null)
                        capacityBytes = Convert.ToUInt64(obj["Capacity"]); // ⭐ 수정포인트

                    double capacityGB = Math.Round(capacityBytes / (1024.0 * 1024 * 1024), 2);

                    ushort memoryTypeCode = 0;
                    if (obj["MemoryType"] != null)
                        memoryTypeCode = Convert.ToUInt16(obj["MemoryType"]);

                    uint speed = 0;
                    if (obj["Speed"] != null)
                        speed = Convert.ToUInt32(obj["Speed"]);

                    string memoryType = GetMemoryTypeName(memoryTypeCode);

                    result += $"슬롯: {deviceLocator}\r\n" +
                              $"제조사: {manufacturer}\r\n" +
                              $"용량: {capacityGB} GB\r\n" +
                              $"메모리 타입: {memoryType}\r\n" +
                              $"속도: {speed} MHz\r\n" +
                              $"----------------------------\r\n";
                }
            }

            if (string.IsNullOrWhiteSpace(result))
                result = "RAM 정보를 불러올 수 없습니다.";

            return result.Trim();
        }



        private string GetMemoryTypeName(ushort code)
        {
            return code switch
            {
                20 => "DDR",   // DDR
                21 => "DDR2",
                24 => "DDR3",
                26 => "DDR4",
                27 => "DDR5",
                _ => "Unknown"
            };
        }

        private string GetGpuInfo()
        {
            string gpuName = "정보 없음";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    gpuName = obj["Name"]?.ToString();
                    break; // 여러 개면 첫 번째만
                }
            }
            return gpuName;
        }
        private string GetGpuDetailInfo()
        {
            string result = "";

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string name = obj["Name"]?.ToString() ?? "정보 없음";

                    ulong adapterRamBytes = 0;
                    if (obj["AdapterRAM"] != null)
                        adapterRamBytes = Convert.ToUInt64(obj["AdapterRAM"]); // ⭐ 수정포인트

                    double adapterRamGB = Math.Round(adapterRamBytes / (1024.0 * 1024 * 1024), 2);

                    string driverVersion = obj["DriverVersion"]?.ToString() ?? "정보 없음";
                    string status = obj["Status"]?.ToString() ?? "정보 없음";

                    string resolution = "해상도 정보 없음";
                    try
                    {
                        var width = Convert.ToUInt32(obj["CurrentHorizontalResolution"]);
                        var height = Convert.ToUInt32(obj["CurrentVerticalResolution"]);
                        resolution = $"{width} x {height}";
                    }
                    catch { }

                    result += $"GPU 이름: {name}\r\n" +
                              $"메모리 크기: {adapterRamGB} GB\r\n" +
                              $"해상도: {resolution}\r\n" +
                              $"드라이버 버전: {driverVersion}\r\n" +
                              $"상태: {status}\r\n" +
                              $"----------------------------\r\n";
                }
            }

            if (string.IsNullOrWhiteSpace(result))
                result = "GPU 정보를 불러올 수 없습니다.";

            return result.Trim();
        }


        private string GetDiskInfo()
        {
            string result = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_DiskDrive"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string model = obj["Model"]?.ToString();
                    ulong size = (ulong)obj["Size"];
                    double sizeGB = Math.Round(size / (1024.0 * 1024 * 1024), 2);
                    result += $"{model} - {sizeGB} GB\r\n";
                }
            }
            return result.Trim();
        }
        private string GetDiskDetailInfo()
        {
            string result = "";

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_DiskDrive"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string model = obj["Model"]?.ToString() ?? "모델 정보 없음";
                    ulong sizeBytes = (ulong)(obj["Size"] ?? 0);
                    double sizeGB = Math.Round(sizeBytes / (1024.0 * 1024 * 1024), 2);
                    string interfaceType = obj["InterfaceType"]?.ToString() ?? "인터페이스 정보 없음";
                    string mediaType = obj["MediaType"]?.ToString() ?? "미디어 타입 정보 없음";
                    string serialNumber = obj["SerialNumber"]?.ToString() ?? "시리얼 없음";
                    string firmwareRevision = obj["FirmwareRevision"]?.ToString() ?? "펌웨어 정보 없음";

                    result += $"모델명: {model}\r\n" +
                              $"용량: {sizeGB} GB\r\n" +
                              $"인터페이스: {interfaceType}\r\n" +
                              $"미디어 타입: {mediaType}\r\n" +
                              $"시리얼 번호: {serialNumber}\r\n" +
                              $"펌웨어 버전: {firmwareRevision}\r\n" +
                              $"----------------------------\r\n";
                }
            }

            if (string.IsNullOrWhiteSpace(result))
                result = "디스크 정보를 불러올 수 없습니다.";

            return result.Trim();
        }



        private string GetOsInfo()
        {
            string osInfo = "정보 없음";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    osInfo = $"{obj["Caption"]} ({obj["Version"]})";
                }
            }
            return osInfo;
        }
        private string GetOsDetailInfo()
        {
            string result = "";

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_OperatingSystem"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string caption = obj["Caption"]?.ToString() ?? "정보 없음";
                    string version = obj["Version"]?.ToString() ?? "정보 없음";
                    string installDate = ConvertWmiDateTime(obj["InstallDate"]?.ToString());
                    string lastBootUpTime = ConvertWmiDateTime(obj["LastBootUpTime"]?.ToString());
                    string architecture = obj["OSArchitecture"]?.ToString() ?? "정보 없음";
                    string serialNumber = obj["SerialNumber"]?.ToString() ?? "정보 없음";

                    result = $"OS 이름: {caption}\r\n" +
                             $"버전: {version}\r\n" +
                             $"설치 날짜: {installDate}\r\n" +
                             $"마지막 부팅 시간: {lastBootUpTime}\r\n" +
                             $"아키텍처: {architecture}\r\n" +
                             $"시리얼 번호: {serialNumber}";
                }
            }

            if (string.IsNullOrWhiteSpace(result))
                result = "OS 정보를 불러올 수 없습니다.";

            return result.Trim();
        }
        private string ConvertWmiDateTime(string wmiDate)
        {
            if (string.IsNullOrWhiteSpace(wmiDate) || wmiDate.Length < 14)
                return "날짜 정보 없음";

            try
            {
                int year = int.Parse(wmiDate.Substring(0, 4));
                int month = int.Parse(wmiDate.Substring(4, 2));
                int day = int.Parse(wmiDate.Substring(6, 2));
                int hour = int.Parse(wmiDate.Substring(8, 2));
                int minute = int.Parse(wmiDate.Substring(10, 2));
                int second = int.Parse(wmiDate.Substring(12, 2));

                DateTime dateTime = new DateTime(year, month, day, hour, minute, second);
                return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            catch
            {
                return "날짜 변환 실패";
            }
        }

        private string GetMotherboardInfo()
        {
            string boardInfo = "정보 없음";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_BaseBoard"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    boardInfo = $"{obj["Manufacturer"]} - {obj["Product"]}";
                }
            }
            return boardInfo;
        }
        private string GetMotherboardDetailInfo()
        {
            string boardInfo = "";
            string biosInfo = "";

            // 메인보드 정보 가져오기
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_BaseBoard"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string manufacturer = obj["Manufacturer"]?.ToString() ?? "정보 없음";
                    string product = obj["Product"]?.ToString() ?? "정보 없음";
                    string version = obj["Version"]?.ToString() ?? "정보 없음";
                    string serialNumber = obj["SerialNumber"]?.ToString() ?? "정보 없음";

                    boardInfo = $"[ 메인보드 정보 ]\r\n" +
                                $"제조사: {manufacturer}\r\n" +
                                $"제품명: {product}\r\n" +
                                $"버전: {version}\r\n" +
                                $"시리얼 번호: {serialNumber}\r\n";
                }
            }

            // BIOS 정보 가져오기
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_BIOS"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string biosManufacturer = obj["Manufacturer"]?.ToString() ?? "정보 없음";
                    string biosVersion = obj["SMBIOSBIOSVersion"]?.ToString() ?? "정보 없음";
                    string releaseDate = ConvertWmiDateTime(obj["ReleaseDate"]?.ToString());

                    biosInfo = $"[ BIOS 정보 ]\r\n" +
                               $"BIOS 제조사: {biosManufacturer}\r\n" +
                               $"BIOS 버전: {biosVersion}\r\n" +
                               $"릴리즈 날짜: {releaseDate}";
                }
            }

            return boardInfo + "\r\n" + biosInfo;
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            PbxLoading.Visible = true;  // 로딩 스피너 보이기
            PrgProcess.Minimum = 0;
            PrgProcess.Maximum = 100;
            PrgProcess.Value = 0;
            LblState.Text = "상태 : 정보 수집 중...";

            await LoadSystemInfoAsync(); // 정보 로딩 기다리기

            ChangeFont();

            PbxLoading.Visible = false; // 로딩 스피너 숨기기
            LblState.Text = "상태 : 완료";
        }


        // 비동기 작업 함수 만들기
        private async Task LoadSystemInfoAsync()
        {
            PrgProcess.Value = 0;

            string cpuInfo = await Task.Run(() => GetCpuInfo());
            string cpuDetailInfo = await Task.Run(() => GetCpuDetailInfo());
            TxtCpu.Text = cpuInfo;
            toolTip1.SetToolTip(TxtCpu, cpuDetailInfo);

            PrgProcess.Value = 20;
            await Task.Delay(300);

            string ramInfo = await Task.Run(() => GetRamInfo());
            string ramDetailInfo = await Task.Run(() => GetRamDetailInfo());
            TxtRam.Text = ramInfo;
            toolTip1.SetToolTip(TxtRam, ramDetailInfo);

            PrgProcess.Value = 40;
            await Task.Delay(300);

            string gpuInfo = await Task.Run(() => GetGpuInfo());
            string gpuDetailInfo = await Task.Run(() => GetGpuDetailInfo());
            TxtGpu.Text = gpuInfo;
            toolTip1.SetToolTip(TxtGpu, gpuDetailInfo);

            PrgProcess.Value = 60;
            await Task.Delay(300);

            string diskInfo = await Task.Run(() => GetDiskInfo());
            string diskDetailInfo = await Task.Run(() => GetDiskDetailInfo());
            TxtDisk.Text = diskInfo;
            toolTip1.SetToolTip(TxtDisk, diskDetailInfo);

            PrgProcess.Value = 80;
            await Task.Delay(300);

            string osInfo = await Task.Run(() => GetOsInfo());
            string osDetailInfo = await Task.Run(() => GetOsDetailInfo());
            TxtOs.Text = osInfo;
            toolTip1.SetToolTip(TxtOs, osDetailInfo);

            PrgProcess.Value = 90;
            await Task.Delay(300);

            string boardInfo = await Task.Run(() => GetMotherboardInfo());
            string boardDetailInfo = await Task.Run(() => GetMotherboardDetailInfo());
            TxtBoard.Text = boardInfo;
            toolTip1.SetToolTip(TxtBoard, boardDetailInfo); // 🧠 메인보드 상세 툴팁 추가

            PrgProcess.Value = 100;

        }


        private void MnuExist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing; // 폼클로징 이벤트를 삭제
                Application.Exit(); // 프로그램 완전 종료
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // 종료를 안 시키는 것
            }
        }

        private void PrgProcess_Click(object sender, EventArgs e) { }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtCpu.Text = "";
            TxtRam.Text = "";
            TxtGpu.Text = "";
            TxtDisk.Text = "";
            TxtOs.Text = "";
            TxtBoard.Text = "";
        }

        private void MnuOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var lines = File.ReadAllLines(ofd.FileName);

                    foreach (var line in lines)
                    {
                        if (line.StartsWith("CPU: ")) TxtCpu.Text = line.Substring(5);
                        else if (line.StartsWith("RAM: ")) TxtRam.Text = line.Substring(5);
                        else if (line.StartsWith("GPU: ")) TxtGpu.Text = line.Substring(5);
                        else if (line.StartsWith("DISK: ")) TxtDisk.Text = line.Substring(6);
                        else if (line.StartsWith("OS: ")) TxtOs.Text = line.Substring(4);
                        else if (line.StartsWith("BOARD: ")) TxtBoard.Text = line.Substring(7);
                    }
                }
            }
        }

        private void MnuSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines =
                    {
                        $"CPU: {TxtCpu.Text}",
                        $"RAM: {TxtRam.Text}",
                        $"GPU: {TxtGpu.Text}",
                        $"DISK: {TxtDisk.Text}",
                        $"OS: {TxtOs.Text}",
                        $"BOARD: {TxtBoard.Text}"
                    };

                    File.WriteAllLines(sfd.FileName, lines);
                }
            }
        }

        private void BtnRefresh_MouseEnter(object sender, EventArgs e)
        {
            BtnRefresh.BackColor = Color.FromArgb(70, 130, 180);
        }

        private void BtnRefresh_MouseLeave(object sender, EventArgs e)
        {
            if (BtnRefresh.Tag is Color originalColor)
            {
                BtnRefresh.BackColor = Color.White;
            }
        }

        private void BtnClear_MouseEnter(object sender, EventArgs e)
        {
            BtnClear.BackColor = Color.FromArgb(70, 130, 180);
        }

        private void BtnClear_MouseLeave(object sender, EventArgs e)
        {
            if (BtnClear.Tag is Color originalColor)
            {
                BtnRefresh.BackColor = Color.White;
            }
        }
    }
}