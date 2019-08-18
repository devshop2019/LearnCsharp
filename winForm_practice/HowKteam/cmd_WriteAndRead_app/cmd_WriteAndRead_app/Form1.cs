using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cmd_WriteAndRead_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_runCMD_Click(object sender, EventArgs e)
        {
            string cmdCommand = "ping howkteam.com";

            Process cmd = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";             // Mở CMD
            startInfo.CreateNoWindow = false;           // False là hiển thị window
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;

            cmd.StartInfo = startInfo;
            cmd.Start();

            cmd.StandardInput.WriteLine(cmdCommand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            string result = cmd.StandardOutput.ReadToEnd();

            MessageBox.Show(result);
        }

        private void btn_cmdRunNgam_Click(object sender, EventArgs e)
        {
            //string cmdCommand = "ping howkteam.com";
            //string cmdCommand2 = "ping hshop.vn";

            //string cmdCommand = @"G:\Hshop_Program\Arduino_Program\arduino_1_8_7_MyLib\hardware\tools\avr/bin/avrdude -CG:\Hshop_Program\Arduino_Program\arduino_1_8_7_MyLib\hardware\tools\avr/etc/avrdude.conf -v -patmega328p -cusbasp -Pusb -e -Ulock:w:0x3F:m -Uefuse:w:0xFD:m -Uhfuse:w:0xDE:m -Ulfuse:w:0xFF:m";
            //string cmdCommand2 = @"G:\Hshop_Program\Arduino_Program\arduino_1_8_7_MyLib\hardware\tools\avr/bin/avrdude -CG:\Hshop_Program\Arduino_Program\arduino_1_8_7_MyLib\hardware\tools\avr/etc/avrdude.conf -v -patmega328p -cusbasp -Pusb -Uflash:w:G:\Hshop_Program\Arduino_Program\arduino_1_8_7_MyLib\hardware\arduino\avr/bootloaders/optiboot/optiboot_atmega328.hex:i -Ulock:w:0x0F:m";

            //string cmdCommand = @"G:\Hshop_Program\Arduino_Program\arduino_1_8_7_MyLib\hardware\tools\avr/bin/avrdude -CG:\Hshop_Program\Arduino_Program\arduino_1_8_7_MyLib\hardware\tools\avr/etc/avrdude.conf -v -patmega328p -cusbasp -Pusb -e -Ulock:w:0x3F:m -Uefuse:w:0xFD:m -Uhfuse:w:0xDE:m -Ulfuse:w:0xFF:m";
            //string cmdCommand2 = @"G:\Hshop_Program\Arduino_Program\arduino_1_8_7_MyLib\hardware\tools\avr/bin/avrdude -CG:\Hshop_Program\Arduino_Program\arduino_1_8_7_MyLib\hardware\tools\avr/etc/avrdude.conf -v -patmega328p -cusbasp -Pusb -Uflash:w:G:\MyCloud\Mediafire\MakerShop\Sanxuat\QC_arduino_firmware\XLoader\usbasbProgramer/QC_Firmware_Uno_with_bootloader.hex:i -Ulock:w:0x0F:m";

            string currentDir = AppDomain.CurrentDomain.BaseDirectory;

            string cmdCommand = string.Format("{0}avrdude -C{0}avrdude.conf -v -patmega328p -cusbasp -Pusb -e -Ulock:w:0x3F:m -Uefuse:w:0xFD:m -Uhfuse:w:0xDE:m -Ulfuse:w:0xFF:m", currentDir);
            string cmdCommand2 = string.Format("{0}avrdude -C{0}avrdude.conf",currentDir) + @" -v -patmega328p -cusbasp -Pusb -Uflash:w:G:\MyCloud\Mediafire\MakerShop\Sanxuat\QC_arduino_firmware\XLoader\usbasbProgramer/QC_Firmware_Uno_with_bootloader.hex:i -Ulock:w:0x0F:m";

            Process cmd = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";             // Mở CMD
            //startInfo.CreateNoWindow = false;           // False là hiển thị window
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;

            cmd.StartInfo = startInfo;
            cmd.Start();

            #region Gui 2 Command lien tiep: Command nay chay xong mới chạy command sau

            //cmd.StandardInput.WriteLine(cmdCommand);
            //cmd.StandardInput.WriteLine(cmdCommand2);
            //cmd.StandardInput.Flush();
            //cmd.StandardInput.Close();
            //cmd.WaitForExit();

            #endregion

            #region chay Command 1, cho kết quả rồi mới chạy Command2 => fail (cách 1)

            //cmd.StandardInput.WriteLine(cmdCommand);
            //cmd.StandardInput.Flush();
            //string result = cmd.StandardOutput.ReadToEnd();

            //MessageBox.Show(result);

            //cmd.StandardInput.WriteLine(cmdCommand2);
            //cmd.StandardInput.Flush();
            //result = cmd.StandardOutput.ReadToEnd();

            //MessageBox.Show(result);

            ////cmd.StandardInput.Flush();

            //cmd.StandardInput.Close();
            //cmd.WaitForExit();

            #endregion

            #region chay Command 1, cho kết quả rồi mới chạy Command2 => (cách 2)

            cmd.StandardInput.WriteLine(cmdCommand);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            string result1 = cmd.StandardOutput.ReadToEnd();

            Console.WriteLine(result1);
            MessageBox.Show(result1);

            cmd.Start();
            cmd.StandardInput.WriteLine(cmdCommand2);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            //string result2 = cmd.StandardOutput.ReadToEnd();

            //MessageBox.Show(result2);

            #endregion

            string result = cmd.StandardOutput.ReadToEnd();

            #region Show StandardOuput line by line
            //// chua thu: https://stackoverflow.com/questions/21027400/how-to-read-standard-output-line-by-line

            /////https://csharp.today/how-to-avoid-deadlocks-when-reading-redirected-child-console-in-c-part-2/
            //using (var process = Process.Start(startInfo))
            //{
            //    process.OutputDataReceived += (sender, eventArgs) => Console.WriteLine("OUTPUT: " + eventArgs.Data);
            //    process.ErrorDataReceived += (sender, eventArgs) => Console.WriteLine("ERROR: " + eventArgs.Data);

            //    process.BeginOutputReadLine();
            //    process.BeginErrorReadLine();

            //    process.WaitForExit();
            //}

            #endregion


            Console.WriteLine(result);

            MessageBox.Show(result);
        }

        private void btn_readPath_Click(object sender, EventArgs e)
        {
            string currentDir = AppDomain.CurrentDomain.BaseDirectory;
            string showPathstr = string.Format("Đường dẫn là {0}   ^^", currentDir);
            MessageBox.Show(showPathstr);
        }

        
    }
}
