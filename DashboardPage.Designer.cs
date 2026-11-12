using System.Data;

partial class DashboardPage
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

    private void InitializeComponent()
    {
        tlpBottom = new TableLayoutPanel();
        pnlChartCard = new Panel();
        pnlChart = new Panel();
        lblChartCard = new Label();
        pnlWarnCard = new Panel();
        dgvWarn = new DataGridView();
        lblWarnCard = new Label();
        flpTiles = new FlowLayoutPanel();
        pnlT0 = new Panel();
        lblTt0 = new Label();
        lblTi0 = new Label();
        pnlT1 = new Panel();
        lblTt1 = new Label();
        lblTi1 = new Label();
        pnlT2 = new Panel();
        lblTt2 = new Label();
        lblTi2 = new Label();
        pnlT3 = new Panel();
        lblTt3 = new Label();
        lblTi3 = new Label();
        pnlT4 = new Panel();
        lblTt4 = new Label();
        lblTi4 = new Label();
        pnlT5 = new Panel();
        lblTt5 = new Label();
        lblTi5 = new Label();
        pnlT6 = new Panel();
        lblTt6 = new Label();
        lblTi6 = new Label();
        flpStats = new FlowLayoutPanel();
        pnlS0 = new Panel();
        lblSt0 = new Label();
        lblSv0 = new Label();
        pnlS1 = new Panel();
        lblSt1 = new Label();
        lblSv1 = new Label();
        pnlS2 = new Panel();
        lblSt2 = new Label();
        lblSv2 = new Label();
        pnlS3 = new Panel();
        lblSt3 = new Label();
        lblSv3 = new Label();
        SuspendLayout();
        // tlpBottom
        tlpBottom.Dock = DockStyle.Fill;
        tlpBottom.ColumnCount = 2;
        tlpBottom.RowCount = 1;
        tlpBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
        tlpBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
        tlpBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        // pnlChartCard
        pnlChartCard.Dock = DockStyle.Fill;
        pnlChartCard.BackColor = Color.White;
        pnlChartCard.Margin = new Padding(8);
        pnlChartCard.Padding = new Padding(12);
        // pnlChart
        pnlChart.Dock = DockStyle.Fill;
        pnlChart.Paint += DrawChart;
        // lblChartCard
        lblChartCard.Dock = DockStyle.Top;
        lblChartCard.Height = 36;
        lblChartCard.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblChartCard.Text = "Tình trạng thiết bị";
        // pnlWarnCard
        pnlWarnCard.Dock = DockStyle.Fill;
        pnlWarnCard.BackColor = Color.White;
        pnlWarnCard.Margin = new Padding(8);
        pnlWarnCard.Padding = new Padding(12);
        // dgvWarn
        dgvWarn.Dock = DockStyle.Fill;
        dgvWarn.ReadOnly = true;
        dgvWarn.AllowUserToAddRows = false;
        dgvWarn.RowHeadersVisible = false;
        dgvWarn.BackgroundColor = Color.White;
        dgvWarn.BorderStyle = BorderStyle.None;
        dgvWarn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvWarn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        // lblWarnCard
        lblWarnCard.Dock = DockStyle.Top;
        lblWarnCard.Height = 36;
        lblWarnCard.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblWarnCard.Text = "Thiết bị cần chú ý";
        // flpTiles
        flpTiles.Dock = DockStyle.Top;
        flpTiles.Height = 130;
        flpTiles.WrapContents = false;
        // pnlT0
        pnlT0.Size = new Size(170, 110);
        pnlT0.Margin = new Padding(8);
        pnlT0.BackColor = Color.White;
        pnlT0.Cursor = Cursors.Hand;
        pnlT0.Tag = "tb";
        pnlT0.MouseEnter += Tile_Enter;
        pnlT0.MouseLeave += Tile_Leave;
        pnlT0.Click += Tile_Click;
        // lblTt0
        lblTt0.Dock = DockStyle.Fill;
        lblTt0.TextAlign = ContentAlignment.TopCenter;
        lblTt0.ForeColor = Color.DimGray;
        lblTt0.Text = "Quản lý thiết bị";
        lblTt0.Tag = "tb";
        lblTt0.MouseEnter += Tile_Enter;
        lblTt0.MouseLeave += Tile_Leave;
        lblTt0.Click += Tile_Click;
        // lblTi0
        lblTi0.Dock = DockStyle.Top;
        lblTi0.Height = 60;
        lblTi0.TextAlign = ContentAlignment.BottomCenter;
        lblTi0.Font = new Font("Segoe UI Emoji", 24F);
        lblTi0.ForeColor = Color.FromArgb(33, 150, 243);
        lblTi0.Text = "📦";
        lblTi0.Tag = "tb";
        lblTi0.MouseEnter += Tile_Enter;
        lblTi0.MouseLeave += Tile_Leave;
        lblTi0.Click += Tile_Click;
        // pnlT1
        pnlT1.Size = new Size(170, 110);
        pnlT1.Margin = new Padding(8);
        pnlT1.BackColor = Color.White;
        pnlT1.Cursor = Cursors.Hand;
        pnlT1.Tag = "phong";
        pnlT1.MouseEnter += Tile_Enter;
        pnlT1.MouseLeave += Tile_Leave;
        pnlT1.Click += Tile_Click;
        // lblTt1
        lblTt1.Dock = DockStyle.Fill;
        lblTt1.TextAlign = ContentAlignment.TopCenter;
        lblTt1.ForeColor = Color.DimGray;
        lblTt1.Text = "Quản lý phòng";
        lblTt1.Tag = "phong";
        lblTt1.MouseEnter += Tile_Enter;
        lblTt1.MouseLeave += Tile_Leave;
        lblTt1.Click += Tile_Click;
        // lblTi1
        lblTi1.Dock = DockStyle.Top;
        lblTi1.Height = 60;
        lblTi1.TextAlign = ContentAlignment.BottomCenter;
        lblTi1.Font = new Font("Segoe UI Emoji", 24F);
        lblTi1.ForeColor = Color.FromArgb(33, 150, 243);
        lblTi1.Text = "🏢";
        lblTi1.Tag = "phong";
        lblTi1.MouseEnter += Tile_Enter;
        lblTi1.MouseLeave += Tile_Leave;
        lblTi1.Click += Tile_Click;
        // pnlT2
        pnlT2.Size = new Size(170, 110);
        pnlT2.Margin = new Padding(8);
        pnlT2.BackColor = Color.White;
        pnlT2.Cursor = Cursors.Hand;
        pnlT2.Tag = "bt";
        pnlT2.MouseEnter += Tile_Enter;
        pnlT2.MouseLeave += Tile_Leave;
        pnlT2.Click += Tile_Click;
        // lblTt2
        lblTt2.Dock = DockStyle.Fill;
        lblTt2.TextAlign = ContentAlignment.TopCenter;
        lblTt2.ForeColor = Color.DimGray;
        lblTt2.Text = "Cần bảo trì";
        lblTt2.Tag = "bt";
        lblTt2.MouseEnter += Tile_Enter;
        lblTt2.MouseLeave += Tile_Leave;
        lblTt2.Click += Tile_Click;
        // lblTi2
        lblTi2.Dock = DockStyle.Top;
        lblTi2.Height = 60;
        lblTi2.TextAlign = ContentAlignment.BottomCenter;
        lblTi2.Font = new Font("Segoe UI Emoji", 24F);
        lblTi2.ForeColor = Color.FromArgb(33, 150, 243);
        lblTi2.Text = "🔧";
        lblTi2.Tag = "bt";
        lblTi2.MouseEnter += Tile_Enter;
        lblTi2.MouseLeave += Tile_Leave;
        lblTi2.Click += Tile_Click;
        // pnlT3
        pnlT3.Size = new Size(170, 110);
        pnlT3.Margin = new Padding(8);
        pnlT3.BackColor = Color.White;
        pnlT3.Cursor = Cursors.Hand;
        pnlT3.Tag = "hong";
        pnlT3.MouseEnter += Tile_Enter;
        pnlT3.MouseLeave += Tile_Leave;
        pnlT3.Click += Tile_Click;
        // lblTt3
        lblTt3.Dock = DockStyle.Fill;
        lblTt3.TextAlign = ContentAlignment.TopCenter;
        lblTt3.ForeColor = Color.DimGray;
        lblTt3.Text = "Thiết bị hỏng";
        lblTt3.Tag = "hong";
        lblTt3.MouseEnter += Tile_Enter;
        lblTt3.MouseLeave += Tile_Leave;
        lblTt3.Click += Tile_Click;
        // lblTi3
        lblTi3.Dock = DockStyle.Top;
        lblTi3.Height = 60;
        lblTi3.TextAlign = ContentAlignment.BottomCenter;
        lblTi3.Font = new Font("Segoe UI Emoji", 24F);
        lblTi3.ForeColor = Color.FromArgb(33, 150, 243);
        lblTi3.Text = "⚠️";
        lblTi3.Tag = "hong";
        lblTi3.MouseEnter += Tile_Enter;
        lblTi3.MouseLeave += Tile_Leave;
        lblTi3.Click += Tile_Click;
        // pnlT4
        pnlT4.Size = new Size(170, 110);
        pnlT4.Margin = new Padding(8);
        pnlT4.BackColor = Color.White;
        pnlT4.Cursor = Cursors.Hand;
        pnlT4.Tag = "csv";
        pnlT4.MouseEnter += Tile_Enter;
        pnlT4.MouseLeave += Tile_Leave;
        pnlT4.Click += Tile_Click;
        // lblTt4
        lblTt4.Dock = DockStyle.Fill;
        lblTt4.TextAlign = ContentAlignment.TopCenter;
        lblTt4.ForeColor = Color.DimGray;
        lblTt4.Text = "Xuất CSV";
        lblTt4.Tag = "csv";
        lblTt4.MouseEnter += Tile_Enter;
        lblTt4.MouseLeave += Tile_Leave;
        lblTt4.Click += Tile_Click;
        // lblTi4
        lblTi4.Dock = DockStyle.Top;
        lblTi4.Height = 60;
        lblTi4.TextAlign = ContentAlignment.BottomCenter;
        lblTi4.Font = new Font("Segoe UI Emoji", 24F);
        lblTi4.ForeColor = Color.FromArgb(33, 150, 243);
        lblTi4.Text = "📤";
        lblTi4.Tag = "csv";
        lblTi4.MouseEnter += Tile_Enter;
        lblTi4.MouseLeave += Tile_Leave;
        lblTi4.Click += Tile_Click;
        // pnlT5
        pnlT5.Size = new Size(170, 110);
        pnlT5.Margin = new Padding(8);
        pnlT5.BackColor = Color.White;
        pnlT5.Cursor = Cursors.Hand;
        pnlT5.Tag = "users";
        pnlT5.MouseEnter += Tile_Enter;
        pnlT5.MouseLeave += Tile_Leave;
        pnlT5.Click += Tile_Click;
        // lblTt5
        lblTt5.Dock = DockStyle.Fill;
        lblTt5.TextAlign = ContentAlignment.TopCenter;
        lblTt5.ForeColor = Color.DimGray;
        lblTt5.Text = "Quản lý tài khoản";
        lblTt5.Tag = "users";
        lblTt5.MouseEnter += Tile_Enter;
        lblTt5.MouseLeave += Tile_Leave;
        lblTt5.Click += Tile_Click;
        // lblTi5
        lblTi5.Dock = DockStyle.Top;
        lblTi5.Height = 60;
        lblTi5.TextAlign = ContentAlignment.BottomCenter;
        lblTi5.Font = new Font("Segoe UI Emoji", 24F);
        lblTi5.ForeColor = Color.FromArgb(33, 150, 243);
        lblTi5.Text = "👥";
        lblTi5.Tag = "users";
        lblTi5.MouseEnter += Tile_Enter;
        lblTi5.MouseLeave += Tile_Leave;
        lblTi5.Click += Tile_Click;
        // pnlT6
        pnlT6.Size = new Size(170, 110);
        pnlT6.Margin = new Padding(8);
        pnlT6.BackColor = Color.White;
        pnlT6.Cursor = Cursors.Hand;
        pnlT6.Tag = "log";
        pnlT6.MouseEnter += Tile_Enter;
        pnlT6.MouseLeave += Tile_Leave;
        pnlT6.Click += Tile_Click;
        // lblTt6
        lblTt6.Dock = DockStyle.Fill;
        lblTt6.TextAlign = ContentAlignment.TopCenter;
        lblTt6.ForeColor = Color.DimGray;
        lblTt6.Text = "Nhật ký thao tác";
        lblTt6.Tag = "log";
        lblTt6.MouseEnter += Tile_Enter;
        lblTt6.MouseLeave += Tile_Leave;
        lblTt6.Click += Tile_Click;
        // lblTi6
        lblTi6.Dock = DockStyle.Top;
        lblTi6.Height = 60;
        lblTi6.TextAlign = ContentAlignment.BottomCenter;
        lblTi6.Font = new Font("Segoe UI Emoji", 24F);
        lblTi6.ForeColor = Color.FromArgb(33, 150, 243);
        lblTi6.Text = "📜";
        lblTi6.Tag = "log";
        lblTi6.MouseEnter += Tile_Enter;
        lblTi6.MouseLeave += Tile_Leave;
        lblTi6.Click += Tile_Click;
        // flpStats
        flpStats.Dock = DockStyle.Top;
        flpStats.Height = 116;
        flpStats.WrapContents = false;
        // pnlS0
        pnlS0.Size = new Size(280, 100);
        pnlS0.Margin = new Padding(8);
        pnlS0.BackColor = Color.FromArgb(225, 245, 254);
        // lblSt0
        lblSt0.AutoSize = true;
        lblSt0.Location = new Point(16, 12);
        lblSt0.ForeColor = Color.FromArgb(33, 150, 243);
        lblSt0.Text = "Tổng thiết bị";
        // lblSv0
        lblSv0.AutoSize = true;
        lblSv0.Location = new Point(14, 38);
        lblSv0.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
        lblSv0.ForeColor = Color.FromArgb(33, 150, 243);
        lblSv0.Text = "0";
        // pnlS1
        pnlS1.Size = new Size(280, 100);
        pnlS1.Margin = new Padding(8);
        pnlS1.BackColor = Color.FromArgb(255, 255, 255);
        // lblSt1
        lblSt1.AutoSize = true;
        lblSt1.Location = new Point(16, 12);
        lblSt1.ForeColor = Color.FromArgb(60, 60, 60);
        lblSt1.Text = "Số phòng";
        // lblSv1
        lblSv1.AutoSize = true;
        lblSv1.Location = new Point(14, 38);
        lblSv1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
        lblSv1.ForeColor = Color.FromArgb(60, 60, 60);
        lblSv1.Text = "0";
        // pnlS2
        pnlS2.Size = new Size(280, 100);
        pnlS2.Margin = new Padding(8);
        pnlS2.BackColor = Color.FromArgb(255, 243, 214);
        // lblSt2
        lblSt2.AutoSize = true;
        lblSt2.Location = new Point(16, 12);
        lblSt2.ForeColor = Color.FromArgb(240, 150, 0);
        lblSt2.Text = "Cần bảo trì";
        // lblSv2
        lblSv2.AutoSize = true;
        lblSv2.Location = new Point(14, 38);
        lblSv2.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
        lblSv2.ForeColor = Color.FromArgb(240, 150, 0);
        lblSv2.Text = "0";
        // pnlS3
        pnlS3.Size = new Size(280, 100);
        pnlS3.Margin = new Padding(8);
        pnlS3.BackColor = Color.FromArgb(253, 228, 228);
        // lblSt3
        lblSt3.AutoSize = true;
        lblSt3.Location = new Point(16, 12);
        lblSt3.ForeColor = Color.FromArgb(220, 60, 60);
        lblSt3.Text = "Thiết bị hỏng";
        // lblSv3
        lblSv3.AutoSize = true;
        lblSv3.Location = new Point(14, 38);
        lblSv3.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
        lblSv3.ForeColor = Color.FromArgb(220, 60, 60);
        lblSv3.Text = "0";
        Controls.Add(tlpBottom);
        tlpBottom.Controls.Add(pnlChartCard, 0,0);
        pnlChartCard.Controls.Add(pnlChart);
        pnlChartCard.Controls.Add(lblChartCard);
        tlpBottom.Controls.Add(pnlWarnCard, 1,0);
        pnlWarnCard.Controls.Add(dgvWarn);
        pnlWarnCard.Controls.Add(lblWarnCard);
        Controls.Add(flpTiles);
        flpTiles.Controls.Add(pnlT0);
        pnlT0.Controls.Add(lblTt0);
        pnlT0.Controls.Add(lblTi0);
        flpTiles.Controls.Add(pnlT1);
        pnlT1.Controls.Add(lblTt1);
        pnlT1.Controls.Add(lblTi1);
        flpTiles.Controls.Add(pnlT2);
        pnlT2.Controls.Add(lblTt2);
        pnlT2.Controls.Add(lblTi2);
        flpTiles.Controls.Add(pnlT3);
        pnlT3.Controls.Add(lblTt3);
        pnlT3.Controls.Add(lblTi3);
        flpTiles.Controls.Add(pnlT4);
        pnlT4.Controls.Add(lblTt4);
        pnlT4.Controls.Add(lblTi4);
        flpTiles.Controls.Add(pnlT5);
        pnlT5.Controls.Add(lblTt5);
        pnlT5.Controls.Add(lblTi5);
        flpTiles.Controls.Add(pnlT6);
        pnlT6.Controls.Add(lblTt6);
        pnlT6.Controls.Add(lblTi6);
        Controls.Add(flpStats);
        flpStats.Controls.Add(pnlS0);
        pnlS0.Controls.Add(lblSt0);
        pnlS0.Controls.Add(lblSv0);
        flpStats.Controls.Add(pnlS1);
        pnlS1.Controls.Add(lblSt1);
        pnlS1.Controls.Add(lblSv1);
        flpStats.Controls.Add(pnlS2);
        pnlS2.Controls.Add(lblSt2);
        pnlS2.Controls.Add(lblSv2);
        flpStats.Controls.Add(pnlS3);
        pnlS3.Controls.Add(lblSt3);
        pnlS3.Controls.Add(lblSv3);
        // DashboardPage
        AutoScaleDimensions = new SizeF(96F, 96F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(238, 241, 246);
        Font = new Font("Segoe UI", 10F);
        Name = "DashboardPage";
        Padding = new Padding(12);
        Size = new Size(1100, 600);
        ResumeLayout(false);
    }

    private TableLayoutPanel tlpBottom;
    private Panel pnlChartCard;
    private Panel pnlChart;
    private Label lblChartCard;
    private Panel pnlWarnCard;
    private DataGridView dgvWarn;
    private Label lblWarnCard;
    private FlowLayoutPanel flpTiles;
    private Panel pnlT0;
    private Label lblTt0;
    private Label lblTi0;
    private Panel pnlT1;
    private Label lblTt1;
    private Label lblTi1;
    private Panel pnlT2;
    private Label lblTt2;
    private Label lblTi2;
    private Panel pnlT3;
    private Label lblTt3;
    private Label lblTi3;
    private Panel pnlT4;
    private Label lblTt4;
    private Label lblTi4;
    private Panel pnlT5;
    private Label lblTt5;
    private Label lblTi5;
    private Panel pnlT6;
    private Label lblTt6;
    private Label lblTi6;
    private FlowLayoutPanel flpStats;
    private Panel pnlS0;
    private Label lblSt0;
    private Label lblSv0;
    private Panel pnlS1;
    private Label lblSt1;
    private Label lblSv1;
    private Panel pnlS2;
    private Label lblSt2;
    private Label lblSv2;
    private Panel pnlS3;
    private Label lblSt3;
    private Label lblSv3;
}
