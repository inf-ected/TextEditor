﻿using System.IO;
using System.Text;


namespace TextEditor.BL
{
    public interface IFileManager
    {
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);
        void SaveContent(string content, string filePath, Encoding encoding);
        int GetSymbolCount(string content);
        bool IsExist(string Path);
    }

    public class FileManager : IFileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);


        public bool IsExist(string Path)
        {
            bool isExist = File.Exists(Path);
            return isExist;
        }
        public string GetContent(string filePath)
        {
            //  string content = File.ReadAllText(filePath, _defaultEncoding);
            //  return content;
            return GetContent(filePath, _defaultEncoding);
        }
        public string GetContent(string filePath, Encoding encoding )
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }
        public void SaveContent(string content, string filePath)
        {
            SaveContent(content,  filePath, _defaultEncoding);
        }
        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }
        public int GetSymbolCount(string content)
        {
            int count = content.Length;
            return count;
        }
    }
}
