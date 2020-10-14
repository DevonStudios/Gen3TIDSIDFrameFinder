using System;
using System.Globalization;
using System.Windows.Forms;

namespace Gen3TIDSIDFrameFinder
{
    public partial class  FrameFinder : Form
	{
        #region FRLG_E

        private void OnFindFrameClick(object sender, EventArgs e)
        {
            FindFrame();
        }

        private void FindFrame()
        {
            label5.Focus();

            if (tidTextBox.Text == "" || pidTextBox.Text == "" || prngTextBox.Text == "" || minFrameTextBox.Text == "" || maxFrameTextBox.Text == "")
            {
                MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _DataGridView1.Rows.Clear();

                uint pid, prng;
                ushort tid;
                int currentFrame, maxFrame;

                uint.TryParse(pidTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out pid);
                uint.TryParse(prngTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out prng);
                ushort.TryParse(tidTextBox.Text, out tid);
                int.TryParse(minFrameTextBox.Text, out currentFrame);
                int.TryParse(maxFrameTextBox.Text, out maxFrame);

                uint seed = prng;
                int frameOffset = currentFrame;

                ushort nextsid = GetHighShortSeed(GetNextSeedGBA(seed));

                for (int seedFrame = 0; seedFrame <= maxFrame; seedFrame++)
                {
                    seed = GetNextSeedGBA(seed);
                    nextsid = GetHighShortSeed(seed);

                    bool isShiny = IsShiny(pid, tid, nextsid);
                    if (isShiny)
                    {
                        int emuFrame = seedFrame + frameOffset;

                        int row2 = _DataGridView1.Rows.Add();
                        _DataGridView1.Rows[row2].Cells[0].Value = emuFrame;
                        _DataGridView1.Rows[row2].Cells[1].Value = nextsid;
                    }
                }
            }
        }

        private void AdjustFrame_Click(object sender, EventArgs e)
        {
            AdjustFrame();
        }

        private void AdjustFrame()
        {
            label5.Focus();

            if (tidTextBox.Text.Trim() == "" || pidTextBox.Text.Trim() == "" || prngTextBox.Text.Trim() == "" || minFrameTextBox.Text.Trim() == ""
                   || maxFrameTextBox.Text.Trim() == "" || attemptedFrameTextBox.Text.Trim() == "" || acquiredSidTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                uint pid, prng;
                ushort tid, acquiredSid;
                int currentFrame, attemptedFrame, maxFrame;

                int.TryParse(minFrameTextBox.Text, out currentFrame);
                int.TryParse(maxFrameTextBox.Text, out maxFrame);
                int.TryParse(attemptedFrameTextBox.Text, out attemptedFrame);
                ushort.TryParse(acquiredSidTextBox.Text, out acquiredSid);
                uint.TryParse(pidTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out pid);
                uint.TryParse(prngTextBox.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out prng);
                ushort.TryParse(tidTextBox.Text, out tid);

                uint seed = prng;

                int acquiredFrame = GetSidFrame(seed, 0, maxFrame, acquiredSid, attemptedFrame - currentFrame) + currentFrame;
                int frameDifference = attemptedFrame - acquiredFrame;

                frameOffsetTextBox.Text = frameDifference.ToString();
                adjustedFrameTextBox.Text = (attemptedFrame + frameDifference).ToString();
            }
        }

        private int GetSidFrame(uint seed, int seedFrame, int maxFrame, ushort sid, int attemptedFrame)
        {
            ushort nextsid = GetHighShortSeed(GetNextSeedGBA(seed));

            for (; seedFrame <= maxFrame; seedFrame++)
            {
                seed = GetNextSeedGBA(seed);
                nextsid = GetHighShortSeed(seed);

                if (nextsid == sid && seedFrame > attemptedFrame)
                {
                    return seedFrame;
                }
            }
            return 0;
        }

        private uint GetNextSeedGBA(uint seed)
        {
            return seed * 0x41C64E6D + 0x00006073;
        }

