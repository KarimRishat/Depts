using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stolovka
{
    public enum Post
    {
        Teacher,
        Сleaner,
        Manager
    }
    public enum Color
    {
        Green,
        Red,
        Purple,
        Blue,
        Grey,
        White,
        Black,
        Brown,
        Pink
    }
    class Worker
    {
        public string name;
        public Post post;
        public int cheek;
        public bool stupidity;

        public Worker(string name, Post post, int cheek, bool stupidity)
        {
            this.name = name;
            this.post = post;
            this.cheek = cheek;
            this.stupidity = stupidity;
        }
        public override string ToString()
        {
            return $"[{name}, {post}, {cheek}, {stupidity}]";
        }
    }
}
