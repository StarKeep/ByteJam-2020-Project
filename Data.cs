using ByteJamObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace US_Codestitution
{
	public partial class Form1
	{
		public static List<Voter> voters;
		public static List<Ballot> ballots;
		public static List<DriversLicense> driversLicenses;
		public static List<Social> socials;

		public void InitializeData()
		{
			try
			{
				// Create a new adapter and give it a query to fetch sales order, contact,
				// address, and product information for sales in the year 2002. Point connection
				// information to the configuration setting "AdventureWorks".
				string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BytejamDatabase;Integrated Security=True";
				SqlConnection connection = new SqlConnection( connectionString );

				InitializeVoters( connection );
				InitializeBallots( connection );
				InitializeLicenses( connection );
				InitializeSocials( connection );
			}
			catch ( SqlException ex )
			{
				Console.WriteLine( "SQL exception occurred: " + ex.Message );
			}
		}
		private void InitializeVoters( SqlConnection connection )
		{
			string commandText = "select * from Voters";
			SqlCommand command = new SqlCommand( commandText, connection );

			SqlDataAdapter da = new SqlDataAdapter( command );
			da.SelectCommand = command;

			voters = new List<Voter>();

			DataTable dt = new DataTable();

			da.Fill( dt );

			SortedDictionary<int, Voter> votersSorted = new SortedDictionary<int, Voter>();

			foreach ( DataRow row in dt.Rows )
			{
				if ( int.TryParse( row.Field<string>( "CID" ), out int rowIndex ) )
					if ( rowIndex > -1 )
						votersSorted.Add( rowIndex, new Voter( row, rowIndex ) );
			}

			foreach ( Voter voter in votersSorted.Values )
				voters.Add( voter );
		}
		private void InitializeBallots( SqlConnection connection )
		{
			string commandText = "select * from Ballots";
			SqlCommand command = new SqlCommand( commandText, connection );

			SqlDataAdapter da = new SqlDataAdapter( command );
			da.SelectCommand = command;

			ballots = new List<Ballot>();

			DataTable dt = new DataTable();

			da.Fill( dt );

			SortedDictionary<int, Ballot> ballotsSorted = new SortedDictionary<int, Ballot>();

			foreach ( DataRow row in dt.Rows )
			{
				if ( int.TryParse( row.Field<string>( "BID" ), out int rowIndex ) )
					if ( rowIndex > -1 )
					{
						Ballot newBallot = new Ballot( row );
						if ( newBallot.FirstName != null && newBallot.FirstName.Length > 2 )
							ballotsSorted.Add( rowIndex, newBallot );
					}
			}

			foreach ( Ballot ballot in ballotsSorted.Values )
				ballots.Add( ballot );
		}
		private void InitializeLicenses( SqlConnection connection )
		{
			string commandText = "select * from Licenses";
			SqlCommand command = new SqlCommand( commandText, connection );

			SqlDataAdapter da = new SqlDataAdapter( command );
			da.SelectCommand = command;

			driversLicenses = new List<DriversLicense>();

			DataTable dt = new DataTable();

			da.Fill( dt );

			SortedDictionary<int, DriversLicense> licensesSorted = new SortedDictionary<int, DriversLicense>();

			foreach ( DataRow row in dt.Rows )
			{
				if ( int.TryParse( row.Field<string>( "DID" ), out int rowIndex ) )
					if ( rowIndex > -1 )
						licensesSorted.Add( rowIndex, new DriversLicense( row, rowIndex ) );
			}

			foreach ( DriversLicense license in licensesSorted.Values )
				driversLicenses.Add( license );
		}
		private void InitializeSocials( SqlConnection connection )
		{
			string commandText = "select * from SocialSecurities";
			SqlCommand command = new SqlCommand( commandText, connection );

			SqlDataAdapter da = new SqlDataAdapter( command );
			da.SelectCommand = command;

			socials = new List<Social>();

			DataTable dt = new DataTable();

			da.Fill( dt );

			SortedDictionary<int, Social> socialsSorted = new SortedDictionary<int, Social>();

			foreach ( DataRow row in dt.Rows )
			{
				if ( int.TryParse( row.Field<string>( "SID" ), out int rowIndex ) )
					if ( rowIndex > -1 )
						socialsSorted.Add( rowIndex, new Social( row, rowIndex ) );
			}

			foreach ( Social social in socialsSorted.Values )
				socials.Add( social );
		}
	}
}
