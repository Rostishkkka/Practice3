using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;

namespace InteropDocument
{
     class InteropObject
    {
        private FileInfo fileInfo;

        public InteropObject(string filePath) { 
            if(File.Exists(filePath))
            {
                fileInfo = new FileInfo(filePath);
            }
            else
            {
                MessageBox.Show("Файла не существует");
                fileInfo = null;
            }
        }

        public void Process (Dictionary<string, string> dataDoc){
            if(fileInfo != null)
            {
                var app = new Word.Application();
                app.Documents.Open(fileInfo.FullName);
                Find find = app.Selection.Find;

                foreach (var item in dataDoc)
                {
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    find.Execute(
                        FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: Type.Missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: WdFindWrap.wdFindContinue,
                        Format: false,
                        ReplaceWith: Type.Missing,
                        Replace: WdReplace.wdReplaceAll);
                }

                string newFilePath = Path.Combine(fileInfo.DirectoryName, "Свидетельство о расторжении брака.docx");
                app.ActiveDocument.SaveAs2(newFilePath);
                app.ActiveDocument.Close();
                app.Quit();
            }
        }
    }
}
