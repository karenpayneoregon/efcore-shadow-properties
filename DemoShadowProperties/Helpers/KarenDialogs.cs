using System.Windows.Forms;

namespace DemoShadowProperties.Helpers
{
    public static class KarenDialogs
    {
        public static bool Question(string text)
        {
            return (MessageBox.Show(
                text, 
                "Question", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
    }
}
