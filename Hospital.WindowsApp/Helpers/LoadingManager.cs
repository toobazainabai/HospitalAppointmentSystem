using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Hospital.WindowsApp.Helpers
{
    /// <summary>
    /// Helper class to manage loading indicators and UI state during async operations
    /// </summary>
    public class LoadingManager
    {
        private readonly Control _parentControl;
        private ProgressBar _loadingBar;
        private Label _loadingLabel;
        private Panel _loadingPanel;

        public LoadingManager(Control parentControl)
        {
            _parentControl = parentControl;
            InitializeLoadingUI();
        }

        private void InitializeLoadingUI()
        {
            // Create transparent overlay panel
            _loadingPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.FromArgb(100, 0, 0, 0),
                Visible = false
            };
            _loadingPanel.BringToFront();

            // Create loading label
            _loadingLabel = new Label
            {
                Text = "Loading...",
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.Transparent,
                Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold),
                AutoSize = true
            };

            // Create progress bar
            _loadingBar = new ProgressBar
            {
                Style = ProgressBarStyle.Marquee,
                Width = 300,
                Height = 20
            };

            // Create table layout for centering
            var tableLayout = new TableLayoutPanel
            {
                ColumnCount = 1,
                RowCount = 2,
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.Transparent
            };

            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            tableLayout.Controls.Add(_loadingLabel, 0, 0);
            tableLayout.Controls.Add(_loadingBar, 0, 1);

            _loadingPanel.Controls.Add(tableLayout);
            _parentControl.Controls.Add(_loadingPanel);
        }

        public void ShowLoading(string message = "Loading...")
        {
            _loadingLabel.Text = message;
            _loadingPanel.Visible = true;
            _loadingPanel.BringToFront();
            Application.DoEvents();
        }

        public void HideLoading()
        {
            _loadingPanel.Visible = false;
            _loadingPanel.SendToBack();
            Application.DoEvents();
        }

        public async void ExecuteAsync(Func<Task> operation, string message = "Processing...")
        {
            try
            {
                ShowLoading(message);
                await operation();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HideLoading();
            }
        }

        public async void ExecuteAsync<T>(Func<Task<T>> operation, Action<T> onSuccess, string message = "Processing...")
        {
            try
            {
                ShowLoading(message);
                var result = await operation();
                onSuccess?.Invoke(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                HideLoading();
            }
        }
    }
}
