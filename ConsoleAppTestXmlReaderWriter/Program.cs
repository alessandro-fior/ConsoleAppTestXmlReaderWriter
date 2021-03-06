﻿using System;
using System.Xml;

namespace ConsoleAppTestXmlReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            XmlTextReader reader = new XmlTextReader("books.xml");
            reader.WhitespaceHandling = WhitespaceHandling.None;

            //Move the reader to the first book element.
            reader.MoveToContent();
            reader.Read();

            //Create a writer that outputs to the console.
            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            writer.Formatting = Formatting.Indented;

            //Write the start tag.
            writer.WriteStartElement("myBooks");

            //Write the first book.
            writer.WriteNode(reader, false);

            //Skip the second book.
            reader.Skip();

            //Write the last book.
            writer.WriteNode(reader, false);
            writer.WriteEndElement();

            //Close the writer and the reader.
            writer.Close();
            reader.Close();
            //
        }
    }
}
