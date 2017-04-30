using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeMadness1
{
    class clsRecipe
    {
        private String _strName;
        private int _intId;
        private String _strSeason;
        private char _chFavorite;
        private String _strDirections;
        
        public clsRecipe()
        {
           //set default values
            _intId = -1;
            _strSeason = "Any";
            _chFavorite = ' ';
        }

        public int id
        {
            get { return _intId; }
            set { _intId = value; }
        }

        public string name
        {
            get { return _strName; }
            set { _strName = value; }
        }

        public string season
        {
            get { return _strSeason; }
            set { _strSeason = value; }
        }

        public char favorite
        {
            get { return _chFavorite; }
            set { _chFavorite = value; }
        }

        public String directions
        {
            get { return _strDirections; }
            set { _strDirections = value; }
        }
    }
}
