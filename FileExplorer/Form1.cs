using System;
using System.Drawing;
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
        Boolean Refresh_file(string path)
        {
            lvFiles.Items.Clear(); //기존의 목록을 제거
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);

            try
            {
                foreach (var fi in di.GetFiles())
                {
                    //파일명, 날짜, 확장자, 크기
                    var lv = lvFiles.Items.Add(fi.Name);
                    lv.SubItems.Add(fi.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    lv.SubItems.Add(fi.Extension);
                    lv.SubItems.Add(fi.Length.ToString("N0"));
                    lv.Tag = fi.FullName;
                }
                lvFiles.Tag = path;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }



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
                try
                {
                    foreach (var fi in di.GetDirectories())
                    {
                        var lv = node.Nodes.Add(fi.Name); //폴더명
                        lv.Tag = fi.FullName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        }

        TreeNode preNode = null;

        private void tvPath_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //이전에 선택된 자료의 강조를 제거
            if (preNode != null)
            {
                preNode.ForeColor = this.ForeColor;
                preNode.NodeFont = this.Font;
            }

            var node = tvPath.SelectedNode; //선택된 노드
            var path = node.Tag.ToString(); //전체경로
            tbPath.Text = path;             // 상단 폴더위치 텍박업데이트
            var result = Refresh_file(path);             // 실제 파일 목록 갱신
            //하위폴더 조회
            if (result)
            {
                Refresh_path(node);
            }
            node.ForeColor = Color.Blue;
            node.NodeFont = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);

            preNode = node;
        }

        private void btFileDelete_Click(object sender, EventArgs e)
        {
            //파일삭제
            if (lvFiles.CheckedItems.Count < 0)
            {

                int 파일갯수 = lvFiles.CheckedItems.Count;
                //다중파일삭제루틴
                var file = new System.IO.FileInfo(lvFiles.FocusedItem.Tag.ToString());
                string msg = 파일갯수.ToString() + "건의 다음파일을 삭제하시겠습니까?\n";

                var dlg = MessageBox.Show(msg, "파일삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    //진행율 초기화
                    prb1.Maximum = 파일갯수;
                    prb1.Minimum = 0;
                    prb1.Value = 0;

                    foreach (ListViewItem lv in lvFiles.CheckedItems)
                    {
                        prb1.Value += 1;
                        try
                        {
                            System.IO.File.Delete(lv.Tag.ToString());  //tag에 파일명 있음
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }

                    var path = lvFiles.Tag.ToString(); //기존에 조회된 폴더를 찾음
                    Refresh_file(path);


                }

            }
            else
            {
                var file = new System.IO.FileInfo(lvFiles.FocusedItem.Tag.ToString());
                string msg = "다음파일을 삭제하시겠습니까?\n";
                msg += "\n파일명 : " + file.Name;
                msg += "\n경로 : " + file.DirectoryName;
                msg += "\n크기 : " + file.Length.ToString();
                var dlg = MessageBox.Show(msg, "파일삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    try
                    {
                        System.IO.File.Delete(file.FullName);
                        var path = lvFiles.Tag.ToString(); //기존에 조회된 폴더를 찾음
                        Refresh_file(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                }

            }
        }
    }
}
