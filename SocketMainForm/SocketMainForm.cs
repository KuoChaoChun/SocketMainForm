using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketMainForm
{
    public partial class SocketMainForm : Form
    {
        public SocketMainForm()
        {
            InitializeComponent();
        }


        private void RequestBtn_Click(object sender, EventArgs e)
        {

        }

        //// Client
        // 確認是否有，輸入IP、PORT、FILENAME、欲儲存的電腦路徑
        // 連線到指定IP、PORT
        // 回傳連線結果，連線成功訊息+路徑 or 失敗訊息
        // 斷線

        //// Server
        // 取得IP、PORT、FILENAME、欲儲存的電腦路徑


        // SocketTopics
    }
}
