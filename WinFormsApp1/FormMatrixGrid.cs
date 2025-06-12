using System.Threading;

namespace WinFormsApp1
{
    public partial class FormMatrixGrid : Form
    {
        // Add variable
        private Thread mythread;
        private CancellationTokenSource cancellationTokenSource;
        public int m_width; //Width of the grid cell

        public int m_Height; // The height of the Cell

        public int m_NoOfRows; // The Number Of Rows

        public int m_NoOfCols; // The Number Of Columns

        public int m_XOffset; //Offset from which drawing start
        public int m_YOffset;
        public int count = 8;

        public const int DEFAULT_X_OFFSET = 100;
        public const int DEFAULT_Y_OFFSET = 100;
        public const int DEFAULT_NO_ROWS = 2;
        public const int DEFAULT_NO_COLS = 2;
        public const int DEFAULT_WIDTH = 60;
        public const int DEFAULT_HEIGHT = 60;
        public FormMatrixGrid()
        {
            Initialize();
            InitializeComponent();
        }
        public void Initialize()
        {
            //Put all the default values
            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfCols = DEFAULT_NO_COLS;
            m_width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;
            m_XOffset = DEFAULT_X_OFFSET;
            m_YOffset = DEFAULT_Y_OFFSET;

        }
        private void DrawGrid(CancellationToken token)
        {

            Graphics boardLayout = this.CreateGraphics();
            Pen layoutPen = new Pen(Color.HotPink);
            layoutPen.Width = 7;
            int counter = 2;
            while (counter <= count+1)
            {
                if (token.IsCancellationRequested)
                {
                    return; // Gracefully exit the thread
                }
                Thread.Sleep(500);

                if (counter <= count)
                {
                    m_NoOfRows = counter;
                    m_NoOfCols = counter;
                    //boardLayout.DrawLine(layoutPen, 0, 0, 100, 0);
                    int X = DEFAULT_X_OFFSET;
                    int Y = DEFAULT_Y_OFFSET;
                    //Draw The rows
                    for (int i = 0; i <= m_NoOfRows; i++)
                    {

                        boardLayout.DrawLine(layoutPen, X, Y, X + this.m_width * this.m_NoOfCols, Y);
                        Y = Y + m_Height;
                    }

                    //Draw The Cols
                    X = DEFAULT_X_OFFSET;
                    Y = DEFAULT_Y_OFFSET;
                    for (int j = 0; j <= m_NoOfCols; j++)
                    {
                        boardLayout.DrawLine(layoutPen, X, Y, X, Y + this.m_Height * this.m_NoOfRows);
                        X = X + this.m_width;
                    }

                    counter++;
                }
                else
                {
                    counter = 2;
                    Invalidate();
                }

            }

        }
        private void OnPaint(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;
            mythread = new Thread(() => DrawGrid(token));
            mythread.Start();
            Invalidate();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Cancel the running thread if it exists
            cancellationTokenSource?.Cancel();

            // Wait for the thread to finish if it's running
            if (mythread != null && mythread.IsAlive)
            {
                try
                {
                    mythread.Join(500); // Wait up to 500ms for the thread to finish
                }
                catch (ThreadStateException)
                {
                    // Thread is not in a joinable state, ignore
                }
            }

            // Optionally, reset grid state or UI as needed
            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfCols = DEFAULT_NO_COLS;
            Invalidate();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Check if the clicked menu item is for setting the max grid size
            if (e.ClickedItem != null && e.ClickedItem.Text.Contains("Max Size", StringComparison.OrdinalIgnoreCase))
            {
                using (var inputForm = new Form())
                {
                    inputForm.Text = "Set Max Grid Size";
                    inputForm.Size = new System.Drawing.Size(250, 220);
                    inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    inputForm.StartPosition = FormStartPosition.CenterParent;
                    inputForm.MaximizeBox = false;
                    inputForm.MinimizeBox = false;

                    var numericUpDown = new NumericUpDown
                    {
                        Location = new System.Drawing.Point(20, 20),
                        Size = new System.Drawing.Size(100, 25),
                        Minimum = 2,
                        Maximum = 8,
                        Value = count
                    };

                    var label = new Label
                    {
                        Text = "Enter grid size (2-8):",
                        Location = new System.Drawing.Point(20, 50),
                        AutoSize = true
                    };

                    var button = new Button
                    {
                        Text = "OK",
                        DialogResult = DialogResult.OK,
                        Location = new System.Drawing.Point(20, 75),
                        Size = new System.Drawing.Size(80, 30) // Proper size for OK button

                    };

                    inputForm.Controls.AddRange(new Control[] { numericUpDown, label, button });
                    inputForm.AcceptButton = button;

                    if (inputForm.ShowDialog() == DialogResult.OK)
                    {
                        count = (int)numericUpDown.Value;
                        m_NoOfRows = DEFAULT_NO_ROWS;
                        m_NoOfCols = DEFAULT_NO_COLS;
                        this.Text = $"Matrix Grid - Max Size: {count} x {count}";
                        Invalidate();
                    }
                }
            }
        }
    }
}
