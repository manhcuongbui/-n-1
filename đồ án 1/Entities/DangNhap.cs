﻿using System;
using System.Collections.Generic;
using System.Text;

namespace đồ_án_1.Entities
{

    public class DangNhap
    {
        private string user;
        private string pass;
        public DangNhap()
        { }
        public DangNhap(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }
        public DangNhap(DangNhap t)
        {
            this.pass = t.pass;
            this.user = t.user;
        }
        public string Pass
        {
            get { return pass; }
            set
            {
                if (value != "")
                    pass = value;
            }
        }
        public string Urser
        {
            get { return user; }
            set
            {
                if (value != "")
                    user = value;
            }
        }
    }
}
