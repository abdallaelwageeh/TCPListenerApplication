using System;
using System.Drawing;
using System.Windows.Forms;

namespace TCPListenerApplication
{
    internal static class UiRuntimeChange
    {
        internal static void Log(string message, LogType type,RichTextBox tool)
        {
            switch (type)
            {
                case LogType.Error:
                    tool.Invoke(GenerateAction(message, Color.Red,tool));
                    break;
                case LogType.Message:
                    tool.Invoke(GenerateAction(message, Color.Green,tool));
                    break;
                case LogType.Disconnect:
                    tool.Invoke(GenerateAction(message, Color.Blue,tool));
                    break;
            }
        }
        private static Action GenerateAction(string message, Color selectedColor,RichTextBox tool)
        {
            return new Action(() =>
            {
                tool.SelectionStart = tool.TextLength;
                tool.SelectionLength = 0;
                tool.SelectionColor = selectedColor;
                tool.AppendText(message);
                tool.Select(tool.Text.Length - 1, 0);
                tool.ScrollToCaret();
                tool.ForeColor = Color.Black;
            });
        }
        internal enum LogType
        {
            Error,
            Message,
            Disconnect
        }
    }
}
