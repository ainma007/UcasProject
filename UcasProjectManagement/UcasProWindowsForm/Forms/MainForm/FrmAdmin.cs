﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.EmployeeForm;
using UcasProWindowsForm.Forms.ProjectProfileForm;
using UcasProWindowsForm.Forms.supplierForm;


namespace UcasProWindowsForm.Forms.MainForm
{
    public partial class FrmAdmin : Telerik.WinControls.UI.RadForm
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        ProjectProfileCmd cmd = new ProjectProfileCmd();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            projectProfileBindingSource.DataSource = ProjectProfileCmd.GetAllProjects();
        }

        private void ProjectAddBtn_Click(object sender, EventArgs e)
        {
            FrmAddProject AddPro = new FrmAddProject();
            AddPro.ShowDialog();
        }

        private void GroupMangBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void EmployeeAddBtn_Click(object sender, EventArgs e)
        {
            FrmAddEmployee addempfrm = new FrmAddEmployee();
            addempfrm.ShowDialog();
        }

        private void ProjectMangBtn_Click(object sender, EventArgs e)
        {
            FrmProjectManage ProMang = new FrmProjectManage();
            ProMang.ShowDialog();
        }

        private void SuppAddBtn_Click(object sender, EventArgs e)
        {
            FrmAddsupplier addSup = new FrmAddsupplier();
            addSup.ShowDialog();
        }

        private void FinanAddBtn_Click(object sender, EventArgs e)
        {
            FrmAddThefinanciers finadd = new FrmAddThefinanciers();
            finadd.ShowDialog();
        }
    }
}
