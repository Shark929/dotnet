using System;

namespace Defining{
        class Books {
        public string _name;
        protected string _author;
        private int _pages;

        public Books(string name, string author, int pages){
            _name = name;
            _author = author;
            _pages = pages;
        }

        public string Name {
            get => _name;
            set => _name = value;
        }

        public string Author {
            get => _author;
            set => _author = value;
        }

        public int Pages{
            get => _pages;
            set => _pages = value;
        }

        public string Description {
            get => $"{Name} by {Author}, {Pages} pages";
        }
    }
}