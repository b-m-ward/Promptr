using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promptr.Core.Services
{
    public class NameService
    {
        private List<string> _firstNames { get; set; }
        private List<string> _lastNames { get; set; }

        public string FirstName
        {
            get
            {
                return GetFirstName().Replace("\r", "");
            }
        }

        public string LastName
        {
            get
            {
                return GetLastName().Replace("\r", "");
            }
        }

        public NameService()
        {
            _firstNames = _buildFirstNames();
            _lastNames = _buildLastNames();

        }

        /// <summary>
        /// Reads from the Assets/FirstName text file and outputs a list of return-separated names
        /// </summary>
        /// <returns>List of return-separated first names.</returns>
        private List<string> _buildFirstNames()
        {
            try
            {
                List<string> output = new List<string>();
                string fileContents = File.ReadAllText("../net5.0/Assets/FirstNames.txt");
                var split = fileContents.Split("\n");
                output = split.ToList();

                return output;

            }
            catch (Exception ex)
            {
                var exc = ex;
                throw;
            }
        }

        public string GetFirstName()
        {
            Random rng = new Random();
            return _firstNames[rng.Next(0, _firstNames.Count - 1)].Replace("\r", "");
        }

        public string GetLastName()
        {
            Random rng = new Random();
            return _lastNames[rng.Next(0, _lastNames.Count - 1)].Replace("\r", "");
        }

        /// <summary>
        /// Reads from the Assets/FirstName text file and outputs a list of return-separated names
        /// </summary>
        /// <returns>List of return-separated last names.</returns>
        private List<string> _buildLastNames()
        {
            try
            {
                List<string> output = new List<string>();
                string fileContents = File.ReadAllText("../net5.0/Assets/LastNames.txt");
                var split = fileContents.Split("\n");
                output = split.ToList();

                return output;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
