﻿using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace FirstMVCApp.Models
{
    public class AuthorRepository
    {

        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            string fName = @"c:\temp\Authors.csv";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExits = System.IO.File.Exists(fName);
            if (isFileExits)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    string[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(',');
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.AuthorID, author);
                            }
                        }
                    }

                }
            }
            return list;
        }

        public static Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.NoOfBookPublished = int.Parse(data[2]);
            author.Royalty = data[3];
            author.DOB = DateTime.Parse(data[4]);
            return author;

        }

        public static Author FindAuthorById(int id)
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if (list != null)
            {
                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            }
            return author;

        }
        public static void SaveToFile(Author pAuthor) {
            String fName = @"c:\temp\Authors.csv";
            string strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.NoOfBookPublished},{pAuthor.Royalty},{pAuthor.DOB}";
            using (StreamWriter s = new StreamWriter(fName, true))
            {
                s.WriteLine(strAuthor);
            }
        }
        public static void UpdateAuthorToFile(Author pAuthor)
        {
            string fName = @"c:\temp\Authors.csv";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            string strAuthor = string.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (Author author in list.Values)
                {
                    if (author.AuthorID != pAuthor.AuthorID)
                        strAuthor = $"{author.AuthorID},{author.AuthorName},{author.NoOfBookPublished},{author.Royalty},{author.DOB}";
                    else
                        strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.NoOfBookPublished},{pAuthor.Royalty},{pAuthor.DOB}";
                    sw.WriteLine(strAuthor);
                }

            }
        }




        public static void RemoveAuthor(int id)
        {
            string fName = @"c:\temp\Authors.csv";
            Dictionary<int,Author> list = AuthorRepository.GetAuthorDictionary();
           StringBuilder sbAuthors=new StringBuilder(list.Count+100);
            using(StreamWriter sw = new StreamWriter(fName))
            {
                foreach(Author author in list.Values)
                {
                    if(author.AuthorID != id)
                       sbAuthors.Append( $"{author.AuthorID},{author.AuthorName},{author.NoOfBookPublished},"+
                            $"{author.Royalty},{author.DOB}{Environment.NewLine}");
                   
                }
            }
            File.WriteAllText(fName, sbAuthors.ToString());
            
        }
        //    public static void SaveAllAuthorToFile(Dictionary<int, Author> ) { }
        //}
    }
}

