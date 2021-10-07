using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promptr.Core.Services
{
    public class CharacteristicsService
    {
        private string[] _occupations;
        private string[] _characteristics;
        public CharacteristicsService()
        {
            _occupations = _buildOccupationList();
            _characteristics = _buildCharacteristicsList();
        }

        public string GetOccupation()
        {
            Random rng = new Random();
            return _occupations[rng.Next(0, _occupations.Count() - 1)].Replace("\r", "").ToLower();
        }


        private string[] _buildOccupationList()
        {
            try
            {
                string fileContents = File.ReadAllText("../net5.0/Assets/Occupations.txt");
                return fileContents.Split("\n");
            }
            catch (Exception ex)
            {
                var exc = ex;
                throw;
            }
        }

        private string[] _buildCharacteristicsList()
        {
            try
            {
                string fileContents = File.ReadAllText("../net5.0/Assets/Characteristics.txt");
                return fileContents.Split("\n");
            }
            catch (Exception ex)
            {
                var exc = ex;
                throw;
            }
        }

        public IEnumerable<string> GetTraits(int numTraits)
        {
            try
            {
                var traits = new List<string>();
                for (int i = 0; i < numTraits; i++)
                {
                    Random rng = new Random();
                    //don't dupe traits
                    string trait = _characteristics[rng.Next(0, _characteristics.Length - 1)].Replace("\r", "").ToLower();
                    if(traits.Contains(trait) && i > 0)
                    {
                        i--;
                    } 
                    else
                    {
                        traits.Add(trait);
                    }
                }

                return traits.AsEnumerable();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
