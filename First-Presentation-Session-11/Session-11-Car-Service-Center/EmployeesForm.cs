using CarServiceCenterLib;
using DevExpress.XtraEditors.Repository;
using SerializerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors.ColorPick.Picker;
using DevExpress.XtraGrid.Views.Base;

namespace Session_11_Car_Service_Center {
    public partial class EmployeesForm : Form {
        private Serializer _serializer;
        private CarServiceCenter _carServiceCenter;
        public EmployeesForm(CarServiceCenter carServiceCenter) {
            InitializeComponent();
            _serializer = new Serializer();
            _carServiceCenter = carServiceCenter;
        }

        private void EmployeesForm_Load(object sender, EventArgs e) {
            SetControlProperties();
        }
        private void SetControlProperties() {
            bsEngineers.DataSource = _carServiceCenter.Engineers;
            grdEngineers.DataSource = bsEngineers;
            bsManagers.DataSource = _carServiceCenter.Managers;
            grdManagers.DataSource = bsManagers;
            SetLookUpEdit<Manager>(repManagerName, _carServiceCenter.Managers, "Name", "ID");
            SetLookUpEdit<Manager>(repManagerSurname, _carServiceCenter.Managers, "Surname", "ID");
        }

        private void btnSave_Click(object sender, EventArgs e) {
            _serializer.SerializeToFile(_carServiceCenter, "CarServiceCenter.json");
            DevExpress.XtraEditors.XtraMessageBox.Show("Saved!");

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SetLookUpEdit<T>(RepositoryItemLookUpEdit rep, List<T> list, String displayMember, String valueMember) {
            rep.DataSource = list;
            rep.DisplayMember = displayMember;
            rep.ValueMember = valueMember;
        }

        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e) {
            GridView view = sender as GridView;
        }
        //Customize Buttons

        private void btnSave_MouseEnter(object sender, EventArgs e) {
            btnSave.FlatAppearance.MouseOverBackColor = btnSave.BackColor;
            btnSave.ForeColor = Color.Blue;
            btnSave.FlatAppearance.BorderColor = Color.Red;
            btnSave.FlatAppearance.BorderSize = 2;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e) {
            btnSave.ForeColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 0;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e) {
            btnClose.FlatAppearance.MouseOverBackColor = btnClose.BackColor;
            btnClose.ForeColor = Color.Blue;
            btnClose.FlatAppearance.BorderColor = Color.Red;
            btnClose.FlatAppearance.BorderSize = 2;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e) {
            btnClose.ForeColor = Color.Black;
            btnClose.FlatAppearance.BorderSize = 0;
        }
        //gridView1_ValidateRow Giannis
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            GridView view = sender as GridView;
            GridColumn colName = view.Columns["Name"];
            GridColumn colSurName = view.Columns["Surname"];
            GridColumn colEngineersManagerName = view.Columns["ManagerID"];
            GridColumn colEngineersManagerSurname = view.Columns["ManagerID"];
            GridColumn colSalaryPerMonth = view.Columns["SalaryPerMonth"];
            GridColumn colEngineerStartDate = view.Columns["StartDate"];
            String name = view.GetRowCellValue(e.RowHandle, colName) as String;
            String surname = view.GetRowCellValue(e.RowHandle, colSurName) as String;
            String managerName = view.GetRowCellValue(e.RowHandle, colEngineersManagerName).ToString();
            String managerSurname = view.GetRowCellValue(e.RowHandle, colEngineersManagerSurname).ToString();
            String salaryPerMonth = view.GetRowCellValue(e.RowHandle, colSalaryPerMonth).ToString();
            String startDay;
            if (view.GetRowCellValue(e.RowHandle, colEngineerStartDate) != null)
                startDay = view.GetRowCellValue(e.RowHandle, colEngineerStartDate).ToString();
            else
                startDay = null;
            if (name == null) {
                e.Valid = false;
                view.SetColumnError(colName, "Insert Valid Name");
            } else if (name == "") {
                e.Valid = false;
                view.SetColumnError(colName, "Fill Name cell");
            }
            // Surname Cell
            if (surname == null) {
                e.Valid = false;
                view.SetColumnError(colSurName, "Insert Valid Surname");
            } else if (surname == "") {
                e.Valid = false;
                view.SetColumnError(colSurName, "Fill Surname cell");
            }
            // Manager Name Cell
            if (managerName == null) {
                e.Valid = false;
                view.SetColumnError(colEngineersManagerName, "Insert Valid Manager Name");
            } else if (managerName == "") {
                e.Valid = false;
                view.SetColumnError(colEngineersManagerName, "Fill Manager Name cell");
            }
            // Manager Surname Cell
            if (managerSurname == null) {
                e.Valid = false;
                view.SetColumnError(colEngineersManagerSurname, "Insert Valid Manager Surname");
            } else if (managerSurname == "") {
                e.Valid = false;
                view.SetColumnError(colEngineersManagerSurname, "Fill Manager Surname cell");
            }
            // Salary Per Month Cell
            if (salaryPerMonth == null) {
                e.Valid = false;
                view.SetColumnError(colSalaryPerMonth, "Insert Valid Salary Per Month");
            } else if (salaryPerMonth == "0") {
                e.Valid = false;
                view.SetColumnError(colSalaryPerMonth, "Fill Salary Per Month cell");
            }
            // Start Day Cell
            if (startDay == null) {
                e.Valid = false;
                view.SetColumnError(colEngineerStartDate, "Insert Valid Start Day");
            } else if (startDay == "") {
                e.Valid = false;
                view.SetColumnError(colEngineerStartDate, "Fill Start Day cell");
            }