        private void maxFrameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindFrame();
            }
        }

        private void acquiredSidTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AdjustFrame();
            }
        }

        private void frameOffsetTextBox_Enter(object sender, EventArgs e)
        {
            _DataGridView1.Focus();
        }

        private void adjustedFrameTextBox_DoubleClick(object sender, EventArgs e)
        {
            adjustedFrameTextBox.Text = "";
            frameOffsetTextBox.Text = "";
        }
        #endregion

        #region XD_Colo
        private ushort GetLowShortSeed(uint seed)
        {
            return (ushort)(seed & 65535);
        }

        private ushort GetTSV(ushort tid, ushort sid)
        {
            int tsv = tid ^ sid;
            return (ushort)tsv;
        }

        private bool IsShiny(ushort tid, ushort sid, uint pid)
        {
            return (GetHighShortSeed(pid) ^ GetLowShortSeed(pid) ^ GetTSV(tid, sid)) < 8;
        }

        private uint GetNextSeedGC(uint seed)
        {
            return seed * 0x000343FD + 0x00269EC3;
        }

        private uint GetBackSeedGC(uint seed)
        {
            return seed * 0xB9B33155 + 0xA170F641;
        }

        private bool IsShiny(uint pid, ushort tid, ushort sid)
        {
            ushort p1 = (ushort)(pid >> 16);
            ushort p2 = (ushort)(pid & 0xFFFF);
            return ((tid ^ sid) ^ (p1 ^ p2)) < 8;
        }

        private void findSeedButton_Click(object sender, EventArgs e)
        {
            label10.Focus();

            if (tidTextBox2.Text == "" || (sidTextBox.Text == "" && sidCheckBox.Checked == true) ||
                (pidTextBox2.Text == "" && pidCheckBox.Checked == true))
            {
                MessageBox.Show("Please fill all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _DataGridView2.Rows.Clear();
                uint tid;
                uint.TryParse(tidTextBox2.Text, out tid);
                string tidHexValue = tid.ToString("X");
                uint.TryParse(tidHexValue + "0000", NumberStyles.HexNumber, CultureInfo.InvariantCulture, out tid);
                uint pid;
                uint.TryParse(pidTextBox2.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out pid);
                ushort sid;
                short maxResults;
                short.TryParse(maxResultsTextBox.Text, out maxResults);
                short counterMax = 0;

                if (sidCheckBox.Checked == true && pidCheckBox.Checked == false)
                {
                    ushort.TryParse(sidTextBox.Text, out sid);
                    string sidHexValue = sid.ToString("X");
                    ushort.TryParse(sidHexValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out sid);

                    for (int b = 0; b < 65536 && counterMax <= maxResults; b++)
                    {
                        if (GetHighShortSeed(GetNextSeedGC(tid)) == sid)
                        {
                            counterMax++;
                            string backTidSeedHexValue = GetBackSeedGC(tid).ToString("X");
                            int row = _DataGridView2.Rows.Add();
                            sidColumn.Visible = false;
                            _DataGridView2.Rows[row].Cells[0].Value = backTidSeedHexValue;
                        }
                        tid++;
                    }
                }
                else if (pidCheckBox.Checked == false && sidCheckBox.Checked == false)
                {
                    for (ushort b = 0; b < maxResults; b++)
                    {
                        sid = GetHighShortSeed(GetNextSeedGC(tid));
                        printBackSeed(tid, sid);
                        tid++;
                    }
                }
                else if (sidCheckBox.Checked == false && pidCheckBox.Checked == true)
                {
                    for (int b = 0; b < 65536 && counterMax < maxResults; b++)
                    {
                        sid = GetHighShortSeed(GetNextSeedGC(tid));

                        uint shinypidseed = tid;
                        for (int i = 0; i < 7; i++)
                        {
                            shinypidseed = GetNextSeedGC(shinypidseed);
                        }

                        string hexpid = GetHighShortSeed(shinypidseed).ToString("X") + GetHighShortSeed(GetNextSeedGC(shinypidseed)).ToString("X");
                        uint.TryParse(hexpid, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out pid);

                        if (IsShiny(GetHighShortSeed(tid), sid, pid))
                        {
                            printBackSeed(tid, sid);
                            counterMax++;
                        }
                        tid++;
                    }
                }
                else
                {
                    ushort.TryParse(sidTextBox.Text, out sid);
                    string sidHexValue = sid.ToString("X");
                    ushort.TryParse(sidHexValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out sid);

                    if (IsShiny(GetHighShortSeed(tid), sid, pid))
                    {
                        for (int b = 0; b < 65536 && counterMax <= maxResults; b++)
                        {
                            if (GetHighShortSeed(GetNextSeedGC(tid)) == sid)
                            {
                                counterMax++;
                                string backTidSeedHexValue = GetBackSeedGC(tid).ToString("X");
                                int row = _DataGridView2.Rows.Add();
                                sidColumn.Visible = false;
                                _DataGridView2.Rows[row].Cells[0].Value = backTidSeedHexValue;
                            }
                            tid++;
                        }
                    }
                }
            }
        }

        private void printBackSeed(uint _tidSeed, ushort _sid)
        {
            string backTidSeedHexValue = GetBackSeedGC(_tidSeed).ToString("X");
            int row = _DataGridView2.Rows.Add();
            sidColumn.Visible = true;
            _DataGridView2.Rows[row].Cells[0].Value = backTidSeedHexValue;
            _DataGridView2.Rows[row].Cells[1].Value = _sid.ToString();
        }

        private void sidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sidTextBox.Enabled = sidCheckBox.Checked;
        }

        private void pidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pidTextBox2.Enabled = pidCheckBox.Checked;
        }

        private void maxResultsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (maxResultsTextBox.Text == "")
            {
                maxResultsTextBox.Text = "1";
            }
        }
        #endregion

        #region Both
        public FrameFinder()
        {
            InitializeComponent();
        }

        private ushort GetHighShortSeed(uint seed)
        {
            return (ushort)(seed >> 16);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_DataGridView1.GetCellCount(DataGridViewElementStates.Selected) > 0 && tabControl1.SelectedIndex == 0)
            {
                Clipboard.SetDataObject(_DataGridView1.GetClipboardContent());
            }
            else if (_DataGridView2.GetCellCount(DataGridViewElementStates.Selected) > 0 && tabControl1.SelectedIndex == 1)
            {
                Clipboard.SetDataObject(_DataGridView2.GetClipboardContent());
            }
            else
            {
                MessageBox.Show("Please select the frame", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}