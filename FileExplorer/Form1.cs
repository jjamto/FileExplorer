using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //화면상단에 프로그램 및 버전을 표기 함.
            this.Text = ($"{Application.ProductName}_{Application.ProductVersion}");

            //기본폴더를 설정
            this.tbPath.Text = @"D:\ing";

            //파일을 조회
            Refresh_file(tbPath.Text);

            //디렉토리를 조회
            Refresh_path(null);
        }

        /// <summary>
        /// 현재 폴더내의 파일목록을 갱신
        /// </summary>
        void Refresh_file(string path)
        {
            lvFiles.Items.Clear(); //기존의 목록을 제거
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(tbPath.Text);
            foreach (var fi in di.GetFiles())
            {
                //파일명, 날짜, 확장자, 크기
                var lv = lvFiles.Items.Add(fi.Name);
                lv.SubItems.Add(fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"));
                lv.SubItems.Add(fi.Extension);
                lv.SubItems.Add(fi.Length.ToString("N0"));
            }
            lvFiles.Tag = path;

        }


        /// <summary>
        /// 드라이브내의 폴더를 표시
        /// </summary>
        void Refresh_path(TreeNode node)
        {
            if (node == null)
            {
                //처음조회
                tvPath.Nodes.Clear();
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"D:\"); //D:\
                foreach (var fi in di.GetDirectories())
                {
                    var tvNode = tvPath.Nodes.Add(fi.Name); //폴더명
                    tvNode.Tag = fi.FullName;
                }
                tvPath.Tag = @"D:\";
            }
            else
            {
                var curpath = node.Tag.ToString();
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(curpath); //D:\
                foreach (var fi in di.GetDirectories())
                {
                    var lv = node.Nodes.Add(fi.Name); //폴더명
                    lv.Tag = fi.FullName;
                }
           
            }
            

        }

        private void 새로고침ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = lvFiles.Tag.ToString(); //기존에 조회된 폴더를 찾음
            Refresh_file(path);
        }

        private void tvPath_DoubleClick(object sender, EventArgs e)
        {
            var node = tvPath.SelectedNode; //선택된 노드
            var path = node.Tag.ToString(); //전체경로
            tbPath.Text = path;             // 상단 폴더위치 텍박업데이트
            Refresh_file(path);             // 실제 파일 목록 갱신
            //하위폴더 조회
            Refresh_path(node);
        }
    }
}
