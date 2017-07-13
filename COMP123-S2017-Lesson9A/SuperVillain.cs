using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Nguyen Thi Kim Ngan
 * Date: July 13, 2017
 * Description: This is the SuperVillain class which is inherits from SuperHuman Class
 * and implements the  IHasMalice Interface
 * Version: 0.1- Create SuperVillain class
 */

namespace COMP123_S2017_Lesson9A
{
    /// <summary>
    /// This is SuperVillain class
    /// </summary>
    public class SuperVillain : SuperHuman, IHasMalice
    {
        // private instance variable
        private int _malice;
        // public property
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }
        /// <summary>
        /// This is main contructors of SuperVillain Class
        /// It takes two arguments: name, mallice
        /// </summary>
        /// <param name="name"></param>
        public SuperVillain(string name,int malice) : base(name)
        {
            this._malice = malice;
        }
    }
}