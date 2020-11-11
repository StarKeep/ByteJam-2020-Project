using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;

namespace ByteJamObjects
{
    public class DriversLicense : ICloneable
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

        public DriversLicense()
        {
            FirstName = "Joseph";
            LastName = "Smith";
            Gender = 'M';
            City = "Ottumwa";
            State = "IA";
            ZipCode = "52501";
            AddressLine1 = "624 E Second Street";
            AddressLine2 = " ";
        }

        public object Clone()
        {
            return new DriversLicense(FirstName, LastName, Photo, Gender, City, State,
                ZipCode, AddressLine1, AddressLine2);
        }

        public DriversLicense(string firstName, string lastName, Image photo, char gender,
            string city, string state, string zipCode, string addressLine1, string addressLine2)
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
        }

        public DriversLicense(DataRow row, int index)
        {
            FirstName = row.Field<string>("DFirstName");
            LastName = row.Field<string>("DLastName");
            Photo = Image.FromFile( $"{Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData )}\\ByteJam\\images\\port{index}.png" );
            Gender = row.Field<string>( "DGender" )?[0] ?? '?';
            City = row.Field<string>("DCity");
            State = row.Field<string>("DState");
            ZipCode = row.Field<string>("DZip");
            AddressLine1 = row.Field<string>("DAddressLine1");
            AddressLine2 = row.Field<string>("DAddressLine2");
        }
    }
}
