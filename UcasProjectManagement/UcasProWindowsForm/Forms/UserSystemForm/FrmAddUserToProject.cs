﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.UserSystemForm
{
    public partial class FrmAddUserToProject : Telerik.WinControls.UI.RadForm
    {
        public FrmAddUserToProject()
        {
            InitializeComponent();
        }
        private void FillComboBox()
        {  ///GetActivityByProjectID
           ///
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                //User
                this.UserListComboBox.AutoFilter = true;
                this.UserListComboBox.ValueMember = "ID";
                this.UserListComboBox.DisplayMember = "Employee.EmployeeName";

                ///
                //project
                this.ProjectCombo.AutoFilter = true;
                this.ProjectCombo.ValueMember = "ID";
                this.ProjectCombo.DisplayMember = "ProjectName";
            });

            var q = UsersCmd.GetAllUsers();
            var q1=ProjectProfileCmd.GetAllProjects();
            this.Invoke((MethodInvoker)delegate
            {
                //FillUser
                UserListComboBox.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.UserListComboBox.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.UserListComboBox.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
              
                    ///
                //// fill ProjectCombo
            ProjectCombo.DataSource = q1;
            FilterDescriptor filter1 = new FilterDescriptor();
            filter1.PropertyName = this.ProjectCombo.DisplayMember;
            filter1.Operator = FilterOperator.Contains;
            this.ProjectCombo.EditorControl.MasterTemplate.FilterDescriptors.Add(filter1);
           

            });
            Operation.EndOperation(this);



          
          
          
          
          
          




        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
           

            ProjectControl tb = new ProjectControl
            {
                UserID = int.Parse(UserListComboBox.SelectedValue.ToString()),
                ProjectID = int.Parse(ProjectCombo.SelectedValue.ToString()),
                Status="فعال"
            };
            ProjectControlCmd.AddNewProControl(tb);
            Operation.EndOperation(this);
            Operation.ShowToustOk(OperationX.AddMessageDone, this);
            UserListComboBox.ResetText();
            ProjectCombo.ResetText();
            UserListComboBox.Focus();

        }

        private void FrmAddUserToProject_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillComboBox);
            th.Start();
          //  FillComboBox();
        }
    }
}
