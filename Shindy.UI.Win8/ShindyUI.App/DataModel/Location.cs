﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShindyUI.App.Common;

namespace ShindyUI.App.DataModel
{
    public class Location : BindableBase
    {
        public Location()
        {
        
        }
        private string id;
        public string Id
        {
            get { return this.id; }
            set { this.SetProperty(ref this.id, value); }
        }

        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.SetProperty(ref this.name, value); }
        }

        private string locationURI;
        public string LocationURI
        {
            get { return this.locationURI; }
            set { this.SetProperty(ref this.locationURI, value); }
        }

        public Event HostedEvents { get; set; }

        public virtual Event Event { get; set; }

        public virtual Address Address { get; set; }

    }
}
