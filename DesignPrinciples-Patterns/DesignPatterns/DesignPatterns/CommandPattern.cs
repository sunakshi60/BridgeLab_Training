using System;

namespace DesignPatterns
{
    //Receiver
    public class Document
    {
        public void Open()
        {
            Console.WriteLine("Document Opened");
        }
        
        public void Save()
        {
            Console.WriteLine("Document Saved");
        }

        public void Close()
        {
            Console.WriteLine("Documeny Closed");
        }
    }

    //Command Interface
    public interface ICommand
    {
        void Execute();
    }

    //OpenCommand
    public class OpenCommand : ICommand
    {
        private Document document;

        public OpenCommand(Document doc)
        {
            document = doc;
        }

        public void Execute()
        {
            document.Open();
        }
    }

    //SaveCommand
    public class SaveCommand : ICommand
    {
        private Document document;

        public SaveCommand(Document doc)
        {
            document = doc;
        }

        public void Execute()
        {
            document.Save();
        }
    }

    //CloseCommand
    public class CloseCommand : ICommand
    {
        private Document document;

        public CloseCommand(Document doc)
        {
            document = doc;
        }

        public void Execute()
        {
            document.Close();
        }
    }

    //Invoker
    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;

        public MenuOptions(ICommand open,ICommand save, ICommand close)
        {
            openCommand = open;
            saveCommand = save;
            closeCommand = close;
        }

        public void ClickOpen()
        {
            openCommand.Execute();
        }

        public void ClickSave()
        {
            saveCommand.Execute();
        }

        public void ClickClose()
        {
            closeCommand.Execute();
        }
    }
}