            if (e.Valid) {
                view.ClearColumnErrors();
            }
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {
            ColumnView view = sender as ColumnView;
            GridColumn column = (e as EditFormValidateEditorEventArgs)?.Column ?? view.FocusedColumn;
            String cellVal = e.Value.ToString();
            if (column.FieldName == "Name") {
                // colName changed
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colName, "Insert Valid Name");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colName, "Fill Name cell");
                }
            } else if (column.FieldName == "Surname") {
                // colSurname changed
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colSurname, "Insert Valid Surname");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colSurname, "Fill Surname cell");
                }
            } else if (column.FieldName == "ManagerID") {
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colEngineersManagerName, "Insert Valid Manager");
                    view.SetColumnError(colEngineersManagerSurname, "Insert Valid Manager");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colEngineersManagerName, "Fill Manager cell");
                    view.SetColumnError(colEngineersManagerSurname, "fill Manager cell");
                }
            }else if (column.FieldName == "SalaryPerMonth") {
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colSalaryPerMonth, "Insert Valid Salary Per Month");
                } else if (cellVal == "0") {
                    e.Valid = false;
                    view.SetColumnError(colSalaryPerMonth, "Fill Salary Per Month cell");
                }
            } else if (column.FieldName == "StartDate") {
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colEngineerStartDate, "Insert Valid Start Day");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colEngineerStartDate, "Fill Start Day cell");
                }
            }
        }

        private void gridView2_ValidateRow(object sender, ValidateRowEventArgs e) {
            GridView view = sender as GridView;
            GridColumn colName = view.Columns["Name"];
            GridColumn colSurName = view.Columns["Surname"];
            GridColumn colSalaryPerMonth = view.Columns["SalaryPerMonth"];
            GridColumn colEngineerStartDate = view.Columns["StartDate"];
            String name = view.GetRowCellValue(e.RowHandle, colName) as String;
            String surname = view.GetRowCellValue(e.RowHandle, colSurName) as String;
            String salaryPerMonth = view.GetRowCellValue(e.RowHandle, colSalaryPerMonth).ToString();
            String startDay;
            if (view.GetRowCellValue(e.RowHandle, colEngineerStartDate) != null)
                startDay = view.GetRowCellValue(e.RowHandle, colEngineerStartDate).ToString();
            else
                startDay = null;
            // Name Cell
            if (name == null) {
                e.Valid = false;
                view.SetColumnError(colName, "Insert Valid Name");
            } else if (name == "") {
                e.Valid = false;
                view.SetColumnError(colName, "Fill Name cell");
            }
            // Surname Cell
            if (surname == null) {
                e.Valid = false;
                view.SetColumnError(colSurName, "Insert Valid Surname");
            } else if (surname == "") {
                e.Valid = false;
                view.SetColumnError(colSurName, "Fill Surname cell");
            }
            // Salary Per Month Cell
            if (salaryPerMonth == null) {
                e.Valid = false;
                view.SetColumnError(colSalaryPerMonth, "Insert Valid Salary Per Month");
            } else if (salaryPerMonth == "0") {
                e.Valid = false;
                view.SetColumnError(colSalaryPerMonth, "Fill Salary Per Month cell");
            }
            // Start Day Cell
            if (startDay == null) {
                e.Valid = false;
                view.SetColumnError(colEngineerStartDate, "Insert Valid Start Day");
            } else if (startDay == "") {
                e.Valid = false;
                view.SetColumnError(colEngineerStartDate, "Fill Start Day cell");
            }

            if (e.Valid) {
                view.ClearColumnErrors();
            }
        }

        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e) {
            ColumnView view = sender as ColumnView;
            GridColumn column = (e as EditFormValidateEditorEventArgs)?.Column ?? view.FocusedColumn;
            String cellVal = e.Value.ToString();
            if (column.FieldName == "Name") {
                // colName changed
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colName, "Insert Valid Name");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colName, "Fill Name cell");
                }
            } else if (column.FieldName == "Surname") {
                // colSurname changed
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colSurname, "Insert Valid Surname");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colSurname, "Fill Surname cell");
                }
            } else if (column.FieldName == "SalaryPerMonth") {
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colSalaryPerMonth, "Insert Valid Salary Per Month");
                } else if (cellVal == "0") {
                    e.Valid = false;
                    view.SetColumnError(colSalaryPerMonth, "Fill Salary Per Month cell");
                }
            } else if (column.FieldName == "StartDate") {
                if (cellVal == null) {
                    e.Valid = false;
                    view.SetColumnError(colEngineerStartDate, "Insert Valid Start Day");
                } else if (cellVal == "") {
                    e.Valid = false;
                    view.SetColumnError(colEngineerStartDate, "Fill Start Day cell");
                }
            }
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e) {
            _carServiceCenter.UpdateWorkDays();
        }
    }
}
