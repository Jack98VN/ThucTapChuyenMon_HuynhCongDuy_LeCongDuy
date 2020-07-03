namespace QUANLICAFESTORE
{
    partial class FormTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Vitri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvTaikhoan = new Guna.UI.WinForms.GunaDataGridView();
            this.IDTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btSua = new Guna.UI2.WinForms.Guna2Button();
            this.btThem = new Guna.UI2.WinForms.Guna2Button();
            this.btXoa = new Guna.UI2.WinForms.Guna2Button();
            this.cbVitri = new System.Windows.Forms.ComboBox();
            this.txtTenhienthi = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtPwd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton22 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BorderColor = System.Drawing.Color.Black;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(252, 77);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(39, 30);
            this.txtID.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(132, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Tự động Tăng";
            // 
            // Vitri
            // 
            this.Vitri.DataPropertyName = "Vitri";
            this.Vitri.HeaderText = "Vị Trí";
            this.Vitri.MinimumWidth = 6;
            this.Vitri.Name = "Vitri";
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Tên Hiển Thị";
            this.DisplayName.MinimumWidth = 6;
            this.DisplayName.Name = "DisplayName";
            // 
            // dtgvTaikhoan
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dtgvTaikhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgvTaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTaikhoan.BackgroundColor = System.Drawing.Color.White;
            this.dtgvTaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTaikhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTaikhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvTaikhoan.ColumnHeadersHeight = 52;
            this.dtgvTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTK,
            this.UserName,
            this.PassWord,
            this.DisplayName,
            this.Vitri});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTaikhoan.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvTaikhoan.EnableHeadersVisualStyles = false;
            this.dtgvTaikhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTaikhoan.Location = new System.Drawing.Point(9, 276);
            this.dtgvTaikhoan.Name = "dtgvTaikhoan";
            this.dtgvTaikhoan.RowHeadersVisible = false;
            this.dtgvTaikhoan.RowHeadersWidth = 51;
            this.dtgvTaikhoan.RowTemplate.Height = 24;
            this.dtgvTaikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTaikhoan.Size = new System.Drawing.Size(899, 207);
            this.dtgvTaikhoan.TabIndex = 132;
            this.dtgvTaikhoan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgvTaikhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTaikhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvTaikhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvTaikhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvTaikhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvTaikhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTaikhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTaikhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvTaikhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvTaikhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvTaikhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvTaikhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvTaikhoan.ThemeStyle.HeaderStyle.Height = 52;
            this.dtgvTaikhoan.ThemeStyle.ReadOnly = false;
            this.dtgvTaikhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTaikhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTaikhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvTaikhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvTaikhoan.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvTaikhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTaikhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvTaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTaikhoan_CellClick);
            // 
            // IDTK
            // 
            this.IDTK.DataPropertyName = "IDTK";
            this.IDTK.HeaderText = "ID";
            this.IDTK.MinimumWidth = 6;
            this.IDTK.Name = "IDTK";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên Tài khoản";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "PassWord";
            this.PassWord.HeaderText = "Mật khẩu";
            this.PassWord.MinimumWidth = 6;
            this.PassWord.Name = "PassWord";
            // 
            // btRefresh
            // 
            this.btRefresh.BorderRadius = 15;
            this.btRefresh.CheckedState.Parent = this.btRefresh;
            this.btRefresh.CustomImages.Parent = this.btRefresh;
            this.btRefresh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.ForeColor = System.Drawing.Color.Black;
            this.btRefresh.HoverState.Parent = this.btRefresh;
            this.btRefresh.Location = new System.Drawing.Point(769, 145);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.ShadowDecoration.Parent = this.btRefresh;
            this.btRefresh.Size = new System.Drawing.Size(90, 40);
            this.btRefresh.TabIndex = 131;
            this.btRefresh.Text = "Làm mới";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btSua
            // 
            this.btSua.BorderRadius = 15;
            this.btSua.CheckedState.Parent = this.btSua;
            this.btSua.CustomImages.Parent = this.btSua;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Black;
            this.btSua.HoverState.Parent = this.btSua;
            this.btSua.Location = new System.Drawing.Point(769, 73);
            this.btSua.Name = "btSua";
            this.btSua.ShadowDecoration.Parent = this.btSua;
            this.btSua.Size = new System.Drawing.Size(90, 40);
            this.btSua.TabIndex = 130;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BorderRadius = 15;
            this.btThem.CheckedState.Parent = this.btThem;
            this.btThem.CustomImages.Parent = this.btThem;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Black;
            this.btThem.HoverState.Parent = this.btThem;
            this.btThem.Location = new System.Drawing.Point(661, 73);
            this.btThem.Name = "btThem";
            this.btThem.ShadowDecoration.Parent = this.btThem;
            this.btThem.Size = new System.Drawing.Size(90, 40);
            this.btThem.TabIndex = 129;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Transparent;
            this.btXoa.BorderColor = System.Drawing.Color.Maroon;
            this.btXoa.BorderRadius = 15;
            this.btXoa.CheckedState.Parent = this.btXoa;
            this.btXoa.CustomImages.Parent = this.btXoa;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Black;
            this.btXoa.HoverState.Parent = this.btXoa;
            this.btXoa.Location = new System.Drawing.Point(661, 145);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShadowDecoration.Parent = this.btXoa;
            this.btXoa.Size = new System.Drawing.Size(90, 40);
            this.btXoa.TabIndex = 128;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // cbVitri
            // 
            this.cbVitri.FormattingEnabled = true;
            this.cbVitri.Items.AddRange(new object[] {
            "Quản lí ",
            "Nhân viên"});
            this.cbVitri.Location = new System.Drawing.Point(460, 154);
            this.cbVitri.Name = "cbVitri";
            this.cbVitri.Size = new System.Drawing.Size(123, 24);
            this.cbVitri.TabIndex = 127;
            // 
            // txtTenhienthi
            // 
            this.txtTenhienthi.BorderColor = System.Drawing.Color.Black;
            this.txtTenhienthi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenhienthi.DefaultText = "";
            this.txtTenhienthi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenhienthi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenhienthi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenhienthi.DisabledState.Parent = this.txtTenhienthi;
            this.txtTenhienthi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenhienthi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenhienthi.FocusedState.Parent = this.txtTenhienthi;
            this.txtTenhienthi.ForeColor = System.Drawing.Color.Black;
            this.txtTenhienthi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenhienthi.HoverState.Parent = this.txtTenhienthi;
            this.txtTenhienthi.Location = new System.Drawing.Point(460, 77);
            this.txtTenhienthi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenhienthi.Name = "txtTenhienthi";
            this.txtTenhienthi.PasswordChar = '\0';
            this.txtTenhienthi.PlaceholderText = "Nhập tên Hiển thị";
            this.txtTenhienthi.SelectedText = "";
            this.txtTenhienthi.ShadowDecoration.Parent = this.txtTenhienthi;
            this.txtTenhienthi.Size = new System.Drawing.Size(123, 30);
            this.txtTenhienthi.TabIndex = 126;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(333, 145);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(95, 42);
            this.gunaLabel7.TabIndex = 125;
            this.gunaLabel7.Text = "Vị Trí";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPwd
            // 
            this.txtPwd.BorderColor = System.Drawing.Color.Black;
            this.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwd.DefaultText = "";
            this.txtPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPwd.DisabledState.Parent = this.txtPwd;
            this.txtPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPwd.FocusedState.Parent = this.txtPwd;
            this.txtPwd.ForeColor = System.Drawing.Color.Black;
            this.txtPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPwd.HoverState.Parent = this.txtPwd;
            this.txtPwd.Location = new System.Drawing.Point(136, 228);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '\0';
            this.txtPwd.PlaceholderText = "Nhập Mật khẩu";
            this.txtPwd.SelectedText = "";
            this.txtPwd.ShadowDecoration.Parent = this.txtPwd;
            this.txtPwd.Size = new System.Drawing.Size(155, 30);
            this.txtPwd.TabIndex = 124;
            // 
            // txtTK
            // 
            this.txtTK.BorderColor = System.Drawing.Color.Black;
            this.txtTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTK.DefaultText = "";
            this.txtTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTK.DisabledState.Parent = this.txtTK;
            this.txtTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTK.FocusedState.Parent = this.txtTK;
            this.txtTK.ForeColor = System.Drawing.Color.Black;
            this.txtTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTK.HoverState.Parent = this.txtTK;
            this.txtTK.Location = new System.Drawing.Point(136, 151);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTK.Name = "txtTK";
            this.txtTK.PasswordChar = '\0';
            this.txtTK.PlaceholderText = "Nhập Tên tài khoản";
            this.txtTK.SelectedText = "";
            this.txtTK.ShadowDecoration.Parent = this.txtTK;
            this.txtTK.Size = new System.Drawing.Size(155, 30);
            this.txtTK.TabIndex = 123;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(9, 222);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(95, 42);
            this.gunaLabel4.TabIndex = 122;
            this.gunaLabel4.Text = "Mật khẩu";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(9, 145);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(95, 42);
            this.gunaLabel3.TabIndex = 121;
            this.gunaLabel3.Text = "Tên tài khoản";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(333, 71);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(95, 42);
            this.gunaLabel2.TabIndex = 120;
            this.gunaLabel2.Text = "Tên hiển thị";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(9, 65);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(95, 42);
            this.gunaLabel1.TabIndex = 119;
            this.gunaLabel1.Text = "ID ";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.Black;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton3.Location = new System.Drawing.Point(661, 12);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(198, 42);
            this.gunaButton3.TabIndex = 118;
            this.gunaButton3.Text = "Chức Năng";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton22
            // 
            this.gunaButton22.AnimationHoverSpeed = 0.07F;
            this.gunaButton22.AnimationSpeed = 0.03F;
            this.gunaButton22.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gunaButton22.BorderColor = System.Drawing.Color.Black;
            this.gunaButton22.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton22.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton22.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton22.ForeColor = System.Drawing.Color.Black;
            this.gunaButton22.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton22.Image")));
            this.gunaButton22.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton22.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaButton22.Location = new System.Drawing.Point(12, 12);
            this.gunaButton22.Name = "gunaButton22";
            this.gunaButton22.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton22.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton22.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton22.OnHoverImage = null;
            this.gunaButton22.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton22.Size = new System.Drawing.Size(571, 42);
            this.gunaButton22.TabIndex = 117;
            this.gunaButton22.Text = "Thông Tin Tài Khoản";
            this.gunaButton22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(947, 481);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvTaikhoan);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.cbVitri);
            this.Controls.Add(this.txtTenhienthi);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaButton3);
            this.Controls.Add(this.gunaButton22);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vitri;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private Guna.UI.WinForms.GunaDataGridView dtgvTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private Guna.UI2.WinForms.Guna2Button btRefresh;
        private Guna.UI2.WinForms.Guna2Button btSua;
        private Guna.UI2.WinForms.Guna2Button btThem;
        private Guna.UI2.WinForms.Guna2Button btXoa;
        private System.Windows.Forms.ComboBox cbVitri;
        private Guna.UI2.WinForms.Guna2TextBox txtTenhienthi;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtPwd;
        private Guna.UI2.WinForms.Guna2TextBox txtTK;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton22;
    }
}