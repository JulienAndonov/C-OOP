using System;
using System.Collections.Generic;
using System.Text;

namespace P06_Birthday_Celebrations
{
    public class Robot : IIDable
    {
        private string id;
        private string model;

        public Robot(string id,string model)
        {
            this.ID = id;
            this.Model = model;
        }

        private string Model
        {
            get => this.model;
            set => this.model = value;
        }
        

        public string ID
        {
            get => this.id;
            set => this.id = value;
        }
        public string BirthDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
