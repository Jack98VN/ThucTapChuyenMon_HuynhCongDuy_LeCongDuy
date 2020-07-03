namespace QUANLICAFESTORE
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel8 = new Guna.UI.WinForms.GunaPanel();
            this.btBack = new Guna.UI2.WinForms.Guna2Button();
            this.lbTientrakhach = new System.Windows.Forms.Label();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.txtTienkhachdua = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtidhoadon = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaButton22 = new Guna.UI.WinForms.GunaButton();
            this.btThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvHoadon = new Guna.UI.WinForms.GunaDataGridView();
            this.idhoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel8
            // 
            this.gunaPanel8.BackColor = System.Drawing.Color.OldLace;
            this.gunaPanel8.Controls.Add(this.btBack);
            this.gunaPanel8.Controls.Add(this.lbTientrakhach);
            this.gunaPanel8.Controls.Add(this.gunaLabel9);
            this.gunaPanel8.Controls.Add(this.gunaLabel8);
            this.gunaPanel8.Controls.Add(this.txtTienkhachdua);
            this.gunaPanel8.Controls.Add(this.gunaButton3);
            this.gunaPanel8.Controls.Add(this.lbTongtien);
            this.gunaPanel8.Controls.Add(this.gunaLabel2);
            this.gunaPanel8.Controls.Add(this.gunaLabel1);
            this.gunaPanel8.Controls.Add(this.txtidhoadon);
            this.gunaPanel8.Controls.Add(this.gunaButton22);
            this.gunaPanel8.Controls.Add(this.btThanhToan);
            this.gunaPanel8.Location = new System.Drawing.Point(13, 29);
            this.gunaPanel8.Name = "gunaPanel8";
            this.gunaPanel8.Size = new System.Drawing.Size(857, 307);
            this.gunaPanel8.TabIndex = 81;
            this.gunaPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel8_Paint);
            // 
            // btBack
            // 
            this.btBack.BorderRadius = 10;
            this.btBack.CheckedState.Parent = this.btBack;
            this.btBack.CustomImages.Parent = this.btBack;
            this.btBack.FillColor = System.Drawing.Color.Red;
            this.btBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.Black;
            this.btBack.HoverState.Parent = this.btBack;
            this.btBack.Location = new System.Drawing.Point(747, 7);
            this.btBack.Name = "btBack";
            this.btBack.ShadowDecoration.Parent = this.btBack;
            this.btBack.Size = new System.Drawing.Size(107, 40);
            this.btBack.TabIndex = 102;
            this.btBack.Text = "Trở Về";
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbTientrakhach
            // 
            this.lbTientrakhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTientrakhach.Location = new System.Drawing.Point(157, 204);
            this.lbTientrakhach.Name = "lbTientrakhach";
            this.lbTientrakhach.Size = new System.Drawing.Size(168, 26);
            this.lbTientrakhach.TabIndex = 101;
            this.lbTientrakhach.Text = "VNĐ";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(38, 188);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(95, 42);
            this.gunaLabel9.TabIndex = 100;
            this.gunaLabel9.Text = "Tiền Trả Khách";
            this.gunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(38, 126);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(95, 42);
            this.gunaLabel8.TabIndex = 98;
            this.gunaLabel8.Text = "Tiền Khách đưa";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTienkhachdua
            // 
            this.txtTienkhachdua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienkhachdua.DefaultText = "";
            this.txtTienkhachdua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienkhachdua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienkhachdua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienkhachdua.DisabledState.Parent = this.txtTienkhachdua;
            this.txtTienkhachdua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienkhachdua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienkhachdua.FocusedState.Parent = this.txtTienkhachdua;
            this.txtTienkhachdua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienkhachdua.HoverState.Parent = this.txtTienkhachdua;
            this.txtTienkhachdua.Location = new System.Drawing.Point(150, 132);
            this.txtTienkhachdua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTienkhachdua.Name = "txtTienkhachdua";
            this.txtTienkhachdua.PasswordChar = '\0';
            this.txtTienkhachdua.PlaceholderText = "";
            this.txtTienkhachdua.SelectedText = "";
            this.txtTienkhachdua.ShadowDecoration.Parent = this.txtTienkhachdua;
            this.txtTienkhachdua.Size = new System.Drawing.Size(158, 30);
            this.txtTienkhachdua.TabIndex = 97;
            this.txtTienkhachdua.TextChanged += new System.EventHandler(this.txtTienkhachdua_TextChanged);
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
            this.gunaButton3.Location = new System.Drawing.Point(445, 7);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Size = new System.Drawing.Size(187, 42);
            this.gunaButton3.TabIndex = 89;
            this.gunaButton3.Text = "Chức Năng";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTongtien
            // 
            this.lbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.Location = new System.Drawing.Point(157, 266);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(165, 26);
            this.lbTongtien.TabIndex = 76;
            this.lbTongtien.Text = "VNĐ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.BackColor = System.Drawing.Color.Crimson;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(38, 250);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(95, 42);
            this.gunaLabel2.TabIndex = 74;
            this.gunaLabel2.Text = "Tổng tiền";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(38, 66);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(95, 42);
            this.gunaLabel1.TabIndex = 53;
            this.gunaLabel1.Text = "Số Hóa Đơn";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtidhoadon
            // 
            this.txtidhoadon.BackColor = System.Drawing.Color.Black;
            this.txtidhoadon.BorderColor = System.Drawing.Color.Black;
            this.txtidhoadon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidhoadon.DefaultText = "";
            this.txtidhoadon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidhoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidhoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidhoadon.DisabledState.Parent = this.txtidhoadon;
            this.txtidhoadon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidhoadon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidhoadon.FocusedState.Parent = this.txtidhoadon;
            this.txtidhoadon.ForeColor = System.Drawing.Color.Black;
            this.txtidhoadon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidhoadon.HoverState.Parent = this.txtidhoadon;
            this.txtidhoadon.Location = new System.Drawing.Point(150, 72);
            this.txtidhoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidhoadon.Name = "txtidhoadon";
            this.txtidhoadon.PasswordChar = '\0';
            this.txtidhoadon.PlaceholderText = "";
            this.txtidhoadon.SelectedText = "";
            this.txtidhoadon.ShadowDecoration.Parent = this.txtidhoadon;
            this.txtidhoadon.Size = new System.Drawing.Size(107, 30);
            this.txtidhoadon.TabIndex = 52;
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
            this.gunaButton22.Location = new System.Drawing.Point(41, 7);
            this.gunaButton22.Name = "gunaButton22";
            this.gunaButton22.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton22.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton22.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton22.OnHoverImage = null;
            this.gunaButton22.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton22.Size = new System.Drawing.Size(388, 42);
            this.gunaButton22.TabIndex = 30;
            this.gunaButton22.Text = "Thông Tin Hóa Đơn";
            this.gunaButton22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btThanhToan
            // 
            this.btThanhToan.BorderRadius = 10;
            this.btThanhToan.CheckedState.Parent = this.btThanhToan;
            this.btThanhToan.CustomImages.Parent = this.btThanhToan;
            this.btThanhToan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btThanhToan.HoverState.Parent = this.btThanhToan;
            this.btThanhToan.Location = new System.Drawing.Point(458, 72);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.ShadowDecoration.Parent = this.btThanhToan;
            this.btThanhToan.Size = new System.Drawing.Size(156, 40);
            this.btThanhToan.TabIndex = 49;
            this.btThanhToan.Text = "Thanh Toán";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            // 
            // dtgvHoadon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvHoadon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoadon.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHoadon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvHoadon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvHoadon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHoadon.ColumnHeadersHeight = 52;
            this.dtgvHoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idhoadon,
            this.soban,
            this.ngay,
            this.tongtien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHoadon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvHoadon.EnableHeadersVisualStyles = false;
            this.dtgvHoadon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvHoadon.Location = new System.Drawing.Point(13, 339);
            this.dtgvHoadon.Name = "dtgvHoadon";
            this.dtgvHoadon.RowHeadersVisible = false;
            this.dtgvHoadon.RowHeadersWidth = 51;
            this.dtgvHoadon.RowTemplate.Height = 24;
            this.dtgvHoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHoadon.Size = new System.Drawing.Size(857, 184);
            this.dtgvHoadon.TabIndex = 82;
            this.dtgvHoadon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgvHoadon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvHoadon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvHoadon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvHoadon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvHoadon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvHoadon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvHoadon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvHoadon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvHoadon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvHoadon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvHoadon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvHoadon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvHoadon.ThemeStyle.HeaderStyle.Height = 52;
            this.dtgvHoadon.ThemeStyle.ReadOnly = false;
            this.dtgvHoadon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvHoadon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvHoadon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvHoadon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvHoadon.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvHoadon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvHoadon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idhoadon
            // 
            this.idhoadon.DataPropertyName = "idhoadon";
            this.idhoadon.HeaderText = "ID Hóa đơn";
            this.idhoadon.MinimumWidth = 6;
            this.idhoadon.Name = "idhoadon";
            // 
            // soban
            // 
            this.soban.DataPropertyName = "soban";
            this.soban.HeaderText = "Số Bàn";
            this.soban.MinimumWidth = 6;
            this.soban.Name = "soban";
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "ngay";
            this.ngay.HeaderText = "Ngày ";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.gunaPanel8);
            this.Controls.Add(this.dtgvHoadon);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.gunaPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel8;
        private Guna.UI2.WinForms.Guna2Button btBack;
        private System.Windows.Forms.Label lbTientrakhach;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2TextBox txtTienkhachdua;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private System.Windows.Forms.Label lbTongtien;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtidhoadon;
        private Guna.UI.WinForms.GunaButton gunaButton22;
        private Guna.UI2.WinForms.Guna2Button btThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private Guna.UI.WinForms.GunaDataGridView dtgvHoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn soban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
    }
}