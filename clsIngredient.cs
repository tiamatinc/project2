using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeMadness1
{
    class clsIngredient
    {
        private String _strName;
        private int _intId;
        private String _strSeason;
        private String _strDescription;

        public clsIngredient()
        {
            //set default values
            _intId = -1;
            _strDescription = "";
            _strSeason = "Any";
            _strName = "";
        }

        public String name
        {
            get { return _strName; }
            set { _strName = value; }
        }

        public int id
        {
            get { return _intId; }
            set { _intId = value; }
        }

        public String season
        {
            get { return _strSeason; }
            set { _strSeason = value; }
        }

        public String description
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }
    }
}
