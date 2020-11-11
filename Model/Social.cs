using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using US_Codestitution;

namespace ByteJamObjects
{
    public class Social : ICloneable
    {
        public string FullName;
        public string SSN;

        public Social()
        {
         
            SSN = "654652351";
        }

        public object Clone()
        {
            return new Social(FullName,SSN);
        }
        public Social( string fullName, string sSN)
        {
            FullName = fullName;
            SSN = sSN;
        }

        public Social(DataRow row, int rowIndex)
        {
            FullName = $"{Form1.voters[rowIndex].FirstName.Trim()} {Form1.voters[rowIndex].LastName.Trim()}";
            SSN = row.Field<string>( "SSocialSecurityNumber" );
        }
    }
}
