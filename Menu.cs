using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGcam
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        string cam = "";

        async void Cameras(string cam)
        {
            await webView21.EnsureCoreWebView2Async(null);
            
            switch (cam)
                {
                case "bh1":
                    webView21.CoreWebView2.Navigate($"https://playersdevideo.com/links/2022/1625315876.html");
                    break;
                case "bh2":
                    //MessageBox.Show($"em manutenção");
                    //webView21.CoreWebView2.Navigate($"https://www.youtube.com/embed/7GPrsPcMxBk?autoplay=1&controls=0&loop=1&start=1");

                    //await Task.Delay(2000);
                    //webView21.CoreWebView2.Navigate($"https://www.youtube.com/embed/cI7qlP70woM");
                    //await Task.Delay(2000);
                    webView21.CoreWebView2.Navigate($"https://www.youtube.com/embed/cI7qlP70woM?autoplay=1&rel=0&modestbranding=1&autohide=1&showinfo=0&controls=0&rel=0&");
                    string result = await webView21.ExecuteScriptAsync("document.getElementById('player')");
                    await webView21.ExecuteScriptAsync($"alert('play');");


                    break;

                case "jf1":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=1");
                    break;
                case "jf2":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=2");
                    break;
                case "jf3":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=3");
                    break;
                case "jf4":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=4");
                    break;
                case "jf5":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=5");
                    break;
                case "jf6":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=6");
                    break;
                case "jf7":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=7");
                    break;
                case "jf8":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=8");
                    break;
                case "jf9":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=9");
                    break;
                case "jf10":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=10");
                    break;
                case "jf11":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=11");
                    break;
                case "jf12":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=12");
                    break;
                case "jf13":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=13");
                    break;
                case "jf14":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=14");
                    break;
                case "jf15":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=15");
                    break;
                case "jf16":
                    webView21.CoreWebView2.Navigate("http://camerasjf.gctnet.com.br:8880/cameras/?cam=16");
                    break;

                case "bru1":
                    webView21.CoreWebView2.Navigate("https://www.teclockcitylive.com.br/embed/315697/undefined/undefined/rua-bancos?autoplay=true&sound=true");
                    break;
                case "bru2":
                    webView21.CoreWebView2.Navigate("https://www.teclockcitylive.com.br/embed/566998/undefined/undefined/parkin-do-markin-1?autoplay=true&sound=true");
                    break;
                case "bru3":
                    webView21.CoreWebView2.Navigate("https://www.teclockcitylive.com.br/embed/588184/undefined/undefined/praca-da-bandeira?autoplay=true&sound=true");
                    break;
                case "bru4":
                    webView21.CoreWebView2.Navigate("https://www.teclockcitylive.com.br/embed/532735/undefined/undefined/rua-chicona-saida-entrada?autoplay=true&sound=true");
                    break;
                case "bru5":
                    webView21.CoreWebView2.Navigate("https://www.teclockcitylive.com.br/embed/545197/undefined/undefined/praca-da-rodoviaria-brumadinho?autoplay=true&sound=true");
                    break;

                case "and1":
                    webView21.CoreWebView2.Navigate("https://player.jmvstream.com/ipcam/r8kJd2eJcilWrvcZ80thAenXbQy9G0");
                    break;

                default:
                    webView21.CoreWebView2.Navigate("https://d2x3xhvgiqkx42.cloudfront.net/12345678-1234-1234-1234-1234567890ab/2016/12/31/a9b2c472-a835-437c-a869-ddab4d9aeca5.png");
                    await Task.Delay(30000);
                    webView21.Refresh();
                    break;
            }

        }


        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MinasGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WebView21_Click_1(object sender, EventArgs e)
        {

        }

        private void CAM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cam = "jf1";
            Cameras(cam);
        }

        private void CAM2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf2";
            Cameras(cam);
        }

        private void CAM3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf3";
            Cameras(cam);
        }

        private void CAM4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf4";
            Cameras(cam);
        }

        private void CAM5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf5";
            Cameras(cam);
        }

        private void CAM6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf6";
            Cameras(cam);
        }

        private void CAM7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf7";
            Cameras(cam);
        }

        private void CAM8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf8";
            Cameras(cam);
        }

        private void CAM9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf9";
            Cameras(cam);
        }

        private void CAM10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf10";
            Cameras(cam);
        }

        private void CAM11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf11";
            Cameras(cam);
        }

        private void CAM12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf12";
            Cameras(cam);
        }

        private void CAM13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf13";
            Cameras(cam);
        }

        private void CAM14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf14";
            Cameras(cam);
        }

        private void CAM15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cam = "jf15";
            Cameras(cam);
        }

        private void CAM16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             cam = "jf16";
            Cameras(cam);
        }

        private void CAM1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string cam = "bh1";
            Cameras(cam);
        }

        private void cAM1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            cam = "bru1";
            Cameras(cam);        
        }

        private void cAM2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cam = "bru2";
            Cameras(cam);
        }

        private void cAM3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cam = "bru3";
            Cameras(cam);
        }

        private void cAM4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cam = "bru4";
            Cameras(cam);
        }

        private void cAM5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cam = "bru5";
            Cameras(cam);
        }

        private void picoDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cam = "and1";
            Cameras(cam);
            /*
             https://www.picodogaviao.esp.br/cameraAoVivo
            PICO DO GAVIAO ESPORTES E AVENTURA - 86.888.146/0001-30
            Estrada Paulo Roberto Dezena - Gavião | Andradas - MG/Águas da Prata - SP
             */
        }

        private void aeroportoConfinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cam = "bh2";
            Cameras(cam);
        }
    }
}
