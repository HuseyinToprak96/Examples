using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    /*
     10. Command: Bir işlemi nesne olarak temsil eden bir desendir. İşlemi gerçekleştirmek için gerekli olan tüm bilgiler komut nesnesinde bulunur.
     */
    // Komut arayüzü
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    // Komutları uygulayan ConcreteCommand sınıfları
    public class CutCommand : ICommand
    {
        private Editor editor;
        private string backup;

        public CutCommand(Editor editor)
        {
            this.editor = editor;
        }

        public void Execute()
        {
            backup = editor.GetSelection();
            editor.Cut();
        }

        public void Undo()
        {
            editor.ClearSelection();
            editor.Insert(backup);
        }
    }

    public class PasteCommand : ICommand
    {
        private Editor editor;
        private string clipboard;

        public PasteCommand(Editor editor, string clipboard)
        {
            this.editor = editor;
            this.clipboard = clipboard;
        }

        public void Execute()
        {
            editor.Insert(clipboard);
        }

        public void Undo()
        {
            editor.Delete();
        }
    }

    // Komutları gerçekleştirecek olan Alıcı sınıfı
    // Komutları gerçekleştirecek olan Alıcı sınıfı
    public class Editor
    {
        private string content = string.Empty;
        private string clipboard = string.Empty;
        private string selection = string.Empty;

        public void SetSelection(string selection)
        {
            this.selection = selection;
        }

        public string GetSelection()
        {
            return selection;
        }

        public void Insert(string text)
        {
            content += text;
        }

        public void Delete()
        {
            if (!string.IsNullOrEmpty(content))
            {
                content = content.Substring(0, content.Length - 1);
            }
        }

        public void Cut()
        {
            clipboard = selection;
            Delete();
        }

        public void ClearSelection()
        {
            selection = string.Empty;
        }

        public void PrintContent()
        {
            Console.WriteLine("Editor içeriği: " + content);
        }
    }

}
