using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ByteJamObjects
{
    public class Ballot : ICloneable
    {
        public string FirstName;
        public string LastName;
        public string SSID;
        public string City;
        public string State;
        public string ZipCode;
        public string AddressLine1;
        public string AddressLine2;

        public Ballot()
        {
            FirstName = "Joseph";
            LastName = "Smith";
            SSID = "654652351";
            City = "Ottumwa";
            State = "IA";
            ZipCode = "52501";
            AddressLine1 = "624 E Second Street";
            AddressLine2 = " ";
        }

        public object Clone()
        {
            return new Ballot(FirstName, LastName, SSID, City, State, ZipCode, AddressLine1, AddressLine2);
        }

        public Ballot(string firstName, string lastName, string sSID, string city,
            string state, string zipCode, string addressLine1, string addressLine2)
        {
            FirstName = firstName;
            LastName = lastName;
            SSID = sSID;
            City = city;
            State = state;
            ZipCode = zipCode;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
        }

        public Ballot(DataRow row)
        {
            FirstName = row.Field<string>("BFirstName");
            LastName = row.Field<string>("BLastName");
            SSID = row.Field<string>("BSSID");
            City = row.Field<string>("BState");
            State = row.Field<string>("BState");
            ZipCode = row.Field<string>("BZip");
            AddressLine1 = row.Field<string>("BAddressLine1");
            AddressLine2 = row.Field<string>("BAddressLine2");
        }
    }
}
