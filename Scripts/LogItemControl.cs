using System.Drawing;
using System.Windows.Forms;

public enum LogItemType
{
    Text,
    Image,
    Audio
}

public class LogItemControl : UserControl
{
    public LogItemType Type;
    public string Data;   // text / path to image / path to audio

    public Control InnerControl; // TextBox, PictureBox nebo AudioPanel

    private Point dragStart;

    public LogItemControl(LogItemType type, string data, Control content)
    {
        this.Type = type;
        this.Data = data;
        this.InnerControl = content;

        this.Width = content.Width + 40;
        this.Height = content.Height + 20;

        FlowLayoutPanel panel = new()
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.LeftToRight
        };

        // delete button
        Button deleteBtn = new()
        {
            Text = "✖",
            Width = 30,
            Height = 30
        };
        deleteBtn.Click += (s, e) =>
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        };

        // move handle
        Label moveHandle = new()
        {
            Text = "⇅",
            Width = 30,
            Height = 30,
            TextAlign = ContentAlignment.MiddleCenter,
            Cursor = Cursors.SizeAll
        };

        moveHandle.MouseDown += (s, e) => dragStart = e.Location;
        moveHandle.MouseMove += MoveHandle_MouseMove;

        panel.Controls.Add(deleteBtn);
        panel.Controls.Add(moveHandle);
        panel.Controls.Add(content);

        Controls.Add(panel);
    }

    private void MoveHandle_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;

        var parent = this.Parent as FlowLayoutPanel;
        if (parent == null) return;

        int index = parent.Controls.IndexOf(this);

        // pohyb nahoru
        if (e.Y < dragStart.Y - 10 && index > 0)
        {
            parent.Controls.SetChildIndex(this, index - 1);
        }
        // pohyb dolů
        else if (e.Y > dragStart.Y + 10 && index < parent.Controls.Count - 1)
        {
            parent.Controls.SetChildIndex(this, index + 1);
        }
    }
}
