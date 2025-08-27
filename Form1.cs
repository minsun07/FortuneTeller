﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTeller
{
    public partial class Form1 : Form
    {
        List<string> results;
        public Form1()
        {
            InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
            try
            {
                string filename = "results.csv";
                results = File.ReadAllLines(filename).ToList();
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show($"파일을 불러올 수 없습니다.\n{ex.Message}", "파일 없음",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(UnauthorizedAccessException ex)
            {
                MessageBox.Show($"파일에 접근권한이 없습니다.\n{ex.Message}", "권한 문제",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했어요.\n{ex.Message}", "알 수 없는 오류!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void 상담내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory; 
            if (form != null)      //FormHistory가 여러 개 뜨는 것 방지
            {
                form.Activate();
            }
            else
            {
                form = new FormHistory();
                form.Show();
            }
        }

        private string GetFortune()
        {
            Random random = new Random();
            int index = random.Next(0, results.Count);
            return results[index];
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 포츈텔러정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

    }
}
