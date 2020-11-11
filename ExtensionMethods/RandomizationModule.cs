using System;
using US_Codestitution;

namespace ByteJamObjects
{
    static class RandomizationModule
    {

        public static Random random = new Random();
        private static bool ShouldRandomize { get { return random.Next( 4 ) == 0; } }

        public static bool Randomize( this Voter voter, int index )
        {

            if ( !ShouldRandomize )
                return false;

            int indexToUse = index + 1;
            if ( indexToUse >= 22 )
                indexToUse = 0;
            int fieldToRandomize = random.Next( 9 );
            switch ( fieldToRandomize )
            {
                case 0:
                    voter.FirstName = Form1.voters[indexToUse].FirstName;
                    break;
                case 1:
                    voter.LastName = Form1.voters[indexToUse].LastName;
                    break;
                case 2:
                    voter.Photo = Form1.voters[indexToUse].Photo;
                    break;
                case 3:
                    voter.Gender = Form1.voters[indexToUse].Gender;
                    break;
                case 4:
                    voter.City = Form1.voters[indexToUse].City;
                    break;
                case 5:
                    voter.State = Form1.voters[indexToUse].State;
                    break;
                case 6:
                    voter.ZipCode = Form1.voters[indexToUse].ZipCode;
                    break;
                case 7:
                    voter.AddressLine1 = Form1.voters[indexToUse].AddressLine1;
                    voter.AddressLine2 = Form1.voters[indexToUse].AddressLine2;
                    break;
                case 8:
                    voter.SSID = Form1.voters[indexToUse].SSID;
                    break;
                default:
                    break;
            }
            return true;
        }
        public static bool Randomize( this Ballot ballot, int index )
        {
            if ( !ShouldRandomize )
                return false;

            int indexToUse = index + 1;
            if ( indexToUse >= 22 )
                indexToUse = 0;
            int fieldToRandomize = random.Next( 7 );
            switch ( fieldToRandomize )
            {
                case 0:
                    ballot.FirstName = Form1.ballots[indexToUse].FirstName;
                    break;
                case 1:
                    ballot.LastName = Form1.ballots[indexToUse].LastName;
                    break;
                case 2:
                    ballot.SSID = Form1.ballots[indexToUse].SSID;
                    break;
                case 3:
                    ballot.City = Form1.ballots[indexToUse].City;
                    break;
                case 4:
                    ballot.State = Form1.ballots[indexToUse].State;
                    break;
                case 5:
                    ballot.ZipCode = Form1.ballots[indexToUse].ZipCode;
                    break;
                case 6:
                    ballot.AddressLine1 = Form1.ballots[indexToUse].AddressLine1;
                    ballot.AddressLine2 = Form1.ballots[indexToUse].AddressLine2;
                    break;
                default:
                    break;
            }
            return true;
        }
        public static bool Randomize( this DriversLicense driversLicense, int index )
        {
            if ( !ShouldRandomize )
                return false;

            int indexToUse = index + 1;
            if ( indexToUse >= 22 )
                indexToUse = 0;
            int fieldToRandomize = random.Next( 8 );
            switch ( fieldToRandomize )
            {
                case 0:
                    driversLicense.FirstName = Form1.driversLicenses[indexToUse].FirstName;
                    break;
                case 1:
                    driversLicense.LastName = Form1.driversLicenses[indexToUse].LastName;
                    break;
                case 2:
                    driversLicense.Photo = Form1.driversLicenses[indexToUse].Photo;
                    break;
                case 3:
                    driversLicense.Gender = Form1.driversLicenses[indexToUse].Gender;
                    break;
                case 4:
                    driversLicense.City = Form1.driversLicenses[indexToUse].City;
                    break;
                case 5:
                    driversLicense.State = Form1.driversLicenses[indexToUse].State;
                    break;
                case 6:
                    driversLicense.ZipCode = Form1.driversLicenses[indexToUse].ZipCode;
                    break;
                case 7:
                    driversLicense.AddressLine1 = Form1.driversLicenses[indexToUse].AddressLine1;
                    driversLicense.AddressLine2 = Form1.driversLicenses[indexToUse].AddressLine2;
                    break;
                default:
                    break;
            }
            return true;
        }

        public static bool Randomize( this Social social, int index )
        {
            if ( !ShouldRandomize )
                return false;

            int indexToUse = index + 1;
            if ( indexToUse >= 22 )
                indexToUse = 0;

            int fieldToRandomize = random.Next( 2 );
            switch ( fieldToRandomize )
            {
                case 0:
                    social.FullName = Form1.socials[indexToUse].FullName;
                    break;
                case 1:
                    social.SSN = Form1.socials[indexToUse].SSN;
                    break;
                default:
                    break;
            }
            return true;
        }
    }
}
