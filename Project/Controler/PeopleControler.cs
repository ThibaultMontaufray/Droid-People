﻿// Log code 02 00

using Facebook;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tools4Libraries;

namespace Droid_People
{
    public static class PeopleControler
    {
        #region Attribute
        private static List<FirstName> _firstNames;
        private static Person _currentPerson;
        #endregion

        #region Properties
        public static List<FirstName> FirstNames
        {
            get { return _firstNames; }
            set { _firstNames = value; }
        }
        #endregion

        #region Constructor
        static PeopleControler()
        {
            LoadFirstNames();
        }
        #endregion

        #region Methods public
        public static Person Search(string keyWords, string workingDirectory)
        {
            _currentPerson = new Person(workingDirectory);

            AnalyseKeyWorkds(keyWords, workingDirectory);
            SearchFacebook();
            SearchLinkedIn();
            SearchTwitter();
            SearchGoogle(keyWords);

            return _currentPerson;
        }
        public static FirstName GetFirstName(string firstname)
        {
            List<FirstName> finalFirstName = new List<FirstName>();

            finalFirstName = _firstNames.Where(f => f.Firstname.ToLower().Equals(firstname.ToLower())).ToList();
            if (finalFirstName.Count > 0) return finalFirstName.First();
            else return new FirstName() { Firstname = firstname };
        }
        #endregion

        #region Methods private
        private static void AnalyseKeyWorkds(string keyWords, string workingDirectory)
        {
            string[] tab = keyWords.Split(' ');
            List<FirstName> firstnames;
            
            if (tab.Length == 2)
            {
                firstnames = _firstNames.Where(f => f.Firstname.ToLower().Equals(tab[0].ToLower())).ToList();
                if (!string.IsNullOrEmpty(tab[0]) && firstnames.Count > 0)
                {
                    _currentPerson.FirstName = firstnames.First();
                    _currentPerson.FamilyName = tab[1];
                }
                else if (!string.IsNullOrEmpty(tab[1]))
                {
                    firstnames = _firstNames.Where(f => f.Firstname.ToLower().Equals(tab[1].ToLower())).ToList();
                    if (firstnames.Count > 0)
                    {
                        _currentPerson.FirstName = firstnames.First();
                        _currentPerson.FamilyName = tab[0];
                    }
                }
            }
        }
        private static void LoadFirstNames()
        {
            bool header = true;
            FirstName firstName;
            string[] tab;
            _firstNames = new List<FirstName>();
            
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream objStream = assembly.GetManifestResourceStream("Droid_People.Resources.prenom.csv");
            StreamReader objReader = new StreamReader(objStream);
            string firstnameFile = objReader.ReadToEnd();

            foreach (string line in firstnameFile.Split('\n'))
            {
                if (!header)
                { 
                    tab = line.Split(',');
                    if (tab.Length == 7)
                    {
                        firstName = new FirstName()
                        {
                            Univers = tab[0],
                            Type = tab[1],
                            Firstname = tab[2],
                            Gender = tab[3],
                            Description = tab[4],
                            Culture = tab[5],
                            Origin = tab[6]
                        };
                        _firstNames.Add(firstName);
                    }
                }
                else
                {
                    header = false;
                }
            }
        }
        private static void SearchFacebook()
        {
            FacebookClient client = new FacebookClient();
        }
        private static void SearchLinkedIn()
        {

        }
        private static void SearchTwitter()
        {

        }
        private static void SearchGoogle(string keyWords)
        {
            List<string> imgUrl = Droid_web.Web.GetImages(keyWords);

            for (int i = 0; i < (imgUrl.Count > 10 ? 10: imgUrl.Count); i++)
            {
                try
                {
                    HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(imgUrl[i]);
                    webRequest.AllowWriteStreamBuffering = true;
                    webRequest.Timeout = 10000;
                    WebResponse webResponse = webRequest.GetResponse();
                    Stream stream = webResponse.GetResponseStream();

                    Image img = Image.FromStream(stream);

                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    byte[] array = ms.ToArray();
                    string imgString = Convert.ToBase64String(array);

                    _currentPerson.SerializedPicture.Add(imgString);
                    webResponse.Close();
                }
                catch (Exception exp)
                {
                    Log.Write("[ ERR : 0200 ] Error while loading people picture : " + imgUrl[i] + "\n\n" + exp.Message);
                }
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
