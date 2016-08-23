using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace NXT2EV3ControlApplication
{
    public partial class NXT2EV3ControlApplicationForm : Form
    {
        enum MailboxTypeEnum { MailboxTypeString, MailboxTypeNumber, MailboxTypeBoolean, MailboxTypeNone };

        static readonly object _object = new object();

        public SerialPort NXTport = new SerialPort();
        public SerialPort EV3port = new SerialPort();

        public bool NXTportConnected = false;
        public bool EV3portConnected = false;

        private MailboxTypeEnum MailboxType1Selected = MailboxTypeEnum.MailboxTypeNone;
        private MailboxTypeEnum MailboxType2Selected = MailboxTypeEnum.MailboxTypeNone;
        private MailboxTypeEnum MailboxType3Selected = MailboxTypeEnum.MailboxTypeNone;
        private MailboxTypeEnum MailboxType4Selected = MailboxTypeEnum.MailboxTypeNone;
        private MailboxTypeEnum MailboxType5Selected = MailboxTypeEnum.MailboxTypeNone;
        private MailboxTypeEnum MailboxType6Selected = MailboxTypeEnum.MailboxTypeNone;
        private MailboxTypeEnum MailboxType7Selected = MailboxTypeEnum.MailboxTypeNone;
        private MailboxTypeEnum MailboxType8Selected = MailboxTypeEnum.MailboxTypeNone;
        private MailboxTypeEnum MailboxType9Selected = MailboxTypeEnum.MailboxTypeNone;
        private MailboxTypeEnum MailboxType10Selected = MailboxTypeEnum.MailboxTypeNone;

        System.Threading.Thread ReadNXTMailboxesWorker;

        public NXT2EV3ControlApplicationForm()
        {
            InitializeComponent();
        }

        private void NXT2EV3ControlApplicationForm_Load(object sender, EventArgs e)
        {
            //create and start a new thread in the load event.
            //passing it a method to be run on the new thread.
            ReadNXTMailboxesWorker = new System.Threading.Thread(StartLooping);
            ReadNXTMailboxesWorker.Start();
        }

        public class NoConnectionException : System.Exception
        {
            public NoConnectionException() : base() { }
            public NoConnectionException(string message) : base(message) { }
            public NoConnectionException(string message, System.Exception inner) : base(message, inner) { }
        }

        private void NXTComPortButton_Click(object sender, EventArgs e)
        {
            if (!NXTportConnected)
            {
                try
                {
                    NXTport.PortName = this.NXTComPortText.Text;
                    NXTport.BaudRate = 9600;
                    NXTport.DataBits = 8;
                    NXTport.Parity = Parity.None;
                    NXTport.StopBits = StopBits.One;
                    NXTport.ReadTimeout = 2000;

                    NXTComPortButton.Text = "Connecting ...";
                    NXTComPortButton.Refresh();
                    Cursor.Current = Cursors.WaitCursor;

                    NXTport.Open();

                    NXTportConnected = true;
                    NXTComPortConnected.Checked = true;
                    NXTComPortButton.Text = "Disconnect";
                    Cursor.Current = Cursors.Default;

                    Mailbox1Type.Enabled = true;
                    Mailbox1Active.Enabled = Mailbox1Type.SelectedIndex != 0;

                    Mailbox2Type.Enabled = true;
                    Mailbox2Active.Enabled = Mailbox2Type.SelectedIndex != 0;

                    Mailbox3Type.Enabled = true;
                    Mailbox3Active.Enabled = Mailbox3Type.SelectedIndex != 0;

                    Mailbox4Type.Enabled = true;
                    Mailbox4Active.Enabled = Mailbox4Type.SelectedIndex != 0;

                    Mailbox5Type.Enabled = true;
                    Mailbox5Active.Enabled = Mailbox5Type.SelectedIndex != 0;

                    Mailbox6Type.Enabled = true;
                    Mailbox6Active.Enabled = Mailbox6Type.SelectedIndex != 0;

                    Mailbox7Type.Enabled = true;
                    Mailbox7Active.Enabled = Mailbox7Type.SelectedIndex != 0;

                    Mailbox8Type.Enabled = true;
                    Mailbox8Active.Enabled = Mailbox8Type.SelectedIndex != 0;

                    Mailbox9Type.Enabled = true;
                    Mailbox9Active.Enabled = Mailbox9Type.SelectedIndex != 0;

                    Mailbox10Type.Enabled = true;
                    Mailbox10Active.Enabled = Mailbox10Type.SelectedIndex != 0;
                }
                catch (Exception ex)
                {
                    NXTComPortButton.Text = "Connect";
                    Cursor.Current = Cursors.Default;
                    
                    MessageBox.Show(this, "Error on NXT connection: " + ex.Message);

                    return;
                }
            }
            else
            {
                Mailbox1Type.Enabled = false;
                Mailbox1Active.Enabled = false;
                Mailbox1Active.Checked = false;

                Mailbox2Type.Enabled = false;
                Mailbox2Active.Enabled = false;
                Mailbox2Active.Checked = false;

                Mailbox3Type.Enabled = false;
                Mailbox3Active.Enabled = false;
                Mailbox3Active.Checked = false;

                Mailbox4Type.Enabled = false;
                Mailbox4Active.Enabled = false;
                Mailbox4Active.Checked = false;

                Mailbox5Type.Enabled = false;
                Mailbox5Active.Enabled = false;
                Mailbox5Active.Checked = false;

                Mailbox6Type.Enabled = false;
                Mailbox6Active.Enabled = false;
                Mailbox6Active.Checked = false;

                Mailbox7Type.Enabled = false;
                Mailbox7Active.Enabled = false;
                Mailbox7Active.Checked = false;

                Mailbox8Type.Enabled = false;
                Mailbox8Active.Enabled = false;
                Mailbox8Active.Checked = false;

                Mailbox9Type.Enabled = false;
                Mailbox9Active.Enabled = false;
                Mailbox9Active.Checked = false;

                Mailbox10Type.Enabled = false;
                Mailbox10Active.Enabled = false;
                Mailbox10Active.Checked = false;

                NXTport.Close();

                NXTportConnected = false;
                NXTComPortConnected.Checked = false;
                NXTComPortButton.Text = "Connect";
            }

        }

        private void EV3ComPortButton_Click(object sender, EventArgs e)
        {
            if (!EV3portConnected)
            {
                try
                {
                    EV3port.PortName = this.EV3ComPortText.Text;
                    EV3port.BaudRate = 9600;
                    EV3port.DataBits = 8;
                    EV3port.Parity = Parity.None;
                    EV3port.StopBits = StopBits.One;
                    EV3port.ReadTimeout = 1000;

                    EV3ComPortButton.Text = "Connecting ...";
                    EV3ComPortButton.Refresh();
                    Cursor.Current = Cursors.WaitCursor;

                    EV3port.Open();
                }
                catch (Exception ex)
                {
                    EV3ComPortButton.Text = "Connect";
                    Cursor.Current = Cursors.Default;

                    MessageBox.Show(this, "Error on EV3 connection: " + ex.Message);

                    return;
                }
                EV3portConnected = true;
                EV3ComPortConnected.Checked = true;
                EV3ComPortButton.Text = "Disconnect";
                Cursor.Current = Cursors.Default;
            }
            else
            {
                EV3port.Close();

                EV3portConnected = false;
                EV3ComPortConnected.Checked = false;
                EV3ComPortButton.Text = "Connect";
            }
        }

        // Main loop to read the NXT mailboxes
        public void StartLooping()
        {
            while (true)
            {
                if (NXTportConnected)
                {
                    if (Mailbox1Active.Checked)
                    {
                        NXTportCallbackHandlerGeneric(0x0A, "M1", MailboxType1Selected);
                    }
                    if (Mailbox2Active.Checked)
                    {
                        NXTportCallbackHandlerGeneric(0x0B, "M2", MailboxType2Selected);
                    }
                    if (Mailbox3Active.Checked)
                    {
                        NXTportCallbackHandlerGeneric(0x0C, "M3", MailboxType3Selected);
                    }
                    if (Mailbox4Active.Checked)
                    {
                        NXTportCallbackHandlerGeneric(0x0D, "M4", MailboxType4Selected);
                    }
                    if (Mailbox5Active.Checked)
                    {
                        NXTportCallbackHandlerGeneric(0x0E, "M5", MailboxType5Selected);
                    }
                    if (Mailbox6Active.Checked)
                    {
                        NXTportCallbackHandlerGeneric(0x0F, "M6", MailboxType6Selected);
                    }
                    if (Mailbox7Active.Checked)
                    {
                        NXTportCallbackHandlerGeneric(0x10, "M7", MailboxType7Selected);
                    }
                    if (Mailbox8Active.Checked)
                    {
                        NXTportCallbackHandlerGeneric(0x11, "M8", MailboxType8Selected);
                    }
                    if (Mailbox9Active.Checked)
                    {
                        NXTportCallbackHandlerGeneric(0x12, "M9", MailboxType9Selected);
                    }
                    if (Mailbox10Active.Checked)
                    {
                        NXTportCallbackHandlerGeneric(0x13, "M10", MailboxType10Selected);
                    }
                }
            }
        }

        private void NXTportCallbackHandlerGeneric(byte NXTMailbox, string EV3Mailbox, MailboxTypeEnum MailboxType)
        {
            switch (MailboxType)
            {
                case MailboxTypeEnum.MailboxTypeString:
                    {
                        NXTportCallbackHandlerMailboxTypeString(NXTMailbox, EV3Mailbox);
                        break;
                    }

                case MailboxTypeEnum.MailboxTypeBoolean:
                    {
                        NXTportCallbackHandlerMailboxTypeBoolean(NXTMailbox, EV3Mailbox);
                        break;
                    }

                case MailboxTypeEnum.MailboxTypeNumber:
                    {
                        NXTportCallbackHandlerMailboxTypeNumber(NXTMailbox, EV3Mailbox);
                        break;
                    }
                default:
                    {
                        // Should not come here
                        Debug.Assert(false);
                        break;
                    }
            }
        }

        private void NXTportCallbackHandlerMailboxTypeString(byte NXTMailbox, string EV3Mailbox)
        {
            // Next piece of code should not be re-entrant
            lock (_object)
            {
                String s1 = "";
                String s2 = "";

                try
                {
                    byte[] NXTMessageHeader = { 0x00, 0x00 };
                    byte[] Command = { 0x00, 0x13, NXTMailbox, 0x0, 0x01 };

                    NXTMessageHeader[0] = (byte)Command.Length;

                    NXTport.Write(NXTMessageHeader, 0, NXTMessageHeader.Length);
                    NXTport.Write(Command, 0, Command.Length);

                    int lsb = NXTport.ReadByte();
                    int msb = NXTport.ReadByte();

                    int length = lsb + 256 * msb;

                    // retrieve the reply data
                    for (int i = 0; i < length; i++)
                    {
                        if (i < 5)
                        {
                            s1 += NXTport.ReadByte().ToString("X2") + " ";
                        }
                        else
                        {
                            s2 += (char)NXTport.ReadByte();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                s1 = s1.Trim('\0'); s1 = s1.Trim();
                s2 = s2.Trim('\0'); s2 = s2.Trim();

                if (s2 != "")
                {
                    // Send string S2 to mailbox "M2"
                    // byte[] MessageHeader = { 0x14, 0x00, 0x00, 0x01, 0x81, 0x9E, 0x03, 0x4D, 0x31, 0x00, 0x0A, 0x00, 0x4C, 0x45, 0x46, 0x54, 0x44, 0x52, 0x49, 0x56, 0x45, 0x00 };

                    // If EV3 is not connected (yet), you can skip the following
                    if (EV3portConnected)
                    {
                        int MessageHeaderLength = 2 + 2 + 2 + 1 + 2 + s2.Length + 1 + EV3Mailbox.Length + 1;

                        byte[] EV3MessageHeader = new byte[MessageHeaderLength];

                        EV3MessageHeader[0] = (byte)(MessageHeaderLength - 2);
                        EV3MessageHeader[1] = (byte)0x00;
                        EV3MessageHeader[2] = (byte)0x00;
                        EV3MessageHeader[3] = (byte)0x01;
                        EV3MessageHeader[4] = (byte)0x81;
                        EV3MessageHeader[5] = (byte)0x9E;
                        EV3MessageHeader[6] = (byte)(EV3Mailbox.Length + 1); // Size of Mailboxname (including \0)

                        for (int i = 0; i < EV3Mailbox.Length; i++)
                        {
                            EV3MessageHeader[7 + i] = (byte)(EV3Mailbox[i]);
                        }
                        EV3MessageHeader[7 + EV3Mailbox.Length] = (byte)0x00;

                        EV3MessageHeader[7 + EV3Mailbox.Length + 1] = (byte)(s2.Length + 1);
                        EV3MessageHeader[7 + EV3Mailbox.Length + 2] = (byte)0x00;

                        for (int i = 0; i < s2.Length; i++)
                        {
                            EV3MessageHeader[7 + EV3Mailbox.Length + 3 + i] = (byte)(s2[i]);
                        }
                        EV3MessageHeader[7 + EV3Mailbox.Length + 3 + s2.Length] = (byte)0x00;

                        EV3port.Write(EV3MessageHeader, 0, EV3MessageHeader.Length);
                    }
                }
            }
        }

        private void NXTportCallbackHandlerMailboxTypeNumber(byte NXTMailbox, string EV3Mailbox)
        {
            // Next piece of code should not be re-entrant
            lock (_object)
            {
                byte[] NXTMessageHeader = { 0x00, 0x00 };
                byte[] Command = { 0x00, 0x13, NXTMailbox, 0x0, 0x01 };

                NXTMessageHeader[0] = (byte)Command.Length;
                byte[] readmessage = null;

                try
                {
                    NXTport.Write(NXTMessageHeader, 0, NXTMessageHeader.Length);
                    NXTport.Write(Command, 0, Command.Length);

                    int lsb = NXTport.ReadByte();
                    int msb = NXTport.ReadByte();

                    int length = lsb + 256 * msb;

                    readmessage = new byte[length];

                    for (int i = 0; i < length; i++)
                    {
                        readmessage[i] = (byte)NXTport.ReadByte();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (EV3portConnected)
                {
                    int MessageHeaderLength = 2 + 2 + 2 + 1 + 2 + 4 + (EV3Mailbox.Length + 1);

                    byte[] EV3MessageHeader = new byte[MessageHeaderLength];

                    EV3MessageHeader[0] = (byte)(MessageHeaderLength - 2);
                    EV3MessageHeader[1] = (byte)0x00;
                    EV3MessageHeader[2] = (byte)0x00;
                    EV3MessageHeader[3] = (byte)0x01;
                    EV3MessageHeader[4] = (byte)0x81;
                    EV3MessageHeader[5] = (byte)0x9E;
                    EV3MessageHeader[6] = (byte)(EV3Mailbox.Length + 1); // Size of Mailboxname (including \0)

                    for (int i = 0; i < EV3Mailbox.Length; i++)
                    {
                        EV3MessageHeader[7 + i] = (byte)(EV3Mailbox[i]);
                    }
                    EV3MessageHeader[7 + EV3Mailbox.Length] = (byte)0x00;

                    EV3MessageHeader[7 + EV3Mailbox.Length + 1] = (byte)0x04;
                    EV3MessageHeader[7 + EV3Mailbox.Length + 2] = (byte)0x00;

                    EV3MessageHeader[7 + EV3Mailbox.Length + 3] = (byte)readmessage[5];
                    EV3MessageHeader[7 + EV3Mailbox.Length + 4] = (byte)readmessage[6];
                    EV3MessageHeader[7 + EV3Mailbox.Length + 5] = (byte)readmessage[7];
                    EV3MessageHeader[7 + EV3Mailbox.Length + 6] = (byte)readmessage[8];

                    EV3port.Write(EV3MessageHeader, 0, EV3MessageHeader.Length);
                }
            }
        }

        private void NXTportCallbackHandlerMailboxTypeBoolean(byte NXTMailbox, string EV3Mailbox)
        {
            // Next piece of code should not be re-entrant
            lock (_object)
            {
                byte[] NXTMessageHeader = { 0x00, 0x00 };
                byte[] Command = { 0x00, 0x13, NXTMailbox, 0x0, 0x01 };
                byte[] readmessage = null;

                NXTMessageHeader[0] = (byte)Command.Length;

                try
                {
                    NXTport.Write(NXTMessageHeader, 0, NXTMessageHeader.Length);
                    NXTport.Write(Command, 0, Command.Length);

                    int lsb = NXTport.ReadByte();
                    int msb = NXTport.ReadByte();

                    int length = lsb + 256 * msb;

                    readmessage = new byte[length];

                    for (int i = 0; i < length; i++)
                    {
                        readmessage[i] = (byte)NXTport.ReadByte();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                // If byte4 contains 0x02 AND byte5 contains 0x01, than TRUE was send trough mailbox
                // If byte4 contains 0x02 AND byte5 contains 0x00, than FALSE was send through mailbox
                if (readmessage[4] == 0x02)
                {

                    if (EV3portConnected)
                    {
                        int MessageHeaderLength = 2 + 2 + 2 + 1 + 2 + 1 + (EV3Mailbox.Length + 1);

                        byte[] EV3MessageHeader = new byte[MessageHeaderLength];

                        EV3MessageHeader[0] = (byte)(MessageHeaderLength - 2);
                        EV3MessageHeader[1] = (byte)0x00;
                        EV3MessageHeader[2] = (byte)0x00;
                        EV3MessageHeader[3] = (byte)0x01;
                        EV3MessageHeader[4] = (byte)0x81;
                        EV3MessageHeader[5] = (byte)0x9E;
                        EV3MessageHeader[6] = (byte)(EV3Mailbox.Length + 1); // Size of Mailboxname (including \0)

                        for (int i = 0; i < EV3Mailbox.Length; i++)
                        {
                            EV3MessageHeader[7 + i] = (byte)(EV3Mailbox[i]);
                        }
                        EV3MessageHeader[7 + EV3Mailbox.Length] = (byte)0x00;

                        EV3MessageHeader[7 + EV3Mailbox.Length + 1] = (byte)0x01;
                        EV3MessageHeader[7 + EV3Mailbox.Length + 2] = (byte)0x00;

                        EV3MessageHeader[7 + EV3Mailbox.Length + 3] = (readmessage[5] == 1) ? (byte)0x01 : (byte)0x00;

                        EV3port.Write(EV3MessageHeader, 0, EV3MessageHeader.Length);
                    }
                }
            }
        }

        MailboxTypeEnum MailBoxType2Enum(int value)
        {
            MailboxTypeEnum returnvalue = MailboxTypeEnum.MailboxTypeNone;

            switch (value)
            {
                case 0:
                    {
                        returnvalue = MailboxTypeEnum.MailboxTypeNone;
                        break;
                    }

                case 1:
                    {
                        returnvalue = MailboxTypeEnum.MailboxTypeString;
                        break;
                    }

                case 2:
                    {
                        returnvalue = MailboxTypeEnum.MailboxTypeNumber;
                        break;
                    }

                case 3:
                    {
                        returnvalue = MailboxTypeEnum.MailboxTypeBoolean;
                        break;
                    }

                default:
                    {
                        Debug.Assert(false);
                        break;
                    }
            }

            return returnvalue;
        }

        private void Mailbox1Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailboxType1Selected = MailBoxType2Enum(Mailbox1Type.SelectedIndex);
            
            if (Mailbox1Type.SelectedIndex == 0)
            {
                Mailbox1Active.Enabled = false;
                Mailbox1Active.Checked = false;
            }
            else
            {
                Mailbox1Active.Enabled = NXTportConnected;
            }
        }

        private void Mailbox2Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailboxType2Selected = MailBoxType2Enum(Mailbox2Type.SelectedIndex);

            if (Mailbox2Type.SelectedIndex == 0)
            {
                Mailbox2Active.Enabled = false;
                Mailbox2Active.Checked = false;
            }
            else
            {
                Mailbox2Active.Enabled = NXTportConnected;
            }
        }

        private void Mailbox3Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailboxType3Selected = MailBoxType2Enum(Mailbox3Type.SelectedIndex);

            if (Mailbox3Type.SelectedIndex == 0)
            {
                Mailbox3Active.Enabled = false;
                Mailbox3Active.Checked = false;
            }
            else
            {
                Mailbox3Active.Enabled = NXTportConnected;
            }
        }

        private void Mailbox4Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailboxType4Selected = MailBoxType2Enum(Mailbox4Type.SelectedIndex);

            if (Mailbox4Type.SelectedIndex == 0)
            {
                Mailbox4Active.Enabled = false;
                Mailbox4Active.Checked = false;
            }
            else
            {
                Mailbox4Active.Enabled = NXTportConnected;
            }
        }


        private void Mailbox5Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailboxType5Selected = MailBoxType2Enum(Mailbox5Type.SelectedIndex);

            if (Mailbox5Type.SelectedIndex == 0)
            {
                Mailbox5Active.Enabled = false;
                Mailbox5Active.Checked = false;
            }
            else
            {
                Mailbox5Active.Enabled = NXTportConnected;
            }
        }

        private void Mailbox6Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailboxType6Selected = MailBoxType2Enum(Mailbox6Type.SelectedIndex);

            if (Mailbox6Type.SelectedIndex == 0)
            {
                Mailbox6Active.Enabled = false;
                Mailbox6Active.Checked = false;
            }
            else
            {
                Mailbox6Active.Enabled = NXTportConnected;
            }
        }

        private void Mailbox7Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailboxType7Selected = MailBoxType2Enum(Mailbox7Type.SelectedIndex);

            if (Mailbox7Type.SelectedIndex == 0)
            {
                Mailbox7Active.Enabled = false;
                Mailbox7Active.Checked = false;
            }
            else
            {
                Mailbox7Active.Enabled = NXTportConnected;
            }
        }

        private void Mailbox8Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailboxType8Selected = MailBoxType2Enum(Mailbox8Type.SelectedIndex);

            if (Mailbox8Type.SelectedIndex == 0)
            {
                Mailbox8Active.Enabled = false;
                Mailbox8Active.Checked = false;
            }
            else
            {
                Mailbox8Active.Enabled = NXTportConnected;
            }
        }

        private void Mailbox9Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailboxType9Selected = MailBoxType2Enum(Mailbox9Type.SelectedIndex);

            if (Mailbox9Type.SelectedIndex == 0)
            {
                Mailbox9Active.Enabled = false;
                Mailbox9Active.Checked = false;
            }
            else
            {
                Mailbox9Active.Enabled = NXTportConnected;
            }
        }

        private void Mailbox10Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            MailboxType10Selected = MailBoxType2Enum(Mailbox10Type.SelectedIndex);

            if (Mailbox10Type.SelectedIndex == 0)
            {
                Mailbox10Active.Enabled = false;
                Mailbox10Active.Checked = false;
            }
            else
            {
                Mailbox10Active.Enabled = NXTportConnected;
            }
        }

    }
}
