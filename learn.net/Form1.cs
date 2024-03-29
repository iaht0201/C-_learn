﻿using learn.net.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsLopHoc();
        }
        public LopHocViewModel selectedLopHoc
        {
            get
            {
                return cbLopHoc.SelectedItem as LopHocViewModel;
            }
        }

        void NapDsLopHoc()
        {
            var ls = LopHocViewModel.GetList();
            cbLopHoc.DataSource = ls;
            cbLopHoc.DisplayMember = "TenLop";

        }
        void NapDsSinhVien()
        {


            if (selectedLopHoc != null)
            {
                var ls = SinhVienViewModel.GetList(selectedLopHoc.ID);
                gridSinhVien.DataSource = ls;
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapDsSinhVien();
        }
    }
}
