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


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnRefresh.PerformClick(); // 자동으로 새로고침
        }

        private string GetCpuInfo()
        {
            string cpuName = "정보 없음";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    cpuName = obj["Name"].ToString();
                }
            }
            return cpuName;
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


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TxtCpu.Text = GetCpuInfo();
            TxtRam.Text = GetRamInfo();
            TxtGpu.Text = GetGpuInfo();
            TxtDisk.Text = GetDiskInfo();
            TxtOs.Text = GetOsInfo();
            TxtBoard.Text = GetMotherboardInfo();
        }

        private void TxtCpu_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
