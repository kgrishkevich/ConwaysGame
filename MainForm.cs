using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ConwaysGame
{
    public partial class MainForm : Form
    {
        private const string _APP_NAME = "Conway's Game";
        public const string _MSG_ERROR = "Error";
        public const string _MSG_STACK_TRACE = "\n Stack Trace: ";

        private bool _running;
        private int _delay;
        private bool _sizeErrorShowed;

        private Universe _universe;

        public MainForm()
        {
            InitializeComponent();

            _running = false;
            _delay = 300;
            _sizeErrorShowed = false;

            _universe = new Universe(100);
        }

        private void pnlDrawGame_Paint(object sender, PaintEventArgs e)
        {
            lbAutoState.Text = _running ? "Running" : "Stopped";

            SolidBrush brush = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(brush, 0, 0, pnlDrawGame.Size.Width, pnlDrawGame.Size.Height);

            SolidBrush cellBrush = new SolidBrush(Color.Black);

            int dx = Convert.ToInt32(Convert.ToDouble(pnlDrawGame.Size.Width) / Convert.ToDouble(_universe.Size));
            int dy = Convert.ToInt32(Convert.ToDouble(pnlDrawGame.Size.Height) / Convert.ToDouble(_universe.Size));

            if ((dx > 0) && (dy > 0))
            {
                _universe.DrawCurrentState(e.Graphics, cellBrush, dx, dy);
            }
            else
            {
                if (!_sizeErrorShowed)
                {
                    MessageBox.Show("Too big universe size to show it!", _APP_NAME);
                    _sizeErrorShowed = true;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                _universe.GenerateNextState();
                pnlDrawGame.Refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + _MSG_STACK_TRACE + exc.StackTrace +
                    "\nSource: " + exc.Source, _MSG_ERROR);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_running)
            {
                MessageBox.Show("The auto generation already started!", _APP_NAME);
                return;
            }

            try
            {
                _delay = Convert.ToInt32(numDelay.Value);

                Thread thread = new Thread(
                    delegate()
                    {
                        _running = true;

                        while (_running)
                        {
                            _universe.GenerateNextState();

                            try
                            {
                                Invoke((MethodInvoker)delegate()
                                {
                                    pnlDrawGame.Refresh();
                                });

                                Thread.Sleep(_delay);
                            }
                            catch
                            {
                                // To avoid the exception when the window is closed
                            }
                        }
                    });
                thread.Start();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + _MSG_STACK_TRACE + exc.StackTrace +
                    "\nSource: " + exc.Source, _MSG_ERROR);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _running = false;
            pnlDrawGame.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                _universe.Clear();
                pnlDrawGame.Refresh();

                MessageBox.Show("The Universe has been cleared!", _APP_NAME);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + _MSG_STACK_TRACE + exc.StackTrace +
                    "\nSource: " + exc.Source, _MSG_ERROR);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            pnlDrawGame.Refresh();
        }

        private void btnChangeUniverseSize_Click(object sender, EventArgs e)
        {
            try
            {
                _universe = new Universe(Convert.ToUInt64(numUniverseSize.Value));
                _sizeErrorShowed = false;
                pnlDrawGame.Refresh();

                MessageBox.Show("The Universe size has been changed!", _APP_NAME);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + _MSG_STACK_TRACE + exc.StackTrace +
                    "\nSource: " + exc.Source, _MSG_ERROR);
            }
        }

        private void btnAddCell_Click(object sender, EventArgs e)
        {
            try
            {
                UInt64 x = Convert.ToUInt64(numX.Value);
                UInt64 y = Convert.ToUInt64(numY.Value);

                if (!_universe.AddAliveCell(x, y))
                    MessageBox.Show("The cell is already alive!", _APP_NAME);

                pnlDrawGame.Refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + _MSG_STACK_TRACE + exc.StackTrace +
                    "\nSource: " + exc.Source, _MSG_ERROR);
            }
        }

        private string getModulePath()
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Replace("file:\\", "");

            return path;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = getModulePath();
                openFileDialog.Filter = "Universe Files (*.uni)|*.uni*";
                openFileDialog.Multiselect = true;

                if (DialogResult.OK == openFileDialog.ShowDialog())
                {
                    _universe.ReadCurrentState(openFileDialog.FileName);
                    numUniverseSize.Value = Convert.ToDecimal(_universe.Size);
                    pnlDrawGame.Refresh();

                    MessageBox.Show("The Universe state has been loaded!", _APP_NAME);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + _MSG_STACK_TRACE + exc.StackTrace +
                    "\nSource: " + exc.Source, _MSG_ERROR);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.InitialDirectory = getModulePath();
                saveFileDialog.FileName = "Universe_01.uni";
                saveFileDialog.Filter = "Universe Files (*.uni)|*.uni*";

                if (DialogResult.OK == saveFileDialog.ShowDialog())
                {
                    _universe.WriteCurrentState(saveFileDialog.FileName);
                    MessageBox.Show("The Universe state has been saved!", _APP_NAME);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + _MSG_STACK_TRACE + exc.StackTrace +
                    "\nSource: " + exc.Source, _MSG_ERROR);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _running = false;
        }

        private void btnRemoveCell_Click(object sender, EventArgs e)
        {
            try
            {
                UInt64 x = Convert.ToUInt64(numX.Value);
                UInt64 y = Convert.ToUInt64(numY.Value);

                Cell cell = new Cell(x, y);
                if (!_universe.RemoveAliveCell(x, y))
                    MessageBox.Show("The selected cell is not alive!", _APP_NAME);

                pnlDrawGame.Refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + _MSG_STACK_TRACE + exc.StackTrace +
                    "\nSource: " + exc.Source, _MSG_ERROR);
            }
        }
    }
}
