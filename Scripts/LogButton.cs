using Logbook.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class LogButton : UserControl
{
    private PictureBox image;
    private Label label;
    private TableLayoutPanel layout;

    public LogButton(Log log)
    {
        Debug.WriteLine("Init Log button");
        InitializeComponent();

        image.Image = log.locked ? Resources.locked : Resources.unlocked;
        label.Text = log.title;

        Debug.WriteLine(image.Image);
        Debug.WriteLine(label.Text);
        Debug.WriteLine(Enabled + " " + Visible);

        // Výška se nikdy nemění
        Height = 80;

        // Šířka se přizpůsobuje FlowLayoutPanelu (120 px “naživo” dolů pro padding)
        Dock = DockStyle.Top;
        Margin = new Padding(10, 5, 10, 5);  // odstup od ostatních položek

        image.Click += (s, e) => OnClick(e);
        label.Click += (s, e) => OnClick(e);
    }



    private void InitializeComponent()
    {
        image = new PictureBox();
        label = new Label();
        layout = new TableLayoutPanel();

        // ============================
        // UserControl
        // ============================
        BackColor = Color.White;
        BorderStyle = BorderStyle.FixedSingle;
        MinimumSize = new Size(Logbook.Logbook.logbook.LogPanel.Width-40, 80);    // garantovaná výška
        MaximumSize = new Size(10000, 80);
        AutoSize = false;

        // ============================
        // Layout container
        // ============================
        layout.ColumnCount = 2;
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80));  // ikonka
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // text
        layout.RowCount = 1;
        layout.Dock = DockStyle.Fill;
        layout.Padding = new Padding(10);

        // ============================
        // PictureBox
        // ============================
        image.Dock = DockStyle.Fill;
        image.SizeMode = PictureBoxSizeMode.Zoom;

        // ============================
        // Label
        // ============================
        label.Dock = DockStyle.Fill;
        label.AutoSize = false;
        label.Font = new Font("Courier New", 18, FontStyle.Bold);
        label.TextAlign = ContentAlignment.MiddleLeft;

        // Klikání


        // ============================
        // Build UI
        // ============================
        layout.Controls.Add(image, 0, 0);
        layout.Controls.Add(label, 1, 0);
        Controls.Add(layout);
    }

    // Propagace kliknutí ven
    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
    }
}