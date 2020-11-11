using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;

namespace ByteJamObjects
{
    public class Voter : ICloneable
    {
        public string FirstName;
        public string LastName;
        public Image Photo;
        public char Gender;
        public string City;
        public string State;
        public string ZipCode;
        public string AddressLine1;
        public string AddressLine2;
        public string SSID;

        public Voter()
        {
            FirstName = "Joseph";
            LastName = "Smith";
            Gender = 'M';
            City = "Ottumwa";
            State = "IA";
            ZipCode = "52501";
            AddressLine1 = "624 E Second Street";
            AddressLine2 = " ";
            SSID = "654652351";
        }

        public object Clone()
        {
            return new Voter(FirstName, LastName, Photo, Gender, City, State, ZipCode,
                AddressLine1, AddressLine2, SSID);
        }

        public Voter(string firstName, string lastName, Image photo, char gender, 
            string city, string state, string zipCode, string addressLine1, string addressLine2, string sSID)
        {
            FirstName = firstName;
            LastName = lastName;
            Photo = photo;
            Gender = gender;
            City = city;
            State = state;
            ZipCode = zipCode;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            SSID = sSID;
        }

        public Voter( DataRow row, int index )
        {
            FirstName = row.Field<string>( "CFirstName" );
            LastName = row.Field<string>( "CLastName" );
            Photo = Image.FromFile( $"{Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData )}\\ByteJam\\images\\port{index}.png" );
            Gender = row.Field<string>("CGender")?[0] ?? '?';
            City = row.Field<string>("CCity");
            State = row.Field<string>("CState");
            ZipCode = row.Field<string>("CZip");
            AddressLine1 = row.Field<string>("CAddressLine1");
            AddressLine2 = row.Field<string>("CAddressLine2");
            SSID = row.Field<string>("CSSID");
        }
    }
}
