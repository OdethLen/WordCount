using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Windows.Forms;

namespace WordCount
{
    public partial class Form1 : Form
    {

        int WordCount;
        public Form1()
        {
            InitializeComponent();
            WordCount = 0;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = "DOCX FILE |*.docx";

            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                using (WordprocessingDocument WordDocument = WordprocessingDocument.Open(openfiledialog.FileName, false))
                {
                    Body body = WordDocument.MainDocumentPart.Document.Body;
                    string text = "";

                    foreach (var paragraph in body.Elements<Paragraph>())
                    {
                        foreach (var run in paragraph.Elements<Run>())
                        {
                            foreach (var textElement in run.Elements<Text>())
                            {
                                text += textElement.Text;
                            }
                        }
                    }

                    txtDocument.Text = text;

                    string[] Words = text.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    string LargestWord = "";
                    foreach (string Word in Words)
                    {
                        if (Word.Length > LargestWord.Length)
                        {
                            LargestWord = Word;
                        }
                    }
                    lblLargestWord.Text = "Largest Word: " + LargestWord;


                   
                }
            }



        }
    }
}
