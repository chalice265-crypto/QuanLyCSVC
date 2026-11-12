using System.Data;

partial class LogPage
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        dgvLog = new DataGridView();
        pnlTop = new Panel();
        btnBack = new Button();
        lblNote = new Label();
        SuspendLayout();
        // dgvLog
        dgvLog.Dock = DockStyle.Fill;
        dgvLog.ReadOnly = true;
        dgvLog.AllowUserToAddRows = false;
        dgvLog.RowHeadersVisible = false;
        dgvLog.BackgroundColor = Color.White;
        dgvLog.BorderStyle = BorderStyle.None;
        dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        // pnlTop
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Height = 56;
        pnlTop.BackColor = Color.White;
        // btnBack
        btnBack.Location = new Point(15, 13);
        btnBack.Size = new Size(130, 30);
        btnBack.Text = "← Trang chủ";
        btnBack.BackColor = Color.FromArgb(33, 150, 243);
        btnBack.ForeColor = Color.White;
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.FlatAppearance.BorderSize = 0;
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += btnBack_Click;
        // lblNote
        lblNote.AutoSize = true;
        lblNote.ForeColor = Color.DimGray;
        lblNote.Location = new Point(165, 18);
        lblNote.Text = "500 thao tác gần nhất";
        Controls.Add(dgvLog);
        Controls.Add(pnlTop);
        pnlTop.Controls.Add(btnBack);
        pnlTop.Controls.Add(lblNote);
        // LogPage
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(238, 241, 246);
        Font = new Font("Segoe UI", 10F);
        Name = "LogPage";
        Padding = new Padding(16);
        Size = new Size(1100, 600);
        ResumeLayout(false);
    }

    private DataGridView dgvLog;
    private Panel pnlTop;
    private Button btnBack;
    private Label lblNote;
}
